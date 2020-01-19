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
    public partial class DailyMarketing : Form
    {
        public DailyMarketing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection er = ConnectDb.Connect_Db();
            er.Open();
            DateTime WorkDate = work_Date.Value;
            string WorkName = txtWorkName.Text;
            string WorkDescription = txtWorkDescription.Text;
            string WorkTime = txt_Time.Text;
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string query = "INSERT INTO WORKDET VALUES ( " + Global._userid + " , '" + WorkDate.ToString("yyyy-MM-dd") + "' , '" + WorkName + "' , '" + WorkDescription + "' , '" + WorkTime + "' , 'MARKETING', '" + DateTime.Now + "' , '" + item + "') ";

            SqlCommand cmd = new SqlCommand(query, er);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Daily marketing work added successfully !");

            work_Date.Text = null;
            txtWorkName.Text = null;
            txtWorkDescription.Text = null;
            txt_Time.Text = null;


        }

        private void button2_Click(object sender, EventArgs e)
        {            
            work_Date.Text = null;
            txtWorkName.Text = null;
            txtWorkDescription.Text = null;
            txt_Time.Text = null;

        }

        private void DailyMarketing_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            SqlConnection er = ConnectDb.Connect_Db();
            er.Open();
            string query = "SELECT DISTINCT WORK_NAME FROM WORKDET";
            SqlCommand cmd = new SqlCommand(query, er);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtWorkName.AutoCompleteCustomSource = MyCollection;
            er.Close();
        }

        private void work_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtWorkName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtWorkDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txt_Time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
