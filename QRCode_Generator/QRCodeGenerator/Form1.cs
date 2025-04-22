using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QRCodeGenerator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            toolTip.SetToolTip(pictureBox1, "This Program was built by Ravindu Theja Rupasinghe.");

        }


       
        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
                {
                    QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCoder.QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(10);
                        pbQRCode.Image = qrCodeImage; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR Code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (pbQRCode.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pbQRCode.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("QR Code saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Generate a QR Code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbQRCode.Image = null;
            this.txtUrl.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program was built by Ravindu Theja Rupasinghe.\nAll Rights Reserved.\nVersion 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

