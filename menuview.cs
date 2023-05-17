using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class menuview : Form
    {
        public menuview()
        {
            InitializeComponent();
        }

        private void emplb_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void shoplb_Click(object sender, EventArgs e)
        {
            shopms obj = new shopms();
            obj.Show();
            this.Hide();
        }

        private void prdlb_Click(object sender, EventArgs e)
        {
            productms obj = new productms();
            obj.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutlb_Click(object sender, EventArgs e)
        {
            this.Hide();
            login obj = new login();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
