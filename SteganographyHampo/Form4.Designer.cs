namespace SteganographyHampo
{
    partial class Form4
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
            this.btnEn = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(111, 154);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 0;
            this.btnEn.Text = "Encrypt";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(111, 276);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Decrypt";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(57, 12);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(187, 50);
            this.txtIn.TabIndex = 2;
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(57, 71);
            this.txtEn.Multiline = true;
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(187, 77);
            this.txtEn.TabIndex = 3;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(57, 186);
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(187, 84);
            this.txtDe.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.btnEn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtDe;
    }
}