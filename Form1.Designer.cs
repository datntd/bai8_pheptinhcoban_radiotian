namespace bai8_pheptinhcoban_radiotian
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
            this.txttinhtong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtru = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.rdbcong = new System.Windows.Forms.RadioButton();
            this.rdbchia = new System.Windows.Forms.RadioButton();
            this.rdbnhan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttinhtong
            // 
            this.txttinhtong.Location = new System.Drawing.Point(142, 237);
            this.txttinhtong.Name = "txttinhtong";
            this.txttinhtong.Size = new System.Drawing.Size(75, 23);
            this.txttinhtong.TabIndex = 0;
            this.txttinhtong.Text = "Tính Tổng ";
            this.txttinhtong.UseVisualStyleBackColor = true;
            this.txttinhtong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nhap so 2";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(133, 131);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 2;
            this.txtso2.Text = "7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnhan);
            this.groupBox1.Controls.Add(this.rdbchia);
            this.groupBox1.Controls.Add(this.rdbcong);
            this.groupBox1.Controls.Add(this.rdbtru);
            this.groupBox1.Location = new System.Drawing.Point(493, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phép tính cơ bản ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtru
            // 
            this.rdbtru.AutoSize = true;
            this.rdbtru.Location = new System.Drawing.Point(18, 94);
            this.rdbtru.Name = "rdbtru";
            this.rdbtru.Size = new System.Drawing.Size(41, 17);
            this.rdbtru.TabIndex = 0;
            this.rdbtru.TabStop = true;
            this.rdbtru.Text = "Trừ";
            this.rdbtru.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhap so 1";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(133, 85);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            this.txtso1.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ket qua";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(133, 188);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 2;
            // 
            // rdbcong
            // 
            this.rdbcong.AutoSize = true;
            this.rdbcong.Location = new System.Drawing.Point(18, 61);
            this.rdbcong.Name = "rdbcong";
            this.rdbcong.Size = new System.Drawing.Size(53, 17);
            this.rdbcong.TabIndex = 0;
            this.rdbcong.TabStop = true;
            this.rdbcong.Text = "Cộng ";
            this.rdbcong.UseVisualStyleBackColor = true;
            this.rdbcong.CheckedChanged += new System.EventHandler(this.rdbcong_CheckedChanged);
            // 
            // rdbchia
            // 
            this.rdbchia.AutoSize = true;
            this.rdbchia.Location = new System.Drawing.Point(18, 160);
            this.rdbchia.Name = "rdbchia";
            this.rdbchia.Size = new System.Drawing.Size(46, 17);
            this.rdbchia.TabIndex = 0;
            this.rdbchia.TabStop = true;
            this.rdbchia.Text = "Chia";
            this.rdbchia.UseVisualStyleBackColor = true;
            // 
            // rdbnhan
            // 
            this.rdbnhan.AutoSize = true;
            this.rdbnhan.Location = new System.Drawing.Point(18, 127);
            this.rdbnhan.Name = "rdbnhan";
            this.rdbnhan.Size = new System.Drawing.Size(51, 17);
            this.rdbnhan.TabIndex = 0;
            this.rdbnhan.TabStop = true;
            this.rdbnhan.Text = "Nhân";
            this.rdbnhan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttinhtong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txttinhtong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtru;
        private System.Windows.Forms.RadioButton rdbnhan;
        private System.Windows.Forms.RadioButton rdbchia;
        private System.Windows.Forms.RadioButton rdbcong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label4;
    }
}

