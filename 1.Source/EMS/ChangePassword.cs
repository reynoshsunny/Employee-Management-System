using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection er = ConnectDb.Connect_Db();
            er.Open();
         
            string txtPassword = textBox1.Text;
            string txtConfirm = textBox2.Text;

            if (txtPassword.Length > 3 && txtConfirm.Length > 3)
            {
                if (txtPassword == txtConfirm)
                {
                    string query = "UPDATE M_USERS SET USER_PASSWORD = '" + txtPassword + "' where ID_USER = "+ Global._userid + " ";

                    SqlCommand cmd = new SqlCommand(query, er);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully!");
                    this.Close();
                }
                else {

                    MessageBox.Show("Both passwords are mismatch, Please check password");
                }

            }
            else {
                MessageBox.Show("Enter minimum 4 character length password !!");
            }
                                        
        }
    }
}
