namespace ImacryptExample
{
    partial class Main
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
            this.PlainTextTxt = new System.Windows.Forms.RichTextBox();
            this.EncryptedImageBx = new System.Windows.Forms.PictureBox();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DecryptedTextTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.ImageDlg = new System.Windows.Forms.OpenFileDialog();
            this.ClearDecryptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedImageBx)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlainTextTxt
            // 
            this.PlainTextTxt.Location = new System.Drawing.Point(8, 20);
            this.PlainTextTxt.Name = "PlainTextTxt";
            this.PlainTextTxt.Size = new System.Drawing.Size(420, 189);
            this.PlainTextTxt.TabIndex = 0;
            this.PlainTextTxt.Text = "";
            this.PlainTextTxt.TextChanged += new System.EventHandler(this.PlainTextTxt_TextChanged);
            // 
            // EncryptedImageBx
            // 
            this.EncryptedImageBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EncryptedImageBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptedImageBx.Location = new System.Drawing.Point(434, 20);
            this.EncryptedImageBx.Name = "EncryptedImageBx";
            this.EncryptedImageBx.Size = new System.Drawing.Size(160, 160);
            this.EncryptedImageBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EncryptedImageBx.TabIndex = 1;
            this.EncryptedImageBx.TabStop = false;
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Enabled = false;
            this.SaveImageBtn.Location = new System.Drawing.Point(519, 186);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveImageBtn.TabIndex = 2;
            this.SaveImageBtn.Text = "Save Image";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Enabled = false;
            this.ClearBtn.Location = new System.Drawing.Point(434, 186);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear All";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter plain text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypted to image:";
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage2);
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(608, 241);
            this.TabMenu.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PlainTextTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.EncryptedImageBx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SaveImageBtn);
            this.tabPage1.Controls.Add(this.ClearBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClearDecryptBtn);
            this.tabPage2.Controls.Add(this.SelectImageBtn);
            this.tabPage2.Controls.Add(this.DecryptedTextTxt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DecryptedTextTxt
            // 
            this.DecryptedTextTxt.Location = new System.Drawing.Point(8, 20);
            this.DecryptedTextTxt.Name = "DecryptedTextTxt";
            this.DecryptedTextTxt.ReadOnly = true;
            this.DecryptedTextTxt.Size = new System.Drawing.Size(586, 148);
            this.DecryptedTextTxt.TabIndex = 5;
            this.DecryptedTextTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrypted plain text:";
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.Location = new System.Drawing.Point(465, 174);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(129, 23);
            this.SelectImageBtn.TabIndex = 7;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.UseVisualStyleBackColor = true;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // ImageDlg
            // 
            this.ImageDlg.Title = "Choose Imacrypt image..";
            // 
            // ClearDecryptBtn
            // 
            this.ClearDecryptBtn.Location = new System.Drawing.Point(330, 174);
            this.ClearDecryptBtn.Name = "ClearDecryptBtn";
            this.ClearDecryptBtn.Size = new System.Drawing.Size(129, 23);
            this.ClearDecryptBtn.TabIndex = 8;
            this.ClearDecryptBtn.Text = "Clear Text";
            this.ClearDecryptBtn.UseVisualStyleBackColor = true;
            this.ClearDecryptBtn.Click += new System.EventHandler(this.ClearDecryptBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 238);
            this.Controls.Add(this.TabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Imacrypt Example";
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedImageBx)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox PlainTextTxt;
        private System.Windows.Forms.PictureBox EncryptedImageBx;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox DecryptedTextTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectImageBtn;
        private System.Windows.Forms.OpenFileDialog ImageDlg;
        private System.Windows.Forms.Button ClearDecryptBtn;
    }
}

