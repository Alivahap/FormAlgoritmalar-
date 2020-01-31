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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad = "", tc = "", cinsiyet = "", mezuniyet = "", BildigiDiller = "", UzmanlıkAlanı = "";
            tc = textBox1.Text;
            ad = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {

                cinsiyet = radioButton2.Text;
            }

            if (radioButton3.Checked==true)
            {
                mezuniyet = radioButton3.Text;
            }
            else if (radioButton4.Checked==true)
            {
                mezuniyet = radioButton4.Text;
            }
            else if (radioButton5.Checked==true)
            {
                mezuniyet = radioButton5.Text;
            }
            else if (radioButton6.Checked==true)
            {
                mezuniyet = radioButton6.Text;
            }

            if (checkBox1.Checked==true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                BildigiDiller = BildigiDiller + "," + checkBox6.Text;
            }
            BildigiDiller = BildigiDiller.Substring(1);

            if (checkBox7.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox7.Text;

            }

            if (checkBox8.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox8.Text;

            }
            if (checkBox9.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox9.Text;

            }

            if (checkBox10.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox10.Text;

            }
            if (checkBox11.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox11.Text;

            }

            if (checkBox12.Checked == true)
            {
                UzmanlıkAlanı = UzmanlıkAlanı + "," + checkBox12.Text;

            }
            UzmanlıkAlanı = UzmanlıkAlanı.Substring(1);

            listBox1.Items.Add("AD Soyad " + ad + "Tc no " +tc+ "Mezuniyeti " + mezuniyet +
                "cinsiyeti " + cinsiyet + "bildiği diller " + BildigiDiller
                + "uzmanlık alanı  " + UzmanlıkAlanı);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
