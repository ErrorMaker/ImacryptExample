using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imacrypt;
using System.IO;
using ImacryptExample.Properties;

namespace ImacryptExample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PlainTextTxt_TextChanged(object sender, EventArgs e)
        {
            if (PlainTextTxt.TextLength < 1) EncryptedImageBx.Image = null;
            else EncryptedImageBx.Image = PlainTextTxt.Text.BmpEncrypt();
            SaveImageBtn.Enabled = EncryptedImageBx.Image != null;
            ClearBtn.Enabled = PlainTextTxt.TextLength > 0;
        }

        private void ClearBtn_Click(object sender, EventArgs e) => PlainTextTxt.Clear();

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Images")) Directory.CreateDirectory("Images");
            EncryptedImageBx.Image.Save($"Images/Imacrypt-{Settings.Default.ImageCount}.bmp");
            Settings.Default.ImageCount++;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = ImageDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Bitmap image = (Bitmap)Bitmap.FromFile(ImageDlg.FileName);
                    DecryptedTextTxt.Text = image.BmpDecrypt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Oops! That's an error. Here's the error message:\n\n{ex.Message}", "Oh no! :-(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearDecryptBtn_Click(object sender, EventArgs e) => DecryptedTextTxt.Clear();
    }
}
