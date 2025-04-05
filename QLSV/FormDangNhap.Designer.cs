namespace QLSV
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            btn_DangNhap = new Button();
            btn_Exit = new Button();
            lbl_DangNhap = new Label();
            ckb_Password = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 159);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 235);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(350, 155);
            txt_Username.Margin = new Padding(3, 4, 3, 4);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(265, 27);
            txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(350, 224);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(265, 27);
            txt_Password.TabIndex = 3;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(301, 311);
            btn_DangNhap.Margin = new Padding(3, 4, 3, 4);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(106, 83);
            btn_DangNhap.TabIndex = 4;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(509, 311);
            btn_Exit.Margin = new Padding(3, 4, 3, 4);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(106, 83);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lbl_DangNhap
            // 
            lbl_DangNhap.AutoSize = true;
            lbl_DangNhap.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DangNhap.Location = new Point(350, 48);
            lbl_DangNhap.Name = "lbl_DangNhap";
            lbl_DangNhap.Size = new Size(184, 46);
            lbl_DangNhap.TabIndex = 6;
            lbl_DangNhap.Text = "Đăng nhập";
            // 
            // ckb_Password
            // 
            ckb_Password.AutoSize = true;
            ckb_Password.Location = new Point(649, 229);
            ckb_Password.Margin = new Padding(3, 4, 3, 4);
            ckb_Password.Name = "ckb_Password";
            ckb_Password.Size = new Size(148, 24);
            ckb_Password.TabIndex = 7;
            ckb_Password.Text = "Hiển thị mật khẩu";
            ckb_Password.UseVisualStyleBackColor = true;
            ckb_Password.CheckedChanged += ckb_Password_CheckedChanged;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 455);
            Controls.Add(ckb_Password);
            Controls.Add(lbl_DangNhap);
            Controls.Add(btn_Exit);
            Controls.Add(btn_DangNhap);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình đăng nhập";
            FormClosed += FormDangNhap_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_DangNhap;
        private Button btn_Exit;
        private Label lbl_DangNhap;
        private CheckBox ckb_Password;
    }
}
