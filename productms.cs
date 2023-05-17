using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace market_management
{
    public partial class productms : Form
    {
        Funtions con;
        public productms()
        {
            InitializeComponent();
            con = new Funtions();
            showproduct();
            getshop();
        }
        private void showproduct()
        {
            string Query = "select * from producrtb";
            Prdlist.DataSource = con.GetData(Query);
        }

        private void pidtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void productnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ditb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sidcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pricetb_TextChanged(object sender, EventArgs e)
        {

        }
        private void getshop()
        {
            string Query = "select * from Shoptb";

            sidcb.DisplayMember = con.GetData(Query).Columns["shopname"].ToString();
            sidcb.ValueMember = con.GetData(Query).Columns["sid"].ToString();
            sidcb.DataSource = con.GetData(Query);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productnametb.Text == "" || pricetb.Text == "" || sidcb.SelectedIndex == -1)
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string pname = productnametb.Text;
                    string import = Convert.ToString(ditb.Value.ToString("yyyy-MM-dd")); ;
                    int pprice = Convert.ToInt32(pricetb.Text);
                    int ssid = Convert.ToInt32(sidcb.SelectedValue.ToString());


                    string Query = "insert into producrtb values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, pname, import, pprice, ssid);
                    con.SetData(Query);
                    showproduct();

                    MessageBox.Show("product added");

                    productnametb.Text = "";
                    pricetb.Text = "";
                    sidcb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void Prdlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productnametb.Text = Prdlist.SelectedRows[0].Cells[1].Value.ToString();
            ditb.Text = Prdlist.SelectedRows[0].Cells[2].Value.ToString();
            pricetb.Text = Prdlist.SelectedRows[0].Cells[3].Value.ToString();
            sidcb.Text = Prdlist.SelectedRows[0].Cells[4].Value.ToString();
            if (productnametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Prdlist.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productnametb.Text == "" || pricetb.Text == "" || sidcb.SelectedIndex == -1)
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string pname = productnametb.Text;
                    string import = ditb.Value.ToString();
                    int pprice = Convert.ToInt32(pricetb.Text);
                    int ssid = Convert.ToInt32(sidcb.SelectedValue.ToString());


                    string Query = "update producrtb set pname='{0}',importdate='{1}',price={2},psid={3} where pid={4}";
                    Query = string.Format(Query, pname, import, pprice, ssid,key);
                    con.SetData(Query);
                    showproduct();

                    MessageBox.Show("product updated");

                    productnametb.Text = "";
                    pricetb.Text = "";
                    sidcb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backm_Click(object sender, EventArgs e)
        {
            menuview obj = new menuview();
            obj.Show();
            this.Hide();
        }

        private void shoplb_Click(object sender, EventArgs e)
        {
            shopms obj = new shopms();
            obj.Show();
            this.Hide();
        }

        private void emplb_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
