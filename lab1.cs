using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                int x = Int32.Parse(textBox1.Text);

                int y = Int32.Parse(textBox2.Text);
                MessageBox.Show((x + y).ToString());
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);

            int y = Int32.Parse(textBox2.Text);
            MessageBox.Show((x - y).ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);

            int y = Int32.Parse(textBox2.Text);
            MessageBox.Show((x * y).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            
            {
                int x = Int32.Parse(textBox1.Text);

                int y = Int32.Parse(textBox2.Text);
                MessageBox.Show(
                    (x / y).ToString());
            }
            

        }
    }
}
