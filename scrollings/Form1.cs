using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrollings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 232, 232);

            toolStripStatusLabel1.Text = "reski text";

            textBox1.PasswordChar = '*';
        }

        private void scroll(object sender, ScrollEventArgs e)
        {
            button1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = hScrollBar2.Value.ToString();
            label3.Text = hScrollBar3.Value.ToString();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            var btn = (Button) sender;

            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("text");
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBorder();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var but = panel1.Controls.OfType<Button>();
            MessageBox.Show(but.Count().ToString());

            var items = checkedListBox1.CheckedItems;

            string str = "";
            foreach (var item in items)
            {
                str += item.ToString();
            }

            MessageBox.Show(str);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("heru");
        }
    }
}
