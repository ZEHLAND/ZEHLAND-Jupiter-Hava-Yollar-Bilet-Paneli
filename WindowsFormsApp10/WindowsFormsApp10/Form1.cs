using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTA : "+comboBox1.Text+"-"+comboBox2.Text+" Tarih :"+dateTimePicker1.Text+" Saat :" + maskedTextBox1.Text+" Yolcu Bilgileri~ AD-SOYAD :"+textBox1.Text+" TC :"+maskedTextBox4.Text+" Telefon :"+maskedTextBox3.Text);
            MessageBox.Show("YOLCU KAYDI YAPILDI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text=comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;

        }
    }
}
