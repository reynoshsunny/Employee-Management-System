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
    public partial class WorkReport : Form
    {

        SqlConnection er = ConnectDb.Connect_Db();
        
        public WorkReport()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            string query = " SELECT WORK_DATE, WORK_NAME, WORK_DESCRIPTION, WORK_TIME, TYPE, COMPLETED FROM WORKDET WHERE ID_USER = "+ Global._userid  + " AND  WORK_DATE BETWEEN '" + WorkDate1.ToString("yyyy-MM-dd") + "' AND '" + WorkDate2.ToString("yyyy-MM-dd") + "' ";

            SqlCommand cmd = new SqlCommand(query, er);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            er.Close();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
