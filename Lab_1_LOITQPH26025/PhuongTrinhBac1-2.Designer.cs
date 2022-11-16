namespace Lab_1_LOITQPH26025
{
    partial class PhuongTrinhBac1_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_A = new System.Windows.Forms.TextBox();
            this.tB_B = new System.Windows.Forms.TextBox();
            this.tB_C = new System.Windows.Forms.TextBox();
            this.tB_kq = new System.Windows.Forms.TextBox();
            this.btn_giai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.rdB_Bac1 = new System.Windows.Forms.RadioButton();
            this.rdB_Bac2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdB_Bac2);
            this.groupBox1.Controls.Add(this.rdB_Bac1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giải Phương Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập b :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập c :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập a :";
            // 
            // tB_A
            // 
            this.tB_A.Location = new System.Drawing.Point(112, 267);
            this.tB_A.Name = "tB_A";
            this.tB_A.Size = new System.Drawing.Size(125, 27);
            this.tB_A.TabIndex = 6;
            // 
            // tB_B
            // 
            this.tB_B.Location = new System.Drawing.Point(112, 323);
            this.tB_B.Name = "tB_B";
            this.tB_B.Size = new System.Drawing.Size(125, 27);
            this.tB_B.TabIndex = 7;
            // 
            // tB_C
            // 
            this.tB_C.Location = new System.Drawing.Point(112, 379);
            this.tB_C.Name = "tB_C";
            this.tB_C.Size = new System.Drawing.Size(125, 27);
            this.tB_C.TabIndex = 8;
            // 
            // tB_kq
            // 
            this.tB_kq.Location = new System.Drawing.Point(112, 437);
            this.tB_kq.Name = "tB_kq";
            this.tB_kq.Size = new System.Drawing.Size(296, 27);
            this.tB_kq.TabIndex = 9;
            // 
            // btn_giai
            // 
            this.btn_giai.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_giai.Location = new System.Drawing.Point(256, 270);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(152, 80);
            this.btn_giai.TabIndex = 10;
            this.btn_giai.Text = "Giải";
            this.btn_giai.UseVisualStyleBackColor = true;
            this.btn_giai.Click += new System.EventHandler(this.btn_giai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(256, 377);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(152, 29);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // rdB_Bac1
            // 
            this.rdB_Bac1.AutoSize = true;
            this.rdB_Bac1.Location = new System.Drawing.Point(100, 39);
            this.rdB_Bac1.Name = "rdB_Bac1";
            this.rdB_Bac1.Size = new System.Drawing.Size(187, 24);
            this.rdB_Bac1.TabIndex = 0;
            this.rdB_Bac1.TabStop = true;
            this.rdB_Bac1.Text = "Giải Phương Trình Bậc 1";
            this.rdB_Bac1.UseVisualStyleBackColor = true;
            this.rdB_Bac1.CheckedChanged += new System.EventHandler(this.rdB_Bac1_CheckedChanged);
            // 
            // rdB_Bac2
            // 
            this.rdB_Bac2.AutoSize = true;
            this.rdB_Bac2.Location = new System.Drawing.Point(100, 102);
            this.rdB_Bac2.Name = "rdB_Bac2";
            this.rdB_Bac2.Size = new System.Drawing.Size(187, 24);
            this.rdB_Bac2.TabIndex = 1;
            this.rdB_Bac2.TabStop = true;
            this.rdB_Bac2.Text = "Giải Phương Trình Bậc 2";
            this.rdB_Bac2.UseVisualStyleBackColor = true;
            this.rdB_Bac2.CheckedChanged += new System.EventHandler(this.rdB_Bac2_CheckedChanged);
            // 
            // PhuongTrinhBac1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 506);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_giai);
            this.Controls.Add(this.tB_kq);
            this.Controls.Add(this.tB_C);
            this.Controls.Add(this.tB_B);
            this.Controls.Add(this.tB_A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhuongTrinhBac1_2";
            this.Text = "PhuongTrinhBac1_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdB_Bac2;
        private RadioButton rdB_Bac1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tB_A;
        private TextBox tB_B;
        private TextBox tB_C;
        private TextBox tB_kq;
        private Button btn_giai;
        private Button btn_thoat;
    }
}