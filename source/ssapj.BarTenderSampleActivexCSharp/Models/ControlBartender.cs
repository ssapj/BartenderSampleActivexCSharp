using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using BarTender;

namespace ssapj.BarTenderSampleActivexCSharp.Models
{
    //このサンプルではエラーハンドリングを行いません。
    //btwファイルが想定した状況にないときはCOMExceptionが飛びます
    internal class ControlBartender : IDisposable
    {
        private Application _bartenderApplication;
        private int _processIdOfBartenderApplication;
        private Format _bartenderFormat;
        private string _bartenderFormatFilePath;

        //ダイアログは表示するようにBarTenderを起動
        public ControlBartender()
        {
            this._bartenderApplication = new Application { VisibleWindows = BtVisibleWindows.btInteractiveDialogs };
            this._processIdOfBartenderApplication = this._bartenderApplication.ProcessId;
        }

        //BarTenderでbtwファイルを開く
        public void OpenFormat(string filepath, string printerName)
        {
            this._bartenderFormatFilePath = filepath;
            this._bartenderFormat = this._bartenderApplication.Formats.Open(this._bartenderFormatFilePath, false, printerName);
        }

        //1つめのデータベース接続のファイルパスを変更
        public void SetDatabase(string databaseFilePath)
        {
            var bartenderDatabase = this._bartenderFormat.Databases.GetDatabase(1);
            bartenderDatabase.TextFile.FileName = databaseFilePath;
        }

        //名前付きデータソースの値を変更 
        public void SetNamedSubStringValue(string nameOfNamedSubString, string value)
        {
            this._bartenderFormat.SetNamedSubStringValue(nameOfNamedSubString, value);
        }

        //btwファイル内のオブジェクト(テキスト・バーコード・画像)のプロパティを変更
        //TextColor : フォントの色
        //FontBold : フォントを太字にするかどうか
        public void ControlTargetDesignObeject(string nameOfDesignObject, bool isChangedToRed)
        {
            var targetDesignObject = this._bartenderFormat.Objects.Find(nameOfDesignObject);

            if (isChangedToRed)
            {
                targetDesignObject.TextColor = 0xFFFF0000;
                targetDesignObject.FontBold = true;
            }
            else
            {
                targetDesignObject.TextColor = 0xFF000000;
                targetDesignObject.FontBold = false;
            }
        }

        //印刷枚数を設定
        //NumberSerializedLabels : 連番発行数
        //IdenticalCopiesOfLabel : コピー数
        public void SetPrintNumbers(int numberSerializedLabels, int identicalCopiesOfLabel)
        {
            this._bartenderFormat.NumberSerializedLabels = numberSerializedLabels;
            this._bartenderFormat.IdenticalCopiesOfLabel = identicalCopiesOfLabel;
        }

        //指定間隔ごとにカット
        //MediaHandlingの各プロパティで用紙の処理の設定が可能
        public void SetCutInterval(bool isCut, int cutInterval)
        {
            if (!isCut) return;

            var mediaHandling = this._bartenderFormat.PageSetup.MediaHandling;
            mediaHandling.Action = BtMediaHandlingAction.btMHCut;
            mediaHandling.Occurrence = BtMediaHandlingOccurrence.btMHAfterNumberOfLabels;
            mediaHandling.NumberOfLabels = cutInterval;
        }

        //印刷とbtwファイルのクローズ
        public void PrintAndCloseFormat()
        {
            this._bartenderFormat.PrintOut();
            this._bartenderFormat.Close(BtSaveOptions.btDoNotSaveChanges);
            Marshal.ReleaseComObject(this._bartenderFormat);
        }

        //BarTenderの印刷プレビューを表示
        //VisibleWindowsに注意
        public void ShowPreview()
        {
            this._bartenderFormat.PrintPreview.Show();
        }

        //現状のテンプレートのキャプチャーをエクスポート
        //キャプチャーのエクスポートなので印刷条件の設定等は反映されないことに注意
        public string CreateCaptureImage()
        {
            var tempFilePath = Path.GetTempFileName();
            var tempImageFilePath = Path.ChangeExtension(tempFilePath, ".png");
            File.Move(tempFilePath, tempImageFilePath);

            this._bartenderFormat.ExportToFile(tempImageFilePath, "PNG", BtColors.btColors24Bit, BtResolution.btResolutionPrinter, BtSaveOptions.btSaveChanges);

            return tempImageFilePath;
        }

        //Enterprise Automation版のみ利用可能
        //印刷プレビューのエクスポート
        public void ExportPrintPreviewToImage()
        {

            Messages messagesFromBartender;

            var imageSavePath = Path.Combine(Path.GetDirectoryName(this._bartenderFormatFilePath), "PreviewImage");

            if (!Directory.Exists(imageSavePath))
            {
                Directory.CreateDirectory(imageSavePath);
            }

            this._bartenderFormat.ExportPrintPreviewToImage(imageSavePath, "Label_%PageNumber%_Preview.png", "png", BtColors.btColors24Bit, 200, 13117215, BtSaveOptions.btSaveChanges, true, true, out messagesFromBartender);
        }


        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposedValue) return;
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.
            if (this._bartenderApplication != null)
            {
                try
                {
                    using (Process.GetProcessById(this._processIdOfBartenderApplication))
                    {
                        this._bartenderApplication.Quit(BtSaveOptions.btDoNotSaveChanges);
                    }
                }
                finally
                {
                    Marshal.FinalReleaseComObject(this._bartenderApplication);
                    this._bartenderApplication = null;
                }
            }

            this.disposedValue = true;
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~ControlBartender()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            this.Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            this.Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
