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
    public partial class DashBoard : Form
    {  
        public DashBoard()
        {
            InitializeComponent();
        

        }

        private void dEVELOPINGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
            Daily_Developing DevelopForm = new Daily_Developing();
            DevelopForm.MdiParent = this;
            DevelopForm.Show();

        }

        private void mARKETINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyMarketing Marketing = new DailyMarketing();
            Marketing.MdiParent = this;
            Marketing.Show();
        }

        private void dIGITALMARKETINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyDigital DigitalForm = new DailyDigital();
            DigitalForm.MdiParent = this;
            DigitalForm.Show();
        }

        private void oFFICEWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyOffice OfficeForm = new DailyOffice();
            OfficeForm.MdiParent = this;
            OfficeForm.Show();
        }

        private void wORKREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkReport WorkReport = new WorkReport();
            WorkReport.MdiParent = this;
            WorkReport.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {      
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            if (Global._userrole != "ADMIN") {

                adminMenu.Visible = false;

            }
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword ChngPassword = new ChangePassword();
            ChngPassword.MdiParent = this;
            ChngPassword.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void wORKREPORTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            R_WorkReport REPORT = new R_WorkReport();
            REPORT.MdiParent = this;
            REPORT.Show();
        }

        private void sENDMESSAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessage Messages = new SendMessage();
            Messages.MdiParent = this;
            Messages.Show();

        }
    }
}
