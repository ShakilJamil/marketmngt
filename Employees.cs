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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace market_management
{
    public partial class Employees : Form
    {
        Funtions con;
        public Employees()
        {
            InitializeComponent();
            con = new Funtions();
            showemp();
        }
        private void showemp()
        {
            string Query = "select * from emptb";
            emplist.DataSource = con.GetData(Query);
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ename.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string eename = ename.Text;
                    int ssalary = Convert.ToInt32(textBox5.Text);
                    string ejdate = Convert.ToString(jdate.Value.ToString("yyyy-MM-dd"));

                    string Query = "insert into emptb values('{0}',{1},'{2}')";
                    Query = string.Format(Query, eename, ssalary, ejdate);
                    con.SetData(Query);
                    showemp();

                    MessageBox.Show("emplyee added");

                    ename.Text = "";
                    textBox5.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("missing data!");
                }
                else
                {



                    string Query = "delete from emptb where empid={0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    showemp();

                    MessageBox.Show("emplyee deleted");

                    ename.Text = "";
                    textBox5.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ename.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("missing data!");
                }
                else
                {

                    string eename = ename.Text;
                    int ssalary = Convert.ToInt32(textBox5.Text);
                    string ejdate = jdate.Value.ToString();

                    string Query = "update  emptb set empname='{0}',joindate='{1}',salary='{2}' where empid={3} ";
                    Query = string.Format(Query, eename, ejdate, ssalary, key);
                    con.SetData(Query);
                    showemp();

                    MessageBox.Show("emplyee updated");

                    ename.Text = "";
                    textBox5.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int key = 0;
        private void emplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ename.Text = emplist.SelectedRows[0].Cells[1].Value.ToString();
            textBox5.Text = emplist.SelectedRows[0].Cells[2].Value.ToString();
            jdate.Text = emplist.SelectedRows[0].Cells[3].Value.ToString();
            if (ename.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(emplist.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void emplb_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void shoplb_Click(object sender, EventArgs e)
        {
            shopms obj = new shopms();
            obj.Show();
            this.Hide();
        }

        private void backm_Click(object sender, EventArgs e)
        {
            menuview obj = new menuview();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void prdlb_Click(object sender, EventArgs e)
        {
            productms obj = new productms();
            obj.Show();
            this.Hide();
        }
    }
}
