﻿namespace QLSV
{
    partial class FormLop
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
            dataGridViewLop = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLop).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLop
            // 
            dataGridViewLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLop.Location = new Point(65, 161);
            dataGridViewLop.Name = "dataGridViewLop";
            dataGridViewLop.RowHeadersWidth = 51;
            dataGridViewLop.Size = new Size(765, 258);
            dataGridViewLop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 70);
            label1.Name = "label1";
            label1.Size = new Size(53, 31);
            label1.TabIndex = 1;
            label1.Text = "Lớp";
            // 
            // FormLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 492);
            Controls.Add(label1);
            Controls.Add(dataGridViewLop);
            Name = "FormLop";
            Text = "Form1";
            Load += FormLop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLop;
        private Label label1;
    }
}