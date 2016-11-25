using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            double ScoreA, ScoreB, c1 = 1, c2 = 1, c3 = 1, result = 0, i, j, k, n;
            ScoreA = Convert.ToInt64(Txt1.Text);
            ScoreB = Convert.ToInt64(Txt2.Text);

            if ((ScoreA == 25 && ScoreB < 24) || (ScoreB == 25 && ScoreA < 24))
            {
                if (ScoreA < ScoreB)
                {
                    n = ScoreA;
                }
                else
                {
                    n = ScoreB;
                }
                for (i = (24 + n); i > 0; i--)
                {
                    c1 *= i;
                }
                for (j = ((24 + n) - n); j > 0; j--)
                {
                    c2 *= j;
                }
                for (k = n; k > 0; k--)
                {
                    c3 *= k;
                }
                result = c1 / (c2 * c3);
                TxtHasil.Text = Convert.ToString(result);
            }
            else if (ScoreA < 0 || ScoreB < 0 || Math.Abs(ScoreA-ScoreB)>1)
            {
                result = 0;
                TxtHasil.Text = Convert.ToString(result);
            }
            else if (ScoreA == 24 && ScoreB == 24)
            {
                MessageBox.Show("JUICE!!!");
                MessageBox.Show("The teams continue to play until the absolute difference between the scores is 2.");
            }
            else
            {
                MessageBox.Show("The teams continue to play until the absolute difference between the scores is 2.");
            }
            if (TxtHasil.Text=="0")
            {
                if(ScoreA>ScoreB)
                {
                    MessageBox.Show("The winner is: A");
                }
                else
                {
                    MessageBox.Show("The winner is: B");
                }
            }
            else if (result > 1000000007)
            {
                result %= 1000000007;
                TxtHasil.Text = Convert.ToString(result);
            }
        }
    }
}
