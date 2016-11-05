using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(comboBox1.SelectedItem), richTextBox1.Font.Style);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox2.SelectedItem.ToString(), richTextBox1.SelectionFont.SizeInPoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
            richTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
            richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();
            if (warna == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        public void checkFontStyle()
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Regular);
            if (button1.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.Font.Style | FontStyle.Bold);
            }
            if (button2.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.Font.Style | FontStyle.Italic);
            }
            if (button3.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.Font.Style | FontStyle.Underline);
            }

        }

        public void checkButtonStyle(Button btn)
        {
            if (btn.FlatStyle == FlatStyle.Standard)
            {
                btn.FlatStyle = FlatStyle.Popup;
                checkFontStyle();
            }
            else
            {
                btn.FlatStyle = FlatStyle.Standard;
                checkFontStyle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("22");
            comboBox1.Items.Add("24");
            comboBox1.Items.Add("26");
            comboBox1.Items.Add("28");
            comboBox1.Items.Add("36");
            comboBox1.Items.Add("48");
            comboBox1.Items.Add("72");
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox2.Items.Add(font.Name.ToString());
            }
        }
    }
}
