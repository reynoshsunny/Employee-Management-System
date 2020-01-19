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
    public partial class SendMessage : Form
    {
        SqlConnection er = ConnectDb.Connect_Db();
        public SendMessage()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        protected void FillCombobox()
        {
            er.Open();                                          
            DataSet ds = new DataSet();
            try
            {
               
                string query = "SELECT USER_NAME, ID_USER FROM M_USERS WHERE ACTIVE = 'Y' UNION SELECT  'A.ALL' AS USER_NAME, 0 AS ID_USER ORDER BY USER_NAME";
                SqlCommand cmd = new SqlCommand(query, er);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;              
                da.Fill(ds);               
                comboBox1.DisplayMember = "USER_NAME";
                comboBox1.ValueMember = "ID_USER";
                comboBox1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                er.Close();             
            }
        }

    }
}
