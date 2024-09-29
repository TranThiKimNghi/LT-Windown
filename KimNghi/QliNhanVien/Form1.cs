using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QliNhanVien
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Your connection string";
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        public int TimDongChuaSV(string maNV)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == maNV)
                {
                    return i; //dòng nhân viên tìm thấy
                }
            }
            return -1; //Không tìm thấy nhân viên
        }

        private void LoadDataGridView()
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 formNV = new Form2();
            formNV.mydata = new Form2.GetData((maNV, tenNV, luongCB) =>
            {

                dataGridView1.Rows.Add(maNV, tenNV, luongCB);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
            formNV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form2 formNV = new Form2();
            formNV.mydata = new Form2.GetData((maNV, tenNV, luongCB) =>
            {
                int dongNV = TimDongChuaSV(maNV);
                if (dongNV != -1)
                {
                    dataGridView1.Rows[dongNV].Cells[1].Value = tenNV;
                    dataGridView1.Rows[dongNV].Cells[2].Value = luongCB;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
            formNV.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           
            {
                this.Close();
            }
        }
    }
    }
    
        