using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upgB
{
    public partial class Form1 : Form
    {
        //List of customers
        List<Customer> kunder = new List<Customer>();


        public Form1()
        {
            InitializeComponent();

            //Labels & Buttons
            label1.Text = "Förnamn";
            label2.Text = "Efternamn";
            label3.Text = "Telefonnummer";
            label4.Text = "Stad";
            label5.Text = "Sortera";

            button1.Text = "Spara";
            button2.Text = "Förnamn";
            button3.Text = "Efternamn";
            button4.Text = "Stad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kunder.Add(new Customer()
            {
                Fnamn = textBox1.Text,
                Enamn = textBox2.Text,
                Tel = textBox3.Text,
                Stad = textBox4.Text
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sort Fnamn
            listBox1.Items.Clear();
            foreach (Customer k in kunder.OrderBy(q=>q.Fnamn))
            {
                listBox1.Items.Add(string.Format("{0} {1}, {2}, {3}",k.Fnamn, k.Enamn, k.Tel, k.Stad));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sort Enamn
            listBox1.Items.Clear();
            foreach (Customer k in kunder.OrderBy(q => q.Enamn))
            {
                listBox1.Items.Add(string.Format("{0} {1}, {2}, {3}", k.Fnamn, k.Enamn, k.Tel, k.Stad));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //sort Stad
            listBox1.Items.Clear();
            foreach (Customer k in kunder.OrderBy(q => q.Stad))
            {
                listBox1.Items.Add(string.Format("{0} {1}, {2}, {3}", k.Fnamn, k.Enamn, k.Tel, k.Stad));
            }
        }
    }
}
