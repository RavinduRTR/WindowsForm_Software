using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace PDFCompressor
{
    public partial class btn_Clear: Form
    {

        private string[] selectedFiles;
        private string outputFolder;


        public btn_Clear()
        {
            InitializeComponent();
        }

        private void btn_SelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "PDF files (*.pdf)|*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFiles = ofd.FileNames;
                    listBox_PDFs.Items.Clear();
                    listBox_PDFs.Items.AddRange(selectedFiles);
                }
            }
        }

        private void btn_OutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = fbd.SelectedPath;
                    lbl_OutputPath.Text = outputFolder;
                }
            }
        }

        private void btn_Compress_Click(object sender, EventArgs e)
        {
            if (selectedFiles == null || selectedFiles.Length == 0)
            {
                MessageBox.Show("Please select PDF files.");
                return;
            }

            if (string.IsNullOrEmpty(outputFolder))
            {
                MessageBox.Show("Please select an output folder.");
                return;
            }

            progressBar1.Maximum = selectedFiles.Length;
            progressBar1.Value = 0;

            foreach (string file in selectedFiles)
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string outputPath = Path.Combine(outputFolder, fileName + "_compressed.pdf");
                    CompressPdfWithGhostscript(file, outputPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error compressing {Path.GetFileName(file)}: {ex.Message}");
                }

                progressBar1.Value += 1;
            }

            MessageBox.Show("Compression completed!");
        }

        //This method is commented out because it uses PdfSharp which does not support compression
        //private void CompressPdf(string sourceFile, string outputFile)
        //{
        //    try
        //    {
        //        // Open the file with Import mode
        //        using (PdfDocument inputDocument = PdfReader.Open(sourceFile, PdfDocumentOpenMode.Import))
        //        {
        //            using (PdfDocument outputDocument = new PdfDocument())
        //            {
        //                // Loop through pages and add them to a new document
        //                for (int i = 0; i < inputDocument.PageCount; i++)
        //                {
        //                    outputDocument.AddPage(inputDocument.Pages[i]);
        //                }

        //                // Optional: remove metadata to reduce size a bit
        //                outputDocument.Info.Author = string.Empty;
        //                outputDocument.Info.Title = string.Empty;
        //                outputDocument.Info.Subject = string.Empty;
        //                outputDocument.Info.Keywords = string.Empty;
        //                outputDocument.Info.Creator = string.Empty;
        //                //outputDocument.Info.Producer = string.Empty;

        //                // Save to output path
        //                outputDocument.Save(outputFile);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Compression failed: " + ex.Message);
        //    }

        //}


        private void CompressPdfWithGhostscript(string inputFile, string outputFile)
        {
            string GetPdfSettings()
            {
                switch (cmbCompressionType.SelectedItem.ToString())
                {
                    case "Low":
                        return "/screen";
                    case "Medium":
                        return "/ebook";
                    case "High":
                        return "/printer";
                    default:
                        return "/screen"; // fallback
                }
            }

            string pdfSetting = GetPdfSettings();

            string gsPath = @"C:\Program Files\gs\gs10.05.0\bin\gswin64c.exe";

            string args = $"-sDEVICE=pdfwrite -dCompatibilityLevel=1.4 " +
                          $"-dPDFSETTINGS={pdfSetting} " +
                          "-dNOPAUSE -dQUIET -dBATCH " +
                          $"-sOutputFile=\"{outputFile}\" \"{inputFile}\"";

            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = gsPath;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCompressionType.Items.Add("Low");
            cmbCompressionType.Items.Add("Medium");
            cmbCompressionType.Items.Add("High");
            cmbCompressionType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_PDFs.Items.Clear();
            lbl_OutputPath.Text = "Output Path";
            selectedFiles = null;
            outputFolder = null;
            progressBar1.Value = 0;
        }
    }
}
