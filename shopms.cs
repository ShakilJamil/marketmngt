using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace market_management
{
    public partial class shopms : Form
    {
        Funtions con;
        public shopms()
        {
            InitializeComponent();
            con = new Funtions();
            showshops();
        }
        private void showshops()
        {
            string Query = "select * from Shoptb";
            shoplist.DataSource = con.GetData(Query);
        }
        private void backm_Click(object sender, EventArgs e)
        {
            menuview obj = new menuview();
            obj.Show();
            this.Hide();
        }

        private void slevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (snametb.Text == "" || srent.Text == "" || slevel.Text == "")
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string sname = snametb.Text;
                    string sdate = Convert.ToString(shopdp.Value.ToString("yyyy-MM-dd"));
                    int rent = Convert.ToInt32(srent.Text);
                    int lev = Convert.ToInt32(slevel.Text);
                    string Query = "insert into Shoptb values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, sname, sdate, rent, lev);
                    con.SetData(Query);
                    showshops();

                    MessageBox.Show("shop added");

                    snametb.Text = "";
                    srent.Text = "";
                    slevel.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sidtb_TextChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void shoplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            snametb.Text = shoplist.SelectedRows[0].Cells[1].Value.ToString();
            shopdp.Text = shoplist.SelectedRows[0].Cells[2].Value.ToString();
            srent.Text = shoplist.SelectedRows[0].Cells[3].Value.ToString();
            slevel.Text = shoplist.SelectedRows[0].Cells[4].Value.ToString();
            if (snametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(shoplist.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void productlb_Click(object sender, EventArgs e)
        {
            productms obj = new productms();
            obj.Show();
            this.Hide();
        }

        private void emplb_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (snametb.Text == "" || srent.Text == "" || slevel.Text == "")
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string sname = snametb.Text;
                    string sdate = shopdp.Value.ToString();
                    int rent = Convert.ToInt32(srent.Text);
                    int lev = Convert.ToInt32(slevel.Text);
                    string Query = "update  Shoptb set sname='{0}',rentdate='{1}',rent={2},level={3} where sid={4}";
                    Query = string.Format(Query, sname, sdate, rent, lev, key);
                    con.SetData(Query);
                    showshops();

                    MessageBox.Show("shop updated");

                    snametb.Text = "";
                    srent.Text = "";
                    slevel.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
