using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void rbtnyellow_CheckedChanged(object sender, EventArgs e)
        {
            txtdongia.Text = "22000";
        }

        private void rbtnred_CheckedChanged(object sender, EventArgs e)
        {
            txtdongia.Text = "21000";
        }

        private void rbtnwhite_CheckedChanged(object sender, EventArgs e)
        {
            txtdongia.Text = "20000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(txtdongia.Text)*int.Parse(txtsoluong.Text);
            label3.Text =soTien.ToString();
        }

        private void FrmBai1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
