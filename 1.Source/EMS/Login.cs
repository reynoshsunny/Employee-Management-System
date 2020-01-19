using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EMS
{
    public partial class Login : Form
    {
        SqlConnection er = ConnectDb.Connect_Db();
        
        public Login()
        {           
            InitializeComponent();
        }
                      
   
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
  

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (er.State == ConnectionState.Open)
            {

            }
            else
            {

                er.Open();
            }


            string userid = textBox1.Text;
            string password = textBox2.Text;
            string query = "SELECT ID_USER, USER_ROLE FROM M_USERS WHERE USER_NAME ='" + textBox1.Text + "' AND USER_PASSWORD ='" + textBox2.Text + "'";


            SqlCommand cmd = new SqlCommand(query, er);
            SqlDataReader dbr = cmd.ExecuteReader();

            int count = 0;
            while (dbr.Read())

            {
                count = count + 1;
                string _id = dbr.GetValue(0).ToString();
                Global._userid = _id;
                string _userrole = dbr.GetValue(1).ToString();
                Global._userrole = _userrole;
            }

            if (count > 0)
            {
                DashBoard LoginForm = new EMS.DashBoard();
                LoginForm.Show();
                LoginForm.FormClosed += new FormClosedEventHandler(child_FormClosed);
                LoginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
                er.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
