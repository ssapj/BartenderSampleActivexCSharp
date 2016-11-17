using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Drawing.Printing;
using System.Windows.Forms;
using ssapj.BarTenderSampleActivexCSharp.Models;

namespace ssapj.BarTenderSampleActivexCSharp
{
    public partial class Form1 : Form
    {
        //BarTenderでの処理はControlBartenderクラスで行っているのでそちらを参照してください
        private ControlBartender _bartenderApplication;
        private string _basePath;
        private string _tempImagePath;

        public Form1()
        {
            InitializeComponent();

            this.Load += (_, __) =>
            {
                //プリンター一覧を取得してコンボボックスにセット
                ComboBoxPrintersList.Items.Clear();
                foreach (string p in PrinterSettings.InstalledPrinters)
                {
                    ComboBoxPrintersList.Items.Add(p);
                }

                this._basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                this.InitializeBartender();
            };


            //テキストボックスに入力された内容が実在するファイルのパスではない場合は、設定ボタンを押下できないよう制御
            this.TextBoxBtwFilePath.TextChanged += (sender, _) => ButtonOpenBtwFileAndSetValue.Enabled = File.Exists(((TextBox)sender).Text);

            this.ButtonSelectBtwFile.Click += (_, __) =>
            {
                var ofd = new OpenFileDialog
                {
                    InitialDirectory = Path.Combine(this._basePath, "BTW"),
                    Filter = "BarTender ドキュメント(*.btw)|*.btw"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxBtwFilePath.Text = ofd.FileName;
                }
            };

            this.ButtonSelectCsvFile.Click += (_, __) =>
            {
                var ofd = new OpenFileDialog
                {
                    InitialDirectory = Path.Combine(this._basePath, "PrintCSV")
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxCsvFilePath.Text = ofd.FileName;
                }
            };

            this.CheckBoxIsDriverBySeagull.CheckStateChanged += (sender, _) => NumericUpDownCutInterval.Enabled = ((CheckBox)sender).CheckState == CheckState.Checked;

            this.ButtonOpenBtwFileAndSetValue.Click += (_, __) =>
            {
                this.ResetImageView();

                //SEAGULL SCIENTIFIC SAMPLEの『BTW』ボタンより設定したBTWファイルをオープンします
                this._bartenderApplication.OpenFormat(TextBoxBtwFilePath.Text, ComboBoxPrintersList.Text);

                //SEAGULL SCIENTIFIC SAMPLEの『CSV』ボタンより設定したファイルをデータベースとして接続します
                if (TextBoxCsvFilePath.Text != "")
                {
                    this._bartenderApplication.SetDatabase(TextBoxCsvFilePath.Text);
                }

                this._bartenderApplication.SetNamedSubStringValue("datacomment1", TextBoxNamedSubString.Text);
                this._bartenderApplication.ControlTargetDesignObeject("objcomment1", CheckBoxIsDesignObjectEmphasis.CheckState == CheckState.Checked);
                this._bartenderApplication.SetPrintNumbers((int)NumericUpDownNumberSerializedLabels.Value, (int)NumericUpDownIdenticalCopiesOfLabel.Value);
                this._bartenderApplication.SetCutInterval(CheckBoxIsDriverBySeagull.CheckState == CheckState.Checked, (int)NumericUpDownCutInterval.Value);

                this.SetButtonsState(true);
            };

            //------SEAGULL SCIENTIFIC SAMPLEの『画像プレビュー』ボタンが押下された時に実行されます-----
            this.ButtonShowImagePreview.Click += (_, __) =>
            {
                if (this._tempImagePath != null) return;

                this.ButtonShowImagePreview.Enabled = false;
                this._tempImagePath = this._bartenderApplication.CreateCaptureImage();
                PictureBoxShowPreviewOfBartender.ImageLocation = _tempImagePath;
            };

            this.ButtonShowPreviewDialog.Click += (_, __) => this._bartenderApplication.ShowPreview();

            this.ButtonExportPrintPreview.Click += (_, __) => this._bartenderApplication.ExportPrintPreviewToImage();

            //------SEAGULL SCIENTIFIC SAMPLEの『印刷』ボタンが押下された時に実行されます-----
            this.ButtonPrint.Click += (_, __) =>
            {
                this._bartenderApplication.PrintAndCloseFormat();

                //フォーマットを閉じるので表示もリセット
                this.ResetImageView();
                this.SetButtonsState(false);
            };

            this.Closed += (_, __) =>
            {
                this.ResetImageView();
                this._bartenderApplication.Dispose();
            };
        }

        private void InitializeBartender()
        {
            this.SetButtonsState(false);
            this._bartenderApplication = new ControlBartender();
        }

        private void SetButtonsState(bool isEnabled)
        {
            ButtonPrint.Enabled = isEnabled;
            ButtonShowImagePreview.Enabled = isEnabled;
            ButtonShowPreviewDialog.Enabled = isEnabled;
            ButtonExportPrintPreview.Enabled = isEnabled;
        }

        //----プレビュー表示をリセットします----
        private void ResetImageView()
        {
            if (this._tempImagePath == null) return;

            if (PictureBoxShowPreviewOfBartender.Image != null)
            {
                PictureBoxShowPreviewOfBartender.Image.Dispose();
                PictureBoxShowPreviewOfBartender.Image = null;
            }

            File.Delete(this._tempImagePath);
            this._tempImagePath = null;
        }

        ~Form1()
        {
            this._bartenderApplication.Dispose();
        }

    }
}

