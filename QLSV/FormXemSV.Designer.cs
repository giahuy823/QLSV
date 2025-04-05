namespace QLSV
{
    partial class FormXemSV
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
            dataGridView1 = new DataGridView();
            comboLOP = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textHoTen = new TextBox();
            textNgaySinh = new TextBox();
            label4 = new Label();
            textDiaChi = new TextBox();
            label5 = new Label();
            BtnLuu = new Button();
            label6 = new Label();
            MaSV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(633, 170);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboLOP
            // 
            comboLOP.FormattingEnabled = true;
            comboLOP.Location = new Point(109, 158);
            comboLOP.Name = "comboLOP";
            comboLOP.Size = new Size(151, 28);
            comboLOP.TabIndex = 1;
            comboLOP.SelectedIndexChanged += comboLOP_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 162);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã lớp :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Xem sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên :";
            // 
            // textHoTen
            // 
            textHoTen.Location = new Point(109, 78);
            textHoTen.Name = "textHoTen";
            textHoTen.Size = new Size(154, 27);
            textHoTen.TabIndex = 5;
            // 
            // textNgaySinh
            // 
            textNgaySinh.Location = new Point(373, 78);
            textNgaySinh.Name = "textNgaySinh";
            textNgaySinh.Size = new Size(226, 27);
            textNgaySinh.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 81);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày sinh :";
            // 
            // textDiaChi
            // 
            textDiaChi.Location = new Point(373, 155);
            textDiaChi.Name = "textDiaChi";
            textDiaChi.Size = new Size(226, 27);
            textDiaChi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 158);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Địa chỉ :";
            // 
            // BtnLuu
            // 
            BtnLuu.Location = new Point(669, 155);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(96, 34);
            BtnLuu.TabIndex = 10;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = true;
            BtnLuu.Click += BtnLuu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 85);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 11;
            label6.Text = "Mã SV :";
            // 
            // MaSV
            // 
            MaSV.Location = new Point(688, 82);
            MaSV.Name = "MaSV";
            MaSV.Size = new Size(95, 27);
            MaSV.TabIndex = 12;
            // 
            // FormXemSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(MaSV);
            Controls.Add(label6);
            Controls.Add(BtnLuu);
            Controls.Add(textDiaChi);
            Controls.Add(label5);
            Controls.Add(textNgaySinh);
            Controls.Add(label4);
            Controls.Add(textHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboLOP);
            Controls.Add(dataGridView1);
            Name = "FormXemSV";
            Text = "FormXemSV";
            Load += FormXemSV_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboLOP;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textHoTen;
        private TextBox textNgaySinh;
        private Label label4;
        private TextBox textDiaChi;
        private Label label5;
        private Button BtnLuu;
        private Label label6;
        private TextBox MaSV;
    }
}