namespace BTdemo
{
    partial class Form1
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
            this.lv = new System.Windows.Forms.ListView();
            this.txtList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtList,
            this.txtFist,
            this.txtso});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(34, 42);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(335, 293);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // txtList
            // 
            this.txtList.Text = "Last name";
            this.txtList.Width = 79;
            // 
            // txtFist
            // 
            this.txtFist.Text = "Fist name";
            this.txtFist.Width = 119;
            // 
            // txtso
            // 
            this.txtso.Text = "Phone";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(465, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 22);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(465, 174);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(225, 22);
            this.textBox8.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(465, 281);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(225, 22);
            this.textBox9.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Them ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(331, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Xoa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(580, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sua";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(731, 446);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "From1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader txtList;
        private System.Windows.Forms.ColumnHeader txtFist;
        private System.Windows.Forms.ColumnHeader txtso;
    }
}

