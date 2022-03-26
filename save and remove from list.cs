using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace save_and_remove_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct student
        {
           public int id;
           public string name;
        };

        public List<student> studentList = new List<student>();

        private void button1_Click(object sender, EventArgs e)
        {
            student s;
            s.id = Int32.Parse(textBox1.Text);
            s.name = textBox2.Text;
            studentList.Add(s);
            textBox1.Clear();
            textBox2.Clear();// to clear textbox and write another 
                             //lthing without delete first thing
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";// to update list "empty"
            foreach (student i in studentList) //<--مش عارفة عدد العناصر الي داخله في الليست
            {
                richTextBox1.Text += "ID=" + i.id + "\t name=" + i.name + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (textBox1.Text == "")// لو هو فاضي طلع لي MesBox 
                                    //تقول دخلي الid
            {
                MessageBox.Show("Write the ID of the student");
            }
            else
            {
                foreach (student i in studentList)
                {
                    if (Int32.Parse(textBox1.Text) == i.id)
                    {
                        MessageBox.Show("found at index" + studentList.IndexOf(i) + "\t name =" + i.name);
                        flag = true;
                    }
                    if (!flag && textBox1.Text != "")
                    {
                        MessageBox.Show("not found");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sv = new StreamWriter("E:\\students.txt");
            foreach(student i in studentList )
            {
                sv.WriteLine("ID="+i.id+"\t name="+i.name);
            }
            sv.Close();
            MessageBox.Show("Done", "Save", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (student s in studentList)
            {
                if(s.name==textBox2.Text)
                {
                    studentList.RemoveAt(studentList.IndexOf(s));
                    break;
                        
                }
            }
            button2_Click(sender, e);
        }
    }
}
    
