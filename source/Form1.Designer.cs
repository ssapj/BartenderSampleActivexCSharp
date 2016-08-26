namespace ssapj.BarTenderSampleActivexCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CkSeagull = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.CkEmphasis = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SetValue = new System.Windows.Forms.Button();
            this.ImagePreview = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrinterList = new System.Windows.Forms.ComboBox();
            this.SelectCSV = new System.Windows.Forms.Button();
            this.databaseFilePath = new System.Windows.Forms.TextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtPreviw = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ActualPrint = new System.Windows.Forms.Button();
            this.SelectBTW = new System.Windows.Forms.Button();
            this.btwFilePath = new System.Windows.Forms.TextBox();
            this.NSL = new System.Windows.Forms.NumericUpDown();
            this.ICOL = new System.Windows.Forms.NumericUpDown();
            this.cutNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutNum)).BeginInit();
            this.SuspendLayout();
            // 
            // CkSeagull
            // 
            this.CkSeagull.AutoSize = true;
            this.CkSeagull.Location = new System.Drawing.Point(245, 205);
            this.CkSeagull.Name = "CkSeagull";
            this.CkSeagull.Size = new System.Drawing.Size(96, 16);
            this.CkSeagull.TabIndex = 39;
            this.CkSeagull.Text = "Seagull Driver";
            this.CkSeagull.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label6.Location = new System.Drawing.Point(5, 92);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(122, 21);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "注意（強調）";
            // 
            // CkEmphasis
            // 
            this.CkEmphasis.Location = new System.Drawing.Point(130, 92);
            this.CkEmphasis.Name = "CkEmphasis";
            this.CkEmphasis.Size = new System.Drawing.Size(20, 18);
            this.CkEmphasis.TabIndex = 42;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label5.Location = new System.Drawing.Point(5, 203);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(99, 21);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "カット枚数";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label4.Location = new System.Drawing.Point(5, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(105, 21);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "コピー枚数";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new System.Drawing.Point(5, 148);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 21);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "連番枚数";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new System.Drawing.Point(5, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 21);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "備考";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(5, 120);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 21);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "プリンタ";
            // 
            // SetValue
            // 
            this.SetValue.Enabled = false;
            this.SetValue.Location = new System.Drawing.Point(5, 231);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(75, 23);
            this.SetValue.TabIndex = 27;
            this.SetValue.Text = "設定完了";
            this.SetValue.UseVisualStyleBackColor = true;
            this.SetValue.Click += new System.EventHandler(this.SetValue_Click);
            // 
            // ImagePreview
            // 
            this.ImagePreview.Enabled = false;
            this.ImagePreview.Location = new System.Drawing.Point(5, 563);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(86, 23);
            this.ImagePreview.TabIndex = 26;
            this.ImagePreview.Text = "画像プレビュー";
            this.ImagePreview.UseVisualStyleBackColor = true;
            this.ImagePreview.Click += new System.EventHandler(this.ImagePreview_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(5, 294);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(280, 258);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 25;
            this.PictureBox1.TabStop = false;
            // 
            // PrinterList
            // 
            this.PrinterList.FormattingEnabled = true;
            this.PrinterList.Location = new System.Drawing.Point(120, 120);
            this.PrinterList.Name = "PrinterList";
            this.PrinterList.Size = new System.Drawing.Size(175, 20);
            this.PrinterList.TabIndex = 24;
            // 
            // SelectCSV
            // 
            this.SelectCSV.Location = new System.Drawing.Point(248, 35);
            this.SelectCSV.Name = "SelectCSV";
            this.SelectCSV.Size = new System.Drawing.Size(56, 23);
            this.SelectCSV.TabIndex = 23;
            this.SelectCSV.Text = "CSV";
            this.SelectCSV.UseVisualStyleBackColor = true;
            this.SelectCSV.Click += new System.EventHandler(this.SelectCSV_Click);
            // 
            // databaseFilePath
            // 
            this.databaseFilePath.Location = new System.Drawing.Point(5, 37);
            this.databaseFilePath.Name = "databaseFilePath";
            this.databaseFilePath.Size = new System.Drawing.Size(222, 19);
            this.databaseFilePath.TabIndex = 22;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // BtPreviw
            // 
            this.BtPreviw.Enabled = false;
            this.BtPreviw.Location = new System.Drawing.Point(100, 563);
            this.BtPreviw.Name = "BtPreviw";
            this.BtPreviw.Size = new System.Drawing.Size(75, 23);
            this.BtPreviw.TabIndex = 28;
            this.BtPreviw.Text = "BTプレビュー";
            this.BtPreviw.UseVisualStyleBackColor = true;
            this.BtPreviw.Click += new System.EventHandler(this.BtPreviw_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(120, 65);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(175, 19);
            this.TextBox1.TabIndex = 21;
            // 
            // ActualPrint
            // 
            this.ActualPrint.Enabled = false;
            this.ActualPrint.Location = new System.Drawing.Point(100, 231);
            this.ActualPrint.Name = "ActualPrint";
            this.ActualPrint.Size = new System.Drawing.Size(75, 23);
            this.ActualPrint.TabIndex = 20;
            this.ActualPrint.Text = "印刷";
            this.ActualPrint.UseVisualStyleBackColor = true;
            this.ActualPrint.Click += new System.EventHandler(this.ActualPrint_Click);
            // 
            // SelectBTW
            // 
            this.SelectBTW.Location = new System.Drawing.Point(248, 7);
            this.SelectBTW.Name = "SelectBTW";
            this.SelectBTW.Size = new System.Drawing.Size(56, 23);
            this.SelectBTW.TabIndex = 41;
            this.SelectBTW.Text = "BTW";
            this.SelectBTW.UseVisualStyleBackColor = true;
            this.SelectBTW.Click += new System.EventHandler(this.SelectBTW_Click);
            // 
            // btwFilePath
            // 
            this.btwFilePath.Location = new System.Drawing.Point(5, 9);
            this.btwFilePath.Name = "btwFilePath";
            this.btwFilePath.Size = new System.Drawing.Size(222, 19);
            this.btwFilePath.TabIndex = 40;
            this.btwFilePath.TextChanged += new System.EventHandler(this.btwFilePath_TextChanged);
            // 
            // NSL
            // 
            this.NSL.Location = new System.Drawing.Point(120, 148);
            this.NSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NSL.Name = "NSL";
            this.NSL.Size = new System.Drawing.Size(120, 19);
            this.NSL.TabIndex = 43;
            this.NSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ICOL
            // 
            this.ICOL.Location = new System.Drawing.Point(120, 175);
            this.ICOL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ICOL.Name = "ICOL";
            this.ICOL.Size = new System.Drawing.Size(120, 19);
            this.ICOL.TabIndex = 44;
            this.ICOL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cutNum
            // 
            this.cutNum.Enabled = false;
            this.cutNum.Location = new System.Drawing.Point(120, 203);
            this.cutNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cutNum.Name = "cutNum";
            this.cutNum.Size = new System.Drawing.Size(74, 19);
            this.cutNum.TabIndex = 45;
            this.cutNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 610);
            this.Controls.Add(this.cutNum);
            this.Controls.Add(this.ICOL);
            this.Controls.Add(this.NSL);
            this.Controls.Add(this.SelectBTW);
            this.Controls.Add(this.btwFilePath);
            this.Controls.Add(this.CkSeagull);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.CkEmphasis);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SetValue);
            this.Controls.Add(this.ImagePreview);
            this.Controls.Add(this.PrinterList);
            this.Controls.Add(this.SelectCSV);
            this.Controls.Add(this.databaseFilePath);
            this.Controls.Add(this.BtPreviw);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ActualPrint);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "SEAGULL SCIENTIFIC  SAMPLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        internal System.Windows.Forms.CheckBox CkSeagull;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckBox CkEmphasis;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button SetValue;
        internal System.Windows.Forms.Button ImagePreview;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ComboBox PrinterList;
        internal System.Windows.Forms.Button SelectCSV;
        internal System.Windows.Forms.TextBox databaseFilePath;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Button BtPreviw;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button ActualPrint;
        internal System.Windows.Forms.Button SelectBTW;
        internal System.Windows.Forms.TextBox btwFilePath;
        private System.Windows.Forms.NumericUpDown NSL;
        private System.Windows.Forms.NumericUpDown ICOL;
        private System.Windows.Forms.NumericUpDown cutNum;
    }
}

