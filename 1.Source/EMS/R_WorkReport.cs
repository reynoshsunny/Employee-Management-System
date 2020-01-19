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
    public partial class R_WorkReport : Form
    {
        SqlConnection er = ConnectDb.Connect_Db();
        public R_WorkReport()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
        private void refreshdata()
        {
            er.Open();

            DateTime WorkDate1 = dateTimePicker1.Value;
            DateTime WorkDate2 = dateTimePicker2.Value;
            string query = " SELECT A.WORK_DATE, A.WORK_NAME, A.WORK_DESCRIPTION, A.WORK_TIME, A.TYPE, A.COMPLETED, B.USER_NAME, A.ENTERD_ON FROM WORKDET A INNER JOIN  M_USERS B ON A.ID_USER = B.ID_USER WHERE  WORK_DATE BETWEEN '" + WorkDate1.ToString("yyyy-MM-dd") + "' AND '" + WorkDate2.ToString("yyyy-MM-dd") + "' ORDER BY A.TYPE";

            SqlCommand cmd = new SqlCommand(query, er);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            er.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
