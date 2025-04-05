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
    public partial class FormXemSV : Form
    {
        public FormXemSV()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
            textDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI"].Value.ToString();
            textNgaySinh.Text = dataGridView1.Rows[e.RowIndex].Cells["NGAYSINH"].Value.ToString();
            MaSV.Text = dataGridView1.Rows[e.RowIndex].Cells["MASV"].Value.ToString();

        }
        NhanVien nv = new NhanVien();
        SinhVien sv = new SinhVien();
        private void FormXemSV_Load(object sender, EventArgs e)
        {
            BtnLuu.Enabled = false;
            if (UserInfo.ChucVu == "NHANVIEN")
            {
                List<string> dsmahd = new List<string>();
                dsmahd = nv.LayDanhSachLop(UserInfo.ID);
                foreach (string maHopDong in dsmahd)
                {
                    comboLOP.Items.Add(maHopDong);
                }
            }
        }
        

        private void comboLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sv.LoadBangSV(comboLOP.Text);
            DecorGrid.SetupDataGridViewStyle(dataGridView1);
            BtnLuu.Enabled = true;

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!DateTime.TryParse(textNgaySinh.Text, out DateTime ngaySinh))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng (VD: 01/01/2000).",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                sv.CapNhapSv(MaSV.Text, textHoTen.Text, ngaySinh.ToString("yyyy-MM-dd"), textDiaChi.Text);

                
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = sv.LoadBangSV(comboLOP.Text);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Có lỗi xảy ra khi cập nhật sinh viên: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
