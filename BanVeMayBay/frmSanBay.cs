using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeMayBay
{
    public partial class frmSanBay : Form
    {
        public frmSanBay()
        {
            InitializeComponent();
        }

        private void Them_button_Click(object sender, EventArgs e)
        {
            Form frmThemSanBay = new frmThemSanBay();
            frmThemSanBay.Show();
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
