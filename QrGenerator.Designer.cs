namespace QrCodeGenerator
{
    partial class frmQrCodeGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtQrText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(428, 317);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 31);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtQrText
            // 
            this.txtQrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQrText.Location = new System.Drawing.Point(116, 314);
            this.txtQrText.Name = "txtQrText";
            this.txtQrText.Size = new System.Drawing.Size(281, 29);
            this.txtQrText.TabIndex = 1;
            this.txtQrText.TextChanged += new System.EventHandler(this.txtQrText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(40, 317);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(47, 24);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(313, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmQrCodeGenerator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 444);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQrText);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmQrCodeGenerator";
            this.Text = "QR Code Generator ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtQrText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnClear;
    }
}

