namespace SteganographyHampo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gbxIn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInKey = new System.Windows.Forms.TextBox();
            this.btnHideMessage = new System.Windows.Forms.Button();
            this.txtInEncrypt = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnEncryptMessage = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtInMessage = new System.Windows.Forms.TextBox();
            this.pbxIn = new System.Windows.Forms.PictureBox();
            this.gbxOut = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExtractMessage = new System.Windows.Forms.Button();
            this.txtOutKey = new System.Windows.Forms.TextBox();
            this.txtOutEncrypt = new System.Windows.Forms.TextBox();
            this.btnDecryptMessage = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtOutMessage = new System.Windows.Forms.TextBox();
            this.pbxOutIn = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxOut = new System.Windows.Forms.PictureBox();
            this.btnSaveStegImage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hideOpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractOpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIn)).BeginInit();
            this.gbxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIn
            // 
            this.gbxIn.Controls.Add(this.label1);
            this.gbxIn.Controls.Add(this.txtInKey);
            this.gbxIn.Controls.Add(this.btnHideMessage);
            this.gbxIn.Controls.Add(this.txtInEncrypt);
            this.gbxIn.Controls.Add(this.btnClearAll);
            this.gbxIn.Controls.Add(this.btnEncryptMessage);
            this.gbxIn.Controls.Add(this.btnUpload);
            this.gbxIn.Controls.Add(this.txtInMessage);
            this.gbxIn.Controls.Add(this.pbxIn);
            this.gbxIn.Enabled = false;
            this.gbxIn.Font = new System.Drawing.Font("MicroTiempo-Normal bold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxIn.Location = new System.Drawing.Point(12, 27);
            this.gbxIn.Name = "gbxIn";
            this.gbxIn.Size = new System.Drawing.Size(558, 188);
            this.gbxIn.TabIndex = 0;
            this.gbxIn.TabStop = false;
            this.gbxIn.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 11);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key";
            this.label1.Visible = false;
            // 
            // txtInKey
            // 
            this.txtInKey.Location = new System.Drawing.Point(222, 17);
            this.txtInKey.Name = "txtInKey";
            this.txtInKey.Size = new System.Drawing.Size(125, 19);
            this.txtInKey.TabIndex = 7;
            this.txtInKey.Visible = false;
            // 
            // btnHideMessage
            // 
            this.btnHideMessage.Enabled = false;
            this.btnHideMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideMessage.Location = new System.Drawing.Point(373, 144);
            this.btnHideMessage.Name = "btnHideMessage";
            this.btnHideMessage.Size = new System.Drawing.Size(75, 35);
            this.btnHideMessage.TabIndex = 6;
            this.btnHideMessage.Text = "Hide Message";
            this.btnHideMessage.UseVisualStyleBackColor = true;
            this.btnHideMessage.Click += new System.EventHandler(this.btnHideMessage_Click);
            // 
            // txtInEncrypt
            // 
            this.txtInEncrypt.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInEncrypt.Location = new System.Drawing.Point(363, 19);
            this.txtInEncrypt.Multiline = true;
            this.txtInEncrypt.Name = "txtInEncrypt";
            this.txtInEncrypt.ReadOnly = true;
            this.txtInEncrypt.Size = new System.Drawing.Size(178, 112);
            this.txtInEncrypt.TabIndex = 5;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(466, 144);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 35);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnEncryptMessage
            // 
            this.btnEncryptMessage.Enabled = false;
            this.btnEncryptMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptMessage.Location = new System.Drawing.Point(196, 137);
            this.btnEncryptMessage.Name = "btnEncryptMessage";
            this.btnEncryptMessage.Size = new System.Drawing.Size(75, 37);
            this.btnEncryptMessage.TabIndex = 3;
            this.btnEncryptMessage.Text = "Encrypt Message";
            this.btnEncryptMessage.UseVisualStyleBackColor = true;
            this.btnEncryptMessage.Click += new System.EventHandler(this.btnEncryptMessage_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(6, 137);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 37);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtInMessage
            // 
            this.txtInMessage.Enabled = false;
            this.txtInMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInMessage.Location = new System.Drawing.Point(169, 42);
            this.txtInMessage.Multiline = true;
            this.txtInMessage.Name = "txtInMessage";
            this.txtInMessage.Size = new System.Drawing.Size(178, 89);
            this.txtInMessage.TabIndex = 1;
            // 
            // pbxIn
            // 
            this.pbxIn.Location = new System.Drawing.Point(6, 19);
            this.pbxIn.Name = "pbxIn";
            this.pbxIn.Size = new System.Drawing.Size(136, 112);
            this.pbxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIn.TabIndex = 0;
            this.pbxIn.TabStop = false;
            // 
            // gbxOut
            // 
            this.gbxOut.Controls.Add(this.label2);
            this.gbxOut.Controls.Add(this.btnExtractMessage);
            this.gbxOut.Controls.Add(this.txtOutKey);
            this.gbxOut.Controls.Add(this.txtOutEncrypt);
            this.gbxOut.Controls.Add(this.btnDecryptMessage);
            this.gbxOut.Controls.Add(this.btnUploadImage);
            this.gbxOut.Controls.Add(this.txtOutMessage);
            this.gbxOut.Controls.Add(this.pbxOutIn);
            this.gbxOut.Enabled = false;
            this.gbxOut.Font = new System.Drawing.Font("MicroTiempo-Normal bold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOut.Location = new System.Drawing.Point(12, 334);
            this.gbxOut.Name = "gbxOut";
            this.gbxOut.Size = new System.Drawing.Size(558, 203);
            this.gbxOut.TabIndex = 7;
            this.gbxOut.TabStop = false;
            this.gbxOut.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 11);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key";
            this.label2.Visible = false;
            // 
            // btnExtractMessage
            // 
            this.btnExtractMessage.Enabled = false;
            this.btnExtractMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractMessage.Location = new System.Drawing.Point(148, 56);
            this.btnExtractMessage.Name = "btnExtractMessage";
            this.btnExtractMessage.Size = new System.Drawing.Size(75, 35);
            this.btnExtractMessage.TabIndex = 6;
            this.btnExtractMessage.Text = "Extract Message";
            this.btnExtractMessage.UseVisualStyleBackColor = true;
            this.btnExtractMessage.Click += new System.EventHandler(this.btnExtractMessage_Click);
            // 
            // txtOutKey
            // 
            this.txtOutKey.Location = new System.Drawing.Point(295, 20);
            this.txtOutKey.Name = "txtOutKey";
            this.txtOutKey.Size = new System.Drawing.Size(89, 19);
            this.txtOutKey.TabIndex = 9;
            this.txtOutKey.Visible = false;
            // 
            // txtOutEncrypt
            // 
            this.txtOutEncrypt.Enabled = false;
            this.txtOutEncrypt.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutEncrypt.Location = new System.Drawing.Point(245, 45);
            this.txtOutEncrypt.Multiline = true;
            this.txtOutEncrypt.Name = "txtOutEncrypt";
            this.txtOutEncrypt.Size = new System.Drawing.Size(139, 86);
            this.txtOutEncrypt.TabIndex = 5;
            // 
            // btnDecryptMessage
            // 
            this.btnDecryptMessage.Enabled = false;
            this.btnDecryptMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptMessage.Location = new System.Drawing.Point(272, 137);
            this.btnDecryptMessage.Name = "btnDecryptMessage";
            this.btnDecryptMessage.Size = new System.Drawing.Size(75, 36);
            this.btnDecryptMessage.TabIndex = 3;
            this.btnDecryptMessage.Text = "Decrypt Message";
            this.btnDecryptMessage.UseVisualStyleBackColor = true;
            this.btnDecryptMessage.Click += new System.EventHandler(this.btnDecryptMessage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(6, 137);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 36);
            this.btnUploadImage.TabIndex = 2;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtOutMessage
            // 
            this.txtOutMessage.Enabled = false;
            this.txtOutMessage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutMessage.Location = new System.Drawing.Point(402, 19);
            this.txtOutMessage.Multiline = true;
            this.txtOutMessage.Name = "txtOutMessage";
            this.txtOutMessage.Size = new System.Drawing.Size(139, 112);
            this.txtOutMessage.TabIndex = 1;
            // 
            // pbxOutIn
            // 
            this.pbxOutIn.Location = new System.Drawing.Point(6, 19);
            this.pbxOutIn.Name = "pbxOutIn";
            this.pbxOutIn.Size = new System.Drawing.Size(136, 112);
            this.pbxOutIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOutIn.TabIndex = 0;
            this.pbxOutIn.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(461, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxOut
            // 
            this.pbxOut.Enabled = false;
            this.pbxOut.Location = new System.Drawing.Point(198, 220);
            this.pbxOut.Name = "pbxOut";
            this.pbxOut.Size = new System.Drawing.Size(136, 112);
            this.pbxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOut.TabIndex = 7;
            this.pbxOut.TabStop = false;
            // 
            // btnSaveStegImage
            // 
            this.btnSaveStegImage.Enabled = false;
            this.btnSaveStegImage.Font = new System.Drawing.Font("MicroTiempo-Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStegImage.Location = new System.Drawing.Point(357, 254);
            this.btnSaveStegImage.Name = "btnSaveStegImage";
            this.btnSaveStegImage.Size = new System.Drawing.Size(75, 42);
            this.btnSaveStegImage.TabIndex = 8;
            this.btnSaveStegImage.Text = "Save Steg Image";
            this.btnSaveStegImage.UseVisualStyleBackColor = true;
            this.btnSaveStegImage.Click += new System.EventHandler(this.btnSaveStegImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("SerpentineDBol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideOpToolStripMenuItem,
            this.extractOpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hideOpToolStripMenuItem
            // 
            this.hideOpToolStripMenuItem.Name = "hideOpToolStripMenuItem";
            this.hideOpToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hideOpToolStripMenuItem.Text = "Hide Op";
            this.hideOpToolStripMenuItem.Click += new System.EventHandler(this.hideOpToolStripMenuItem_Click);
            // 
            // extractOpToolStripMenuItem
            // 
            this.extractOpToolStripMenuItem.Name = "extractOpToolStripMenuItem";
            this.extractOpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.extractOpToolStripMenuItem.Text = "Extract Op";
            this.extractOpToolStripMenuItem.Click += new System.EventHandler(this.extractOpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 549);
            this.Controls.Add(this.btnSaveStegImage);
            this.Controls.Add(this.pbxOut);
            this.Controls.Add(this.gbxOut);
            this.Controls.Add(this.gbxIn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Comprehensive Message Security System || Hampo_Odii";
            this.gbxIn.ResumeLayout(false);
            this.gbxIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIn)).EndInit();
            this.gbxOut.ResumeLayout(false);
            this.gbxOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIn;
        private System.Windows.Forms.Button btnHideMessage;
        private System.Windows.Forms.TextBox txtInEncrypt;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnEncryptMessage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtInMessage;
        private System.Windows.Forms.PictureBox pbxIn;
        private System.Windows.Forms.GroupBox gbxOut;
        private System.Windows.Forms.Button btnExtractMessage;
        private System.Windows.Forms.TextBox txtOutEncrypt;
        private System.Windows.Forms.Button btnDecryptMessage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtOutMessage;
        private System.Windows.Forms.PictureBox pbxOutIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxOut;
        private System.Windows.Forms.Button btnSaveStegImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hideOpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractOpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutKey;
    }
}