namespace QliNhanVien
{
    partial class Form2
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
            this.lblMSNV = new System.Windows.Forms.Label();
            this.lblTNV = new System.Windows.Forms.Label();
            this.lblLCB = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTNV = new System.Windows.Forms.TextBox();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.btnDY = new System.Windows.Forms.Button();
            this.btnBQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(51, 35);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(46, 16);
            this.lblMSNV.TabIndex = 0;
            this.lblMSNV.Text = "MSNV";
            // 
            // lblTNV
            // 
            this.lblTNV.AutoSize = true;
            this.lblTNV.Location = new System.Drawing.Point(51, 110);
            this.lblTNV.Name = "lblTNV";
            this.lblTNV.Size = new System.Drawing.Size(94, 16);
            this.lblTNV.TabIndex = 1;
            this.lblTNV.Text = "Ten nhan vien ";
            // 
            // lblLCB
            // 
            this.lblLCB.AutoSize = true;
            this.lblLCB.Location = new System.Drawing.Point(51, 187);
            this.lblLCB.Name = "lblLCB";
            this.lblLCB.Size = new System.Drawing.Size(91, 16);
            this.lblLCB.TabIndex = 2;
            this.lblLCB.Text = "Luong co ban ";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(163, 32);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(158, 22);
            this.txtMSNV.TabIndex = 3;
            // 
            // txtTNV
            // 
            this.txtTNV.Location = new System.Drawing.Point(163, 104);
            this.txtTNV.Name = "txtTNV";
            this.txtTNV.Size = new System.Drawing.Size(257, 22);
            this.txtTNV.TabIndex = 4;
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(163, 181);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(158, 22);
            this.txtLCB.TabIndex = 5;
            // 
            // btnDY
            // 
            this.btnDY.Location = new System.Drawing.Point(81, 245);
            this.btnDY.Name = "btnDY";
            this.btnDY.Size = new System.Drawing.Size(91, 40);
            this.btnDY.TabIndex = 6;
            this.btnDY.Text = "Dong y";
            this.btnDY.UseVisualStyleBackColor = true;
            this.btnDY.Click += new System.EventHandler(this.btnDY_Click);
            // 
            // btnBQ
            // 
            this.btnBQ.Location = new System.Drawing.Point(287, 245);
            this.btnBQ.Name = "btnBQ";
            this.btnBQ.Size = new System.Drawing.Size(91, 40);
            this.btnBQ.TabIndex = 7;
            this.btnBQ.Text = "Bo qua ";
            this.btnBQ.UseVisualStyleBackColor = true;
            this.btnBQ.Click += new System.EventHandler(this.btnBQ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 306);
            this.Controls.Add(this.btnBQ);
            this.Controls.Add(this.btnDY);
            this.Controls.Add(this.txtLCB);
            this.Controls.Add(this.txtTNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lblLCB);
            this.Controls.Add(this.lblTNV);
            this.Controls.Add(this.lblMSNV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.Label lblTNV;
        private System.Windows.Forms.Label lblLCB;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTNV;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Button btnDY;
        private System.Windows.Forms.Button btnBQ;
    }
}