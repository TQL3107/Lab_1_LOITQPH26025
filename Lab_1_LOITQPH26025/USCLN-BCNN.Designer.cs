namespace Lab_1_LOITQPH26025
{
    partial class USCLN_BCNN
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
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_BCNN = new System.Windows.Forms.RadioButton();
            this.rb_USCLN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_B);
            this.groupBox1.Controls.Add(this.tb_A);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(106, 85);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(250, 27);
            this.tb_B.TabIndex = 3;
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(106, 25);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(250, 27);
            this.tb_A.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_BCNN);
            this.groupBox2.Controls.Add(this.rb_USCLN);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng";
            // 
            // rb_BCNN
            // 
            this.rb_BCNN.AutoSize = true;
            this.rb_BCNN.Location = new System.Drawing.Point(56, 91);
            this.rb_BCNN.Name = "rb_BCNN";
            this.rb_BCNN.Size = new System.Drawing.Size(78, 24);
            this.rb_BCNN.TabIndex = 1;
            this.rb_BCNN.TabStop = true;
            this.rb_BCNN.Text = "BSCNN";
            this.rb_BCNN.UseVisualStyleBackColor = true;
            this.rb_BCNN.Click += new System.EventHandler(this.rb_BCNN_Click);
            // 
            // rb_USCLN
            // 
            this.rb_USCLN.AutoSize = true;
            this.rb_USCLN.Location = new System.Drawing.Point(56, 39);
            this.rb_USCLN.Name = "rb_USCLN";
            this.rb_USCLN.Size = new System.Drawing.Size(75, 24);
            this.rb_USCLN.TabIndex = 0;
            this.rb_USCLN.TabStop = true;
            this.rb_USCLN.Text = "USCLN";
            this.rb_USCLN.UseVisualStyleBackColor = true;
            this.rb_USCLN.CheckedChanged += new System.EventHandler(this.rb_USCLN_CheckedChanged);
            this.rb_USCLN.ClientSizeChanged += new System.EventHandler(this.rb_USCLN_ClientSizeChanged);
            this.rb_USCLN.Click += new System.EventHandler(this.rb_USCLN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_thoat);
            this.groupBox3.Controls.Add(this.btn_skip);
            this.groupBox3.Controls.Add(this.btn_tim);
            this.groupBox3.Controls.Add(this.tb_kq);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 157);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chuyển";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(329, 97);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 35);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(175, 97);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(112, 35);
            this.btn_skip.TabIndex = 6;
            this.btn_skip.Text = "Bỏ qua";
            this.btn_skip.UseVisualStyleBackColor = true;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(38, 97);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(107, 35);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // tb_kq
            // 
            this.tb_kq.Location = new System.Drawing.Point(38, 43);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(547, 27);
            this.tb_kq.TabIndex = 4;
            // 
            // USCLN_BCNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "USCLN_BCNN";
            this.Text = "USCLN_BCNN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_B;
        private TextBox tb_A;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rb_BCNN;
        private RadioButton rb_USCLN;
        private GroupBox groupBox3;
        private Button button1;
        private Button btn_thoat;
        private Button btn_skip;
        private Button btn_tim;
        private TextBox tb_kq;
    }
}