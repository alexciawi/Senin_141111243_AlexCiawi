using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void function()
        {
            label4.Text = "0";
            label6.Text = "0";
            int x = hScrollBar1.Value;
            int y = hScrollBar2.Value;
            int max, min;
            if (x < y)
            {
                label4.Text = x.ToString();
                label6.Text = y.ToString();
                max = y;
                min = x;
            }
            else
            {
                label4.Text = y.ToString();
                label6.Text = x.ToString();
                max = x;
                min = y;
            }
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(max);
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-min);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 100 + hScrollBar1.LargeChange - 1;
            label1.Text = hScrollBar1.Value.ToString();
            function();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar2.Maximum = 100 + hScrollBar2.LargeChange - 1;
            label2.Text = hScrollBar2.Value.ToString();
            function();
        }
    }
}
