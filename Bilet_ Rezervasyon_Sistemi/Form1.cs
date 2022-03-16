using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet__Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçuş Bilgileri: " + "Rota: " + comboBox1.Text + " - " + comboBox2.Text + " " + "Tarih - Saat: " + dateTimePicker1.Text + " " + maskedTextBox1.Text
            + " ///" + " Yolcu Bilgileri: " + "Adı Soyadı: " + textBox1.Text + " " + "T.C: " + textBox2.Text + " " + "Telefon: " + maskedTextBox2.Text

            );ssss
            dateTimePicker1.ResetText();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
