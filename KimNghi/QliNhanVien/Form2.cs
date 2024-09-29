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
    public partial class Form2 : Form
    {
        private bool isEditMode; 
        private string maNV;
        private object dataGridView1;
        private string connectionString;

        public Form2()
        {
            InitializeComponent();
           
        }
        public delegate void GetData(string maNV, string tenNV, double luongCB);
        public GetData mydata;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDY_Click(object sender, EventArgs e)
        {
            if (mydata != null)
            {
                if (double.TryParse(txtLCB.Text, out double luongCB))
                {
                    mydata(txtMSNV.Text, txtTNV.Text, luongCB);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lương cơ bản phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBQ_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    }

