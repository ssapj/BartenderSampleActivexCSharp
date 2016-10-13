using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ssapj.BarTenderSampleActivexCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSelectBtwFile = new Button();
            this.ButtonSelectCsvFile = new Button();
            this.CheckBoxIsDriverBySeagull = new CheckBox();
            this.CheckBoxIsDesignObjectEmphasis = new CheckBox();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.ButtonOpenBtwFileAndSetValue = new Button();
            this.ButtonShowImagePreview = new Button();
            this.ButtonShowPreviewDialog = new Button();
            this.ButtonExportPrintPreview = new Button();
            this.PictureBoxShowPreviewOfBartender = new PictureBox();
            this.ComboBoxPrintersList = new ComboBox();
            this.TextBoxBtwFilePath = new TextBox();
            this.TextBoxCsvFilePath = new TextBox();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.TextBoxNamedSubString = new TextBox();
            this.ButtonPrint = new Button();
            this.NumericUpDownNumberSerializedLabels = new NumericUpDown();
            this.NumericUpDownIdenticalCopiesOfLabel = new NumericUpDown();
            this.NumericUpDownCutInterval = new NumericUpDown();
            ((ISupportInitialize)(this.PictureBoxShowPreviewOfBartender)).BeginInit();
            ((ISupportInitialize)(this.NumericUpDownNumberSerializedLabels)).BeginInit();
            ((ISupportInitialize)(this.NumericUpDownIdenticalCopiesOfLabel)).BeginInit();
            ((ISupportInitialize)(this.NumericUpDownCutInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSelectBtwFile
            // 
            this.ButtonSelectBtwFile.Location = new Point(248, 7);
            this.ButtonSelectBtwFile.Name = "ButtonSelectBtwFile";
            this.ButtonSelectBtwFile.Size = new Size(56, 23);
            this.ButtonSelectBtwFile.TabIndex = 41;
            this.ButtonSelectBtwFile.Text = "BTW";
            this.ButtonSelectBtwFile.UseVisualStyleBackColor = true;
            // 
            // ButtonSelectCsvFile
            // 
            this.ButtonSelectCsvFile.Location = new Point(248, 35);
            this.ButtonSelectCsvFile.Name = "ButtonSelectCsvFile";
            this.ButtonSelectCsvFile.Size = new Size(56, 23);
            this.ButtonSelectCsvFile.TabIndex = 23;
            this.ButtonSelectCsvFile.Text = "CSV";
            this.ButtonSelectCsvFile.UseVisualStyleBackColor = true;
            // 
            // CheckBoxIsDriverBySeagull
            // 
            this.CheckBoxIsDriverBySeagull.AutoSize = true;
            this.CheckBoxIsDriverBySeagull.Location = new Point(245, 205);
            this.CheckBoxIsDriverBySeagull.Name = "CheckBoxIsDriverBySeagull";
            this.CheckBoxIsDriverBySeagull.Size = new Size(103, 21);
            this.CheckBoxIsDriverBySeagull.TabIndex = 39;
            this.CheckBoxIsDriverBySeagull.Text = "Seagull Driver";
            this.CheckBoxIsDriverBySeagull.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label6.Location = new Point(5, 92);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(181, 33);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "注意（強調）";
            // 
            // CkEmphasis
            // 
            this.CheckBoxIsDesignObjectEmphasis.Location = new Point(130, 92);
            this.CheckBoxIsDesignObjectEmphasis.Name = "CkEmphasis";
            this.CheckBoxIsDesignObjectEmphasis.Size = new Size(20, 18);
            this.CheckBoxIsDesignObjectEmphasis.TabIndex = 42;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label5.Location = new Point(5, 203);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(149, 33);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "カット枚数";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label4.Location = new Point(5, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(156, 33);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "コピー枚数";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new Point(5, 148);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(147, 33);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "連番枚数";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new Point(5, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(81, 33);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "備考";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new Point(5, 120);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(108, 33);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "プリンタ";
            // 
            // ButtonOpenBtwFileAndSetValue
            // 
            this.ButtonOpenBtwFileAndSetValue.Enabled = false;
            this.ButtonOpenBtwFileAndSetValue.Location = new Point(5, 231);
            this.ButtonOpenBtwFileAndSetValue.Name = "ButtonOpenBtwFileAndSetValue";
            this.ButtonOpenBtwFileAndSetValue.Size = new Size(75, 23);
            this.ButtonOpenBtwFileAndSetValue.TabIndex = 27;
            this.ButtonOpenBtwFileAndSetValue.Text = "設定完了";
            this.ButtonOpenBtwFileAndSetValue.UseVisualStyleBackColor = true;
            // 
            // ButtonShowImagePreview
            // 
            this.ButtonShowImagePreview.Enabled = false;
            this.ButtonShowImagePreview.Location = new Point(5, 563);
            this.ButtonShowImagePreview.Name = "ButtonShowImagePreview";
            this.ButtonShowImagePreview.Size = new Size(86, 23);
            this.ButtonShowImagePreview.TabIndex = 26;
            this.ButtonShowImagePreview.Text = "画像プレビュー";
            this.ButtonShowImagePreview.UseVisualStyleBackColor = true;
            // 
            // ButtonShowPreviewDialog
            // 
            this.ButtonShowPreviewDialog.Enabled = false;
            this.ButtonShowPreviewDialog.Location = new Point(110, 563);
            this.ButtonShowPreviewDialog.Name = "ButtonShowPreviewDialog";
            this.ButtonShowPreviewDialog.Size = new Size(75, 23);
            this.ButtonShowPreviewDialog.TabIndex = 28;
            this.ButtonShowPreviewDialog.Text = "BTプレビュー";
            this.ButtonShowPreviewDialog.UseVisualStyleBackColor = true;
            // 
            // ButtonExportPrintPreview
            // 
            this.ButtonExportPrintPreview.Enabled = false;
            this.ButtonExportPrintPreview.Location = new Point(204, 563);
            this.ButtonExportPrintPreview.Name = "ButtonExportPrintPreview";
            this.ButtonExportPrintPreview.Size = new Size(120, 23);
            this.ButtonExportPrintPreview.TabIndex = 46;
            this.ButtonExportPrintPreview.Text = "プレビューエクスポート";
            this.ButtonExportPrintPreview.UseVisualStyleBackColor = true;
            // 
            // PictureBoxShowPreviewOfBartender
            // 
            this.PictureBoxShowPreviewOfBartender.Location = new Point(5, 294);
            this.PictureBoxShowPreviewOfBartender.Name = "PictureBoxShowPreviewOfBartender";
            this.PictureBoxShowPreviewOfBartender.Size = new Size(280, 258);
            this.PictureBoxShowPreviewOfBartender.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBoxShowPreviewOfBartender.TabIndex = 25;
            this.PictureBoxShowPreviewOfBartender.TabStop = false;
            // 
            // ComboBoxPrintersList
            // 
            this.ComboBoxPrintersList.FormattingEnabled = true;
            this.ComboBoxPrintersList.Location = new Point(120, 120);
            this.ComboBoxPrintersList.Name = "ComboBoxPrintersList";
            this.ComboBoxPrintersList.Size = new Size(175, 20);
            this.ComboBoxPrintersList.TabIndex = 24;
            // 
            // TextBoxBtwFilePath
            // 
            this.TextBoxBtwFilePath.Location = new Point(5, 9);
            this.TextBoxBtwFilePath.Name = "TextBoxBtwFilePath";
            this.TextBoxBtwFilePath.Size = new Size(222, 19);
            this.TextBoxBtwFilePath.TabIndex = 40;
            // 
            // TextBoxCsvFilePath
            // 
            this.TextBoxCsvFilePath.Location = new Point(5, 37);
            this.TextBoxCsvFilePath.Name = "TextBoxCsvFilePath";
            this.TextBoxCsvFilePath.Size = new Size(222, 19);
            this.TextBoxCsvFilePath.TabIndex = 22;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TextBoxNamedSubString
            // 
            this.TextBoxNamedSubString.Location = new Point(120, 65);
            this.TextBoxNamedSubString.Name = "TextBoxNamedSubString";
            this.TextBoxNamedSubString.Size = new Size(175, 19);
            this.TextBoxNamedSubString.TabIndex = 21;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Enabled = false;
            this.ButtonPrint.Location = new Point(110, 231);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new Size(75, 23);
            this.ButtonPrint.TabIndex = 20;
            this.ButtonPrint.Text = "印刷";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownNumberSerializedLabels
            // 
            this.NumericUpDownNumberSerializedLabels.Location = new Point(120, 148);
            this.NumericUpDownNumberSerializedLabels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownNumberSerializedLabels.Name = "NumericUpDownNumberSerializedLabels";
            this.NumericUpDownNumberSerializedLabels.Size = new Size(120, 19);
            this.NumericUpDownNumberSerializedLabels.TabIndex = 43;
            this.NumericUpDownNumberSerializedLabels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownIdenticalCopiesOfLabel
            // 
            this.NumericUpDownIdenticalCopiesOfLabel.Location = new Point(120, 175);
            this.NumericUpDownIdenticalCopiesOfLabel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIdenticalCopiesOfLabel.Name = "NumericUpDownIdenticalCopiesOfLabel";
            this.NumericUpDownIdenticalCopiesOfLabel.Size = new Size(120, 19);
            this.NumericUpDownIdenticalCopiesOfLabel.TabIndex = 44;
            this.NumericUpDownIdenticalCopiesOfLabel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownCutInterval
            // 
            this.NumericUpDownCutInterval.Enabled = false;
            this.NumericUpDownCutInterval.Location = new Point(120, 203);
            this.NumericUpDownCutInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownCutInterval.Name = "NumericUpDownCutInterval";
            this.NumericUpDownCutInterval.Size = new Size(74, 19);
            this.NumericUpDownCutInterval.TabIndex = 45;
            this.NumericUpDownCutInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 12F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(364, 610);
            this.Controls.Add(this.ButtonExportPrintPreview);
            this.Controls.Add(this.NumericUpDownCutInterval);
            this.Controls.Add(this.NumericUpDownIdenticalCopiesOfLabel);
            this.Controls.Add(this.NumericUpDownNumberSerializedLabels);
            this.Controls.Add(this.ButtonSelectBtwFile);
            this.Controls.Add(this.TextBoxBtwFilePath);
            this.Controls.Add(this.CheckBoxIsDriverBySeagull);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.CheckBoxIsDesignObjectEmphasis);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonOpenBtwFileAndSetValue);
            this.Controls.Add(this.ButtonShowImagePreview);
            this.Controls.Add(this.ComboBoxPrintersList);
            this.Controls.Add(this.ButtonSelectCsvFile);
            this.Controls.Add(this.TextBoxCsvFilePath);
            this.Controls.Add(this.ButtonShowPreviewDialog);
            this.Controls.Add(this.TextBoxNamedSubString);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.PictureBoxShowPreviewOfBartender);
            this.Name = "Form1";
            this.Text = "SEAGULL SCIENTIFIC  SAMPLE";
            ((ISupportInitialize)(this.PictureBoxShowPreviewOfBartender)).EndInit();
            ((ISupportInitialize)(this.NumericUpDownNumberSerializedLabels)).EndInit();
            ((ISupportInitialize)(this.NumericUpDownIdenticalCopiesOfLabel)).EndInit();
            ((ISupportInitialize)(this.NumericUpDownCutInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        internal TextBox TextBoxBtwFilePath;
        internal TextBox TextBoxCsvFilePath;
        internal TextBox TextBoxNamedSubString;
        internal ComboBox ComboBoxPrintersList;
        internal CheckBox CheckBoxIsDriverBySeagull;
        internal CheckBox CheckBoxIsDesignObjectEmphasis;
        private NumericUpDown NumericUpDownNumberSerializedLabels;
        private NumericUpDown NumericUpDownIdenticalCopiesOfLabel;
        private NumericUpDown NumericUpDownCutInterval;
        internal Button ButtonSelectCsvFile;
        internal Button ButtonSelectBtwFile;
        internal Button ButtonOpenBtwFileAndSetValue;
        internal Button ButtonShowImagePreview;
        internal Button ButtonShowPreviewDialog;
        internal Button ButtonExportPrintPreview;
        internal Button ButtonPrint;
        internal PictureBox PictureBoxShowPreviewOfBartender;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Label Label6;
        internal OpenFileDialog OpenFileDialog1;
    }
}

