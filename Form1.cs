using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar : Form
    {
        public static int Year, Month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Month += 1;
            if(Month > 12)
            {
                Month = 1;
                Year += 1;
                showDays(Month, Year);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Month -= 1;
            if (Month > 1)
            {
                Month = 12;
                Year -= 1;
                showDays(Month, Year);
            }

        }

        private void showDays(int month, int year) 
        {
            flowLayoutPanel1.Controls.Clear();
            Year = year;
            Month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            label8.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d")) - 6;

            for(int i = 1; i < week; i++)
            {
                UserControl1Days uc1 = new UserControl1Days(" ");
                flowLayoutPanel1.Controls.Add(uc1);

            }
            for (int i = 1; i < day; i++)
            {
                UserControl1Days uc1 = new UserControl1Days(i + " ");
                flowLayoutPanel1.Controls.Add(uc1);

            }

        }
    }
}
