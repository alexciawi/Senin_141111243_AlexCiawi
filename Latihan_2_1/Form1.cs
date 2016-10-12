using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime start = new DateTime(2016, 1, 1);
            DateTime end = new DateTime(2016, 12, 31);
            while (start <= end)
            {
                if(start.DayOfWeek==DayOfWeek.Saturday || 
                    start.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(start);
                }
                start = start.AddDays(1);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex == 2)
            {
                numericUpDown1.Maximum = 29;
            }
            else if(domainUpDown1.SelectedIndex==0 || 
                domainUpDown1.SelectedIndex == 4 || 
                domainUpDown1.SelectedIndex == 6 || 
                domainUpDown1.SelectedIndex == 8 || 
                domainUpDown1.SelectedIndex == 10 || 
                domainUpDown1.SelectedIndex == 12 || 
                domainUpDown1.SelectedIndex == 13)
            {
                numericUpDown1.Maximum = 31;
            }
            else
            {
                numericUpDown1.Maximum = 30;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime birthday = new DateTime(2016, 3, 29);
            monthCalendar1.AddAnnuallyBoldedDate(birthday);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value));
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value));
            monthCalendar1.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }

        private void mesbox(object sender, DateRangeEventArgs e)
        {
            DateTime birthday = new DateTime(2016, 3, 29);
            if (monthCalendar1.SelectionStart.DayOfWeek==DayOfWeek.Sunday || monthCalendar1.SelectionStart.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Holiday!!!");
            }
            else if (monthCalendar1.SelectionStart.Date==birthday)
            {
                MessageBox.Show("Alex's Birthday!!!");
            }
        }
    }
}
