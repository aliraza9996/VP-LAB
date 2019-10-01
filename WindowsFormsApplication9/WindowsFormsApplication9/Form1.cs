using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //OpenFileDialog f = new OpenFileDialog();
        string filedata = "";
        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                string file = openFileDialog1.FileName;
                try
                {
                    filedata = File.ReadAllText(file);
                    MessageBox.Show("Reading file");

                }
                catch (IOException)
                {
                    MessageBox.Show("Invalid");
                }
            } 
       }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < filedata.Length; i++)
            {
                if (filedata[i] == 'A' || filedata[i] == 'E' || filedata[i] == 'I' || filedata[i] == 'O' || filedata[i] == 'U' || filedata[i] == 'a' || filedata[i] == 'e' || filedata[i] == 'i' || filedata[i] == 'o' || filedata[i] == 'u')
                {
                    count++;
                }
            }
            MessageBox.Show("Vowels : " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 1;
            for (int i = 0; i < filedata.Length; i++)
            {
                if (filedata[i] == '\n')
                {
                    count++;
                }
            }
            MessageBox.Show("Lines : " + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             int count = 0;
            for (int i = 0; i < filedata.Length; i++)
            {
                if((filedata[i]>='A' && filedata[i] <='Z') || ((filedata[i])>='a' && filedata[i] <='z'))
                {
                    count++;
                }
            }
            MessageBox.Show("Alphabets : " + count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < filedata.Length; i++)
            {
                if (filedata[i] == ',' || filedata[i] == '.' || filedata[i] == '*' || filedata[i] == '`' || filedata[i] == '~' || filedata[i] == '!' || filedata[i] == '@' || filedata[i] == '#' || filedata[i] == '$' || filedata[i] == '%' || filedata[i] == '^' || filedata[i] == '&' || filedata[i] == '(' || filedata[i] == ')' || filedata[i] == '-' || filedata[i] == '_' || filedata[i] == '+' || filedata[i] == '=' || filedata[i] == '/' || filedata[i] == '?')
                {
                    count++;
                }
            }
            MessageBox.Show("Special Characters : " + count);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = 1;
            for (int i = 0; i < filedata.Length; i++)
            {
                if (filedata[i] == ' ')
                {
                    count++;
                }
            }
            MessageBox.Show("Words : " + count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Size : " + filedata.Length);
        }
    }
}
