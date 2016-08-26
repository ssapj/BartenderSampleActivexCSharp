using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ssapj.BarTenderSampleActivexCSharp
{
    public partial class Form1 : Form
    {
        //バーテンダーインスタンスの宣言
        BarTender.Application btApp;
        //バーテンダーフォーマットの宣言
        BarTender.Format btFormat;
        //アプリケーションの配置ディレクトリの取得用変数
        string basePath;
        //バーテンダーインスタンスのプロセスID格納用変数
        int btAppPID;
        //ラベルのイメージエクスポートパス格納用変数
        string tempImagePath = null;

        public Form1()
        {
            InitializeComponent();

        }

        ~Form1()
        {
            //btAppがリリースされていなければリリースします
            System.Runtime.InteropServices.Marshal.ReleaseComObject(btApp);
        }

        //------フォームのロード時に実行されます------
        private void Form1_Load(object sender, EventArgs e)
        {
            //プリンタ選択用コンボボックス
            PrinterList.Items.Clear();
            //プリンタ一覧を取得
            foreach (string p in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                PrinterList.Items.Add(p);
            }

            //このプログラムが配置されたディレクトリを取得
            basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //バーテンダーを初期化
            btIntialize();
        }

        //------コントロールするバーテンダーを初期化します------
        private void btIntialize()
        {
            //SEAGULL SCIENTIFIC SAMPLE画面内のボタン初期化処理
            ActualPrint.Enabled = false;
            ImagePreview.Enabled = false;
            BtPreviw.Enabled = false;

            //バーテンダアプリケーションインスタンスの作成
            btApp = new BarTender.Application();

            //バーテンダーウィンドウの表示設定(ダイアログのみ表示)
            btApp.VisibleWindows = BarTender.BtVisibleWindows.btInteractiveDialogs;

            //インスタンスのプロセスIDを取得
            btAppPID = btApp.ProcessId;
        }

        //------SEAGULL SCIENTIFIC SAMPLEの『設定完了』ボタン押下時に実行されます------
        private void SetValue_Click(object sender, EventArgs e)
        {
            //Image Box 初期化関数
            imageViewReset();

            try
            {
                //SEAGULL SCIENTIFIC SAMPLEの『BTW』ボタンより設定したBTWファイルをオープンします
                btFormat = btApp.Formats.Open(btwFilePath.Text, false, "");

                //データベースファイルの選択と接続
                //SEAGULL SCIENTIFIC SAMPLEの『CSV』ボタンより設定したファイルをデータベースとして接続します
                if (databaseFilePath.Text != "")
                {
                    BarTender.Database btDb;
                    btDb = btFormat.Databases.GetDatabase(1);
                    btDb.TextFile.FileName = databaseFilePath.Text;
                }

                //SEAGULL SCIENTIFIC SAMPLEの『備考』に入力した値
                //BTWファイル内のサブ文字列(データソース名)"datacomment" にテキストボックスの値をセット
                btFormat.SetNamedSubStringValue("datacomment1", TextBox1.Text);


                BarTender.DesignObject btObject;
                btObject = btFormat.Objects.Find("objcomment1");

                //SEAGULL SCIENTIFIC SAMPLEの『注意(強調)』BoxオブジェクトのチェックがONの場合は、
                //BTWファイル内のobjcomment1のカラーを赤に設定
                //チェックがOFFの場合はobjcomment1のカラーを黒に設定
                //0xの後にARGBをそれぞれ256ビットで指定
                if (CkEmphasis.CheckState == CheckState.Checked)
                {
                    //文字を赤に変更
                    btObject.TextColor = 0xFFFF0000;
                    btObject.FontBold = true;
                }
                else
                {
                    //文字を黒に変更
                    btObject.TextColor = 0xFF000000;
                    btObject.FontBold = false;
                }

                //-------印刷設定
                if (PrinterList.Text != "")
                {
                    BarTender.PrintSetup btPrintSetup;
                    btPrintSetup = btFormat.PrintSetup;
                    //ドロップダウンリストで選んだプリンタを出力先にセット
                    btPrintSetup.Printer = PrinterList.Text;
                }

                //連番発行数をセット
                btFormat.NumberSerializedLabels = (int)NSL.Value;
                //コピー数をセット
                btFormat.IdenticalCopiesOfLabel = (int)ICOL.Value;

                //SEAGULL SCIENTIFIC SAMPLEの『Seagull Driver』のチェックがONの時に
                //カット設定を有効とする
                if (CkSeagull.CheckState == CheckState.Checked)
                {
                    BarTender.MediaHandling btMediaHandling;
                    btMediaHandling = btFormat.PageSetup.MediaHandling;
                    btMediaHandling.Action = BarTender.BtMediaHandlingAction.btMHCut;
                    btMediaHandling.Occurrence = BarTender.BtMediaHandlingOccurrence.btMHAfterNumberOfLabels;
                    btMediaHandling.NumberOfLabels = (int)cutNum.Value;
                }
            }
            catch (COMException ext)
            {
                //COMExceptionの例外が発生した場合はバーテンダーをアプリケーションから
                //コントロールできない状態でプロセスが残るのでプロセスをkillして再度生成
                MessageBox.Show(ext.Message + "\n設定を見直してください。");

                using (System.Diagnostics.Process ps = System.Diagnostics.Process.GetProcessById(btAppPID))
                {
                    ps.Kill();
                    ps.WaitForExit();
                }

                btIntialize();
                return;
            }
            //SEAGULL SCIENTIFIC SAMPLE画面内のボタンを有効化
            ActualPrint.Enabled = true;
            ImagePreview.Enabled = true;
            BtPreviw.Enabled = true;

        }

        //------SEAGULL SCIENTIFIC SAMPLEの『印刷』ボタンが押下された時に実行されます-----
        private void ActualPrint_Click(object sender, EventArgs e)
        {
            //SEAGULL SCIENTIFIC SAMPLEの『設定完了』によりセットした値で印刷を実行
            btFormat.PrintOut(false, false);

            //プレビューをリセット
            imageViewReset();

            //ボタンの状態をリセット
            ActualPrint.Enabled = false;
            ImagePreview.Enabled = false;
            BtPreviw.Enabled = false;

            //フォーマットを保存せずに閉じる
            btFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges);
        }

        //SEAGULL SCIENTIFIC SAMPLEの『BTプレビュー』ボタンが押下された時に実行されます
        private void BtPreviw_Click(object sender, EventArgs e)
        {
            //----バーテンダーの印刷プレビューを表示 10.1から
            btFormat.PrintPreview.Show();
        }

        //------SEAGULL SCIENTIFIC SAMPLEの『画像プレビュー』ボタンが押下された時に実行されます-----
        private void ImagePreview_Click(object sender, EventArgs e)
        {
            if (tempImagePath == null)
            {
                ImagePreview.Enabled = false;

                //イメージデータをテンポラリフォルダーに作成
                string tempFilePath;
                tempFilePath = Path.GetTempFileName();
                tempImagePath = Path.ChangeExtension(tempFilePath, ".png");
                File.Move(tempFilePath, tempImagePath);

                //Automation 機能の画像エクスポート　バーテンダーでの表示状態をそのまま印刷
                //バーテンダーオブジェクトの設定にて印刷しないとしたオブジェクトも印刷される

                //tempImagePath に直接Path を入力した場合は上記のイメージデータをテンポラリフォルダに作成 の処理は不要です。
                btFormat.ExportToFile(tempImagePath, "PNG", BarTender.BtColors.btColors24Bit, BarTender.BtResolution.btResolutionPrinter, BarTender.BtSaveOptions.btSaveChanges);
                //画像ファイルをプレビュー表示画面にセット
                PictureBox1.ImageLocation = tempImagePath;


                //Enterprise Automation版の場合、印刷プレビューの結果を、選択したbtwファイルが存在するディレクトリにPreviewImageフォルダを作成して画像ファイルとしてエクスポートします。
                if (Regex.IsMatch(btApp.Edition, @"^E"))                  //エディションがEから始まる場合Enterprise Automationと判断
                {
                    BarTender.Messages msgs;
                    BarTender.BtPrintResult res;

                    string imageSavePath;
                    imageSavePath = Path.GetDirectoryName(btwFilePath.Text) + "\\PreviewImage";

                    if (!Directory.Exists(imageSavePath))
                        Directory.CreateDirectory(imageSavePath);

                    //印刷プレビューの結果を画像ファイルとしてエクスポート
                    res = btFormat.ExportPrintPreviewToImage(imageSavePath, "Label_%PageNumber%_Preview.png", "png", BarTender.BtColors.btColors24Bit, 200, 13117215, BarTender.BtSaveOptions.btSaveChanges, true, true, out msgs);
                }
            }
        }

        //------フォームを閉じた際に実行されます------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Image Boxを初期化
            imageViewReset();

            //バーテンダーのインスタンスを終了
            btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(btApp);

        }
 
        //----SEAGULL SCIENTIFIC SAMPLEのSegull Driver チェックボックスの値が変更された時に実行されます------
        private void CkSeagull_CheckedChanged(object sender, EventArgs e)
        {
            if (CkSeagull.CheckState == CheckState.Checked)
                cutNum.Enabled = true;
            else
                cutNum.Enabled = false;
        }
        //----BTWのパスが設定されていないときは、設定ボタンを押下できないよう制御------
        private void btwFilePath_TextChanged(object sender, EventArgs e)
        {
            if (btwFilePath.Text != "")
                SetValue.Enabled = true;
            else
                SetValue.Enabled = false;
        }
        //----SEAGULL SCIENTIFIC SAMPLEの『BTW』ボタンが押下された時に実行されます----
        private void SelectBTW_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //ファイル選択のダイアログボックスを表示します
            //アプリケーションが設置されたディレクトリにBTWフォルダーがあれば、そこを第一候補として表示します
            ofd.InitialDirectory = basePath + "\\BTW";
            ofd.Filter = "BarTender ドキュメント(*.btw)|*.btw";
            //ファイル名が取得できた場合テキストボックスにファイル名を表示します
            if (ofd.ShowDialog() == DialogResult.OK)
                btwFilePath.Text = ofd.FileName;
        }

        //----SEAGULL SCIENTIFIC SAMPLEの『CSV』ボタンが押下された時に実行されます----
        private void SelectCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //ファイル選択のダイアログボックスを表示します
            //アプリケーションが設置されたディレクトリにPrintCSVフォルダーがあれば、そこを第一候補として表示します
            ofd.InitialDirectory = basePath + "\\PrintCSV";
            //ファイル名が取得できた場合テキストボックスにファイル名を表示します
            if (ofd.ShowDialog() == DialogResult.OK)
                databaseFilePath.Text = ofd.FileName;
        }

        //----プレビュー表示をリセットします----
        private void imageViewReset()
        {
            if (tempImagePath != null)
            {
                if (PictureBox1.Image != null)
                {
                    PictureBox1.Image.Dispose();
                    PictureBox1.Image = null;
                }
                File.Delete(tempImagePath);
                tempImagePath = null;
            }
        }



        
    }
}

