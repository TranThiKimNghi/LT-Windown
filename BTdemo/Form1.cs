using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTdemo
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem  lvi = new ListViewItem(txtList.Text);
            lvi.SubItems.Add(txtList.Text);
            lvi.SubItems.Add(txtFist.Text);
            lvi.SubItems.Add(txtso.Text);

            lv.Items.Add(lvi);


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
