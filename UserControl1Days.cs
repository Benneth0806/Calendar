using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControl1Days : UserControl
    {
        string day, date, weekdays;
        public UserControl1Days(string day)
        {
            InitializeComponent();
            day = day.ToLower();
            label1.Text = day;
            checkBox1.Hide();
            date =  Calendar.Month + "/" + day + "/" + Calendar.Year;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                checkBox1 .Checked = false;
                this.BackColor = Color.White;
            }
        }

        public void sundays() 
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekdays = day.ToString("ddd");
                if(weekdays == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }

            }
            catch(Exception) 
            {
                 
            }
        
        }

      
        private void UserControl1Days_Load(object sender, EventArgs e)
        {

        }
    }
}
