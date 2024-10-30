using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Tulja_jeweller
{
    public partial class showbills : Form
    {
        SqlConnection con = null;

        public showbills()
        {
            InitializeComponent();

        }
        public void getDetatils()
        {
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-D55E0N4N\SQLEXPRESS;Initial Catalog=jawellers;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from jawellers where naam='" + search.Text + "'", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                dt.Load(sqlDataReader);
                sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        naam.Text = sqlDataReader["naam"].ToString();
                        gaam.Text = sqlDataReader["gaam"].ToString();
                        vigat.Text = sqlDataReader["vigat"].ToString();
                        tarikh.Text = sqlDataReader["date"].ToString();
                        bhaav.Text = sqlDataReader["bhaav"].ToString();
                        majuri.Text = sqlDataReader["majuri"].ToString();
                        mo.Text = sqlDataReader["Mo"].ToString();



                    }
                }
                else
                {
                    MessageBox.Show("No data found for the given search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

        public void update()
        {


            


        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            getDetatils();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE jawellers SET naam = @naam, gaam = @gaam,vigat=@vigat,bhaav=@bhaav,majuri=@majuri,Mo=@mo WHERE naam = '"+search.Text+"'";
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(updateQuery, con);
                command.Parameters.AddWithValue("@naam", naam.Text);
                command.Parameters.AddWithValue("@gaam", gaam.Text);
                command.Parameters.AddWithValue("@vigat", vigat.Text);
                command.Parameters.AddWithValue("@bhaav", bhaav.Text);
                command.Parameters.AddWithValue("@majuri", majuri.Text);
                command.Parameters.AddWithValue("@mo", mo.Text);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("updated");
                }
                if (rowsAffected < 0)
                {
                    MessageBox.Show("Not updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
