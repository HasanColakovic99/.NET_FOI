using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kk
{
    public partial class Form1 : Form
    {
        public bool isX = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new FieldAccessException("fenomenalna greška");
        }

        private void t1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    throw new IgraException("Morate unijeti imena igrača!");
                }
                if (((TextBox)sender).Text != "")
                {
                    MessageBox.Show("Ovo polje je već igrano");
                    return;
                }
                if (isX)
                {
                    ((TextBox)sender).Text = "X";
                    label3.Text = "Igra " + textBox2.Text;
                }
                else
                {
                    ((TextBox)sender).Text = "O";
                    label3.Text = "Igra " + textBox1.Text;
                }
                isX = !isX;
                check();
            }
            catch (IgraException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            label3.Text = "Igra " + textBox1.Text;
            cleanAll();
        }
        private void check()
        {
            if (t1.Text + t2.Text + t3.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t1.Text + t2.Text + t3.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t1.Text + t5.Text + t9.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t1.Text + t5.Text + t9.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t4.Text + t5.Text + t6.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t4.Text + t5.Text + t6.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t7.Text + t8.Text + t9.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t7.Text + t8.Text + t9.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t1.Text + t4.Text + t7.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t1.Text + t4.Text + t7.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t2.Text + t5.Text + t8.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t2.Text + t5.Text + t8.Text == "O0O")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t3.Text + t6.Text + t9.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t3.Text + t6.Text + t9.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
            if (t3.Text + t5.Text + t7.Text == "XXX")
            {
                MessageBox.Show("Pobjedio je " + textBox1.Text);
            }
            if (t3.Text + t5.Text + t7.Text == "OOO")
            {
                MessageBox.Show("Pobjedio je " + textBox2.Text);
            }
        }
        private void cleanAll()
        {
            foreach (var item in panel1.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            isX = true;
        }
    }
}
