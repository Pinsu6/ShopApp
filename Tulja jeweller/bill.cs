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
    public partial class bill : Form
    {
        SqlConnection con = null;
        public bill()
        {
            InitializeComponent();
            
        }

        private void create_Click(object sender, EventArgs e)
        {
            connection();
            validation();
        }
    public void connection()
        {
           con = new SqlConnection(@"Data Source=LAPTOP-D55E0N4N\SQLEXPRESS;Initial Catalog=jawellers;Integrated Security=True");
            if(validation())
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into jawellers values(@naam,@gaam,@vigat,@date,@bhaav,@majuri,@Mo)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@naam", name.Text);
                    cmd.Parameters.AddWithValue("@gaam", gaam.Text);
                    cmd.Parameters.AddWithValue("@vigat", viagat.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));
                    cmd.Parameters.AddWithValue("@bhaav", bhaav.Text);
                    cmd.Parameters.AddWithValue("@majuri", majuri.Text);
                    cmd.Parameters.AddWithValue("@Mo", Mo.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Biil created!", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    naam.Text = "";
                    gaam.Text = "";
                    viagat.Text = "";
                    bhaav.Text = "";
                    majuri.Text = "";
                }
            }
        }

        public bool validation()
        {
            if(name.Text==String.Empty)
            {
                MessageBox.Show("please enter name", "Message", MessageBoxButtons.OK);

                return false;

            }
            else if(gaam.Text == string.Empty)
            {
                MessageBox.Show("please enter gaam name", "Message", MessageBoxButtons.OK);

                return false;
            }
            else if(bhaav.Text == string.Empty)
            {
                MessageBox.Show("please Bhaav", "Message", MessageBoxButtons.OK);

                return false;
            }

            else if(majuri.Text == string.Empty)
            {
                MessageBox.Show("please enter majuri", "Message", MessageBoxButtons.OK);

                return false;
            }
            else if (viagat.Text == string.Empty)
            {
                MessageBox.Show("please enter vigat", "Message", MessageBoxButtons.OK);

                return false;
            }
            return true;
        }
    }
}
