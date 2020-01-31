using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilköğretimuygulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }
        int list1;
        int list2;
        int list3;

        private void button1_Click(object sender, EventArgs e)
        {


            //  listBox1.Items.Insert(0, "a ");
            //listBox1.Items.Insert(1, "b");
            list1 = (int)numericUpDown1.Value;
            list2 = (int)numericUpDown2.Value;
            list3 = (int)numericUpDown3.Value;
            if (textBox1.Text.Length== (list1 + list2 + list3))
            {

                timer1.Interval = (int)numericUpDown4.Value;
                timer1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Lütfen textbox'ın değerini doğru doldurunuz");

            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            list1 = (int)numericUpDown1.Value;
            list2 = (int)numericUpDown2.Value;
            list3 = (int)numericUpDown3.Value;
            if (radioButton1.Checked == true)
            {
                if (list1 + list2 + list3 >= text.Length)
                {
                    if (list1 >= text.Length)
                    {
                        for (int i = 0; i < list1; i++)
                        {
                            listBox1.Items.Insert(i, text.Substring(i, 1));
                            //  listBox1.Items.Insert(i, text.Substring(list1 - i - 1, 1));
                        }

                    }

                    else if (list1 + list2 >= text.Length)
                    {
                        int j = 0;
                        for (int i = 0; i < list1; i++)
                        {

                            //listBox1.Items.Insert(i, text.Substring(list1 - j - 1, 1));
                            listBox1.Items.Insert(i, text.Substring(j, 1));
                            j = j + 1;
                        }

                        for (int i = 0; i < list2; i++)
                        {

                            listBox2.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }



                    }
                    else if (list1 + list2 + list3 >= text.Length)
                    {
                        int j = 0;
                        for (int i = 0; i < list1; i++)
                        {

                            //listBox1.Items.Insert(i, text.Substring(list1 - j - 1, 1));
                            listBox1.Items.Insert(i, text.Substring(j, 1));
                            j = j + 1;
                        }

                        for (int i = 0; i < list2; i++)
                        {

                            listBox2.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }

                        for (int i = 0; i < list3; i++)
                        {

                            listBox3.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }

                    }

                }

                else
                {
                    

                }

            }


            if (radioButton2.Checked == true)
            {
                if (list1 + list2 + list3 >= text.Length)
                {
                    if (list3 >= text.Length)
                    {
                        for (int i = 0; i < list1; i++)
                        {
                            try
                            {
                                listBox3.Items.Insert(i, text.Substring(i, 1));
                            }
                            catch
                            {
                                MessageBox.Show("listboxu boş girmeyin");
                            }
                            

                        }

                    }

                    else if (list3 + list2 >= text.Length)
                    {
                        int j = 0;
                        for (int i = 0; i < list3; i++)
                        {

                            //listBox1.Items.Insert(i, text.Substring(list1 - j - 1, 1));
                            listBox3.Items.Insert(i, text.Substring(j, 1));
                            j = j + 1;
                        }

                        for (int i = 0; i < list2; i++)
                        {

                            listBox2.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }



                    }
                    else if (list1 + list2 + list3 >= text.Length)
                    {
                        int j = 0;
                        for (int i = 0; i < list3; i++)
                        {

                            //listBox1.Items.Insert(i, text.Substring(list1 - j - 1, 1));
                            listBox3.Items.Insert(i, text.Substring(j, 1));
                            j = j + 1;
                        }

                        for (int i = 0; i < list2; i++)
                        {

                            listBox2.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }

                        for (int i = 0; i < list1; i++)
                        {

                            listBox1.Items.Insert(i, text.Substring(j, 1));
                            j++;
                        }





                    }





                }



               

            }
          


            textBox1.Text = "";


            timer1.Enabled = false;


        }

    }
}
