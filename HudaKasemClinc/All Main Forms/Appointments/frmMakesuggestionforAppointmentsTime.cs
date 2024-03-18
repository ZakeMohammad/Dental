using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmMakesuggestionforAppointmentsTime : Form
    {
        public frmMakesuggestionforAppointmentsTime(Dictionary<int,int>allintervalinthisday,string pm)
        {
            InitializeComponent();
           
            AllIntervalInThisDay = allintervalinthisday;
            PM = pm;
        }
        public delegate void DataBackEventhandler(object sender, int[] ValidStartAndEndHour);

        public event DataBackEventhandler BackData;

        string PM;
        int Secound = 0;

        Dictionary<int,int>AllIntervalInThisDay = new Dictionary<int,int>();

     

        int[] Ruslt=new int[2];

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
        private void frmMakesuggestionforAppointmentsTime_Load(object sender, EventArgs e)
        {
           timer1.Enabled = true;
            lblPMOrAM.Text = PM;
            FillAllSuggestions(AllIntervalInThisDay);
        }
        static bool PeriodsIntersect(int startAdmin, int endAdmin,Dictionary<int,int>intervales)
        {
            int Ruslt = 0;

            foreach (KeyValuePair<int, int> author in intervales)
            {
                if (startAdmin <= author.Value && author.Key <= endAdmin)
                  Ruslt++;
                
            }
            return (Ruslt==0);
        }
        public void FillAllSuggestions(Dictionary<int,int>intervales)
        {

            for (int i = 1; i < 13; i++)
            {
                if (PeriodsIntersect(i, i + 1, intervales))
                {
                   lblStartHour1.Text = i.ToString();
                   lblEndHour1.Text = (i + 1).ToString();
                   break;
                }
            }
        }


        private void btnChoose1_Click(object sender, EventArgs e)
        {
            Ruslt[0] = Convert.ToInt32(lblStartHour1.Text);
            Ruslt[1]= Convert.ToInt32(lblEndHour1.Text);
            BackData?.Invoke(this, Ruslt);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Secound++;

            if(Secound>2)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                guna2ProgressIndicator1.Visible = false;
                label3.Visible = false;
                guna2Panel1.Visible = true;
                timer1.Enabled = false;
            }
          
        }
    }
}
