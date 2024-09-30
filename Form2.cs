using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaStudent
{
    public partial class Form2 : Form

    {
        public TextBox TB; 
        private Form2 Student1;
        private string text1;
        private string text2;
        private string text3;
        private string text4;

        public Form2 Student11 { get => Student1; set => Student1 = value; }

        public Form2()
        {

            InitializeComponent();
        }

        public Form2(string text1, string text2, string text3, string text4)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Student1 = new Form2(Ime.Text, Prezime.Text, indeks.Text, date.Text);

           this.DialogResult = DialogResult.OK;
           this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
