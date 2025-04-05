namespace QLSV
{
    partial class FormMenu
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
            label1 = new Label();
            TextUser = new MenuStrip();
            User = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TextUser.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 68);
            label1.Name = "label1";
            label1.Size = new Size(107, 46);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // TextUser
            // 
            TextUser.ImageScalingSize = new Size(20, 20);
            TextUser.Items.AddRange(new ToolStripItem[] { User });
            TextUser.Location = new Point(0, 0);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(914, 28);
            TextUser.TabIndex = 1;
            TextUser.Text = "menuStrip1";
            // 
            // User
            // 
            User.DropDownItems.AddRange(new ToolStripItem[] { chứcVụToolStripMenuItem });
            User.Name = "User";
            User.Size = new Size(156, 24);
            User.Text = "toolStripMenuItem1";
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(144, 26);
            chứcVụToolStripMenuItem.Text = "Chức vụ";
            // 
            // button1
            // 
            button1.Location = new Point(140, 162);
            button1.Name = "button1";
            button1.Size = new Size(202, 88);
            button1.TabIndex = 2;
            button1.Text = "Xem lớp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(504, 162);
            button2.Name = "button2";
            button2.Size = new Size(202, 88);
            button2.TabIndex = 3;
            button2.Text = "Xem sinh viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(333, 306);
            button3.Name = "button3";
            button3.Size = new Size(202, 88);
            button3.TabIndex = 4;
            button3.Text = "Nhập điểm sinh viên";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 518);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TextUser);
            MainMenuStrip = TextUser;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            TextUser.ResumeLayout(false);
            TextUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip TextUser;
        private ToolStripMenuItem User;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}