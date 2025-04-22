namespace PDFCompressor
{
    partial class btn_Clear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SelectFiles = new System.Windows.Forms.Button();
            this.listBox_PDFs = new System.Windows.Forms.ListBox();
            this.btn_OutputFolder = new System.Windows.Forms.Button();
            this.lbl_OutputPath = new System.Windows.Forms.Label();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbCompressionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SelectFiles
            // 
            this.btn_SelectFiles.Location = new System.Drawing.Point(37, 34);
            this.btn_SelectFiles.Name = "btn_SelectFiles";
            this.btn_SelectFiles.Size = new System.Drawing.Size(203, 69);
            this.btn_SelectFiles.TabIndex = 0;
            this.btn_SelectFiles.Text = "Select PDFS";
            this.btn_SelectFiles.UseVisualStyleBackColor = true;
            this.btn_SelectFiles.Click += new System.EventHandler(this.btn_SelectFiles_Click);
            // 
            // listBox_PDFs
            // 
            this.listBox_PDFs.FormattingEnabled = true;
            this.listBox_PDFs.Location = new System.Drawing.Point(37, 127);
            this.listBox_PDFs.Name = "listBox_PDFs";
            this.listBox_PDFs.Size = new System.Drawing.Size(831, 264);
            this.listBox_PDFs.TabIndex = 2;
            // 
            // btn_OutputFolder
            // 
            this.btn_OutputFolder.Location = new System.Drawing.Point(262, 34);
            this.btn_OutputFolder.Name = "btn_OutputFolder";
            this.btn_OutputFolder.Size = new System.Drawing.Size(203, 69);
            this.btn_OutputFolder.TabIndex = 3;
            this.btn_OutputFolder.Text = "Set Output Folder";
            this.btn_OutputFolder.UseVisualStyleBackColor = true;
            this.btn_OutputFolder.Click += new System.EventHandler(this.btn_OutputFolder_Click);
            // 
            // lbl_OutputPath
            // 
            this.lbl_OutputPath.AutoSize = true;
            this.lbl_OutputPath.Location = new System.Drawing.Point(487, 62);
            this.lbl_OutputPath.Name = "lbl_OutputPath";
            this.lbl_OutputPath.Size = new System.Drawing.Size(96, 13);
            this.lbl_OutputPath.TabIndex = 4;
            this.lbl_OutputPath.Text = "Output Folder Path";
            // 
            // btn_Compress
            // 
            this.btn_Compress.Location = new System.Drawing.Point(37, 459);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(203, 69);
            this.btn_Compress.TabIndex = 5;
            this.btn_Compress.Text = "Compress PDF";
            this.btn_Compress.UseVisualStyleBackColor = true;
            this.btn_Compress.Click += new System.EventHandler(this.btn_Compress_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 482);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(606, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // cmbCompressionType
            // 
            this.cmbCompressionType.FormattingEnabled = true;
            this.cmbCompressionType.Location = new System.Drawing.Point(262, 417);
            this.cmbCompressionType.Name = "cmbCompressionType";
            this.cmbCompressionType.Size = new System.Drawing.Size(220, 21);
            this.cmbCompressionType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Qulity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Clear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCompressionType);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Compress);
            this.Controls.Add(this.lbl_OutputPath);
            this.Controls.Add(this.btn_OutputFolder);
            this.Controls.Add(this.listBox_PDFs);
            this.Controls.Add(this.btn_SelectFiles);
            this.Name = "btn_Clear";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFiles;
        private System.Windows.Forms.ListBox listBox_PDFs;
        private System.Windows.Forms.Button btn_OutputFolder;
        private System.Windows.Forms.Label lbl_OutputPath;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbCompressionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

