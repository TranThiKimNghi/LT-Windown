using QuanLySinhVien.Models;
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

namespace QuanLySinhVien
{
    public partial class QlySinhVien : Form
    {
    
        public QlySinhVien()
        {
            InitializeComponent();
        }

        private void QlySinhVien_Load(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Server=QUANGTIN\\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Hiển thị danh sách sinh viên trong DataGridView
                    string queryStudent = "SELECT * FROM Student";
                    SqlDataAdapter daStudent = new SqlDataAdapter(queryStudent, conn);
                    DataTable dtStudent = new DataTable();
                    daStudent.Fill(dtStudent);
                    dgvSinhVien.DataSource = dtStudent;

                    // Hiển thị danh sách Khoa trong ComboBox
                    string queryFaculty = "SELECT * FROM Faculty";
                    SqlDataAdapter daFaculty = new SqlDataAdapter(queryFaculty, conn);
                    DataTable dtFaculty = new DataTable();
                    daFaculty.Fill(dtFaculty);
                    cmbKhoa.DataSource = dtFaculty;
                    cmbKhoa.DisplayMember = "FacultyName";
                    cmbKhoa.ValueMember = "FacultyID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || txtMaSV.Text.Length != 10 ||
       string.IsNullOrEmpty(txtHoTen.Text) ||
       string.IsNullOrEmpty(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string connectionString = "Server=QUANGTIN\\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID) " +
                               "VALUES (@StudentID, @FullName, @AverageScore, @FacultyID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@FullName", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@AverageScore", Convert.ToDouble(txtDiemTB.Text));
                cmd.Parameters.AddWithValue("@FacultyID", cmbKhoa.SelectedValue);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    ResetData();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm dữ liệu.");
                }
            }
            LoadStudentData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || txtMaSV.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên hợp lệ!");
                return;
            }

            string connectionString = "Server=QUANGTIN\\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Student SET FullName = @FullName, AverageScore = @AverageScore, FacultyID = @FacultyID " +
                               "WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@FullName", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@AverageScore", Convert.ToDouble(txtDiemTB.Text));
                cmd.Parameters.AddWithValue("@FacultyID", cmbKhoa.SelectedValue);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    ResetData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy MSSV cần sửa!");
                }
            }
            LoadStudentData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || txtMaSV.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên hợp lệ!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=QUANGTIN\\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Student WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", txtMaSV.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!");
                        ResetData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy MSSV cần xóa!");
                    }
                }
            }
            LoadStudentData();
        }

        private void ResetData()
        {
            txtMaSV.ResetText();
            txtHoTen.ResetText();
            txtDiemTB.ResetText();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["StudentID"].Value.ToString();
                txtHoTen.Text = row.Cells["FullName"].Value.ToString();
                txtDiemTB.Text = row.Cells["AverageScore"].Value.ToString();
                cmbKhoa.SelectedValue = row.Cells["FacultyID"].Value;
            }
        }

        private void LoadStudentData()
        {
            string connectionString = "Server=QUANGTIN\\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Student";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
        }
    }
}
