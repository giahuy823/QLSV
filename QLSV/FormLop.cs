using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLSV
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        SinhVien sv = new SinhVien();
        private void FormLop_Load(object sender, EventArgs e)
        {
            
            if (UserInfo.ChucVu == "NHANVIEN")
            {
                dataGridViewLop.DataSource = nv.LoadBangLop(UserInfo.ID);
            }
            else
            {
                dataGridViewLop.DataSource = sv.LoadBangLop(sv.LayMaLop(UserInfo.ID));
            }

            DecorGrid.SetupDataGridViewStyle(dataGridViewLop);
            
        }
        

    }
}
