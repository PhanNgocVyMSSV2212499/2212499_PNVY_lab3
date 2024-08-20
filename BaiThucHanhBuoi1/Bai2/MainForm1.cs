using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnNam.Checked)
            MessageBox.Show("Bạn Chọn giới tính nam", "Thông báo");
        }

        private void rbntNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbntNu.Checked)
            MessageBox.Show("Bạn Chọn giới tính Nữ", "Thông báo");
        }

        private void bntColor_Click(object sender, EventArgs e)
        {
            if(rbtnRed.Checked)
                txtHopMAu.BackColor = Color.Red;
            else
                txtHopMAu.BackColor= Color.Green;
        }
    }
}
