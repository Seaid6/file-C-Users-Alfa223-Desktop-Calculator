using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

       private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
  
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            string[] a = new string[] { "Samer", "Ziad" };
            foreach(string i in a)
            {
                comboBox1.Items.Add(i);
                

            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Samer")
            {
                comboBox2.Items.Add("Age: 20");
                comboBox2.Items.Add("City: Byhera");
                comboBox2.Items.Add("Faculty: KFSU");
            }
            else if (comboBox1.SelectedItem.ToString() == "Ziad")
            {
                comboBox2.Items.Add("Age: 18");
                comboBox2.Items.Add("City: Byhera");
                comboBox2.Items.Add("Faculty: Damanhour");
            }
        }

    }
}
