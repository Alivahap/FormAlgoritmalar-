using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _173311008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }
      

     

        String islem(String op, params double[] p)
        {
            double sonuc = 0;
            switch (op) {
                case "+":
                    for(int i = 0; i < p.Length; i++)
                    {
                        sonuc += p[i];

                    }

                    break;
                case "-":
                    for (int i = 0; i < p.Length; i++)
                    {
                        sonuc -= p[i];

                    }

                    break;

                case "*":
                    for (int i = 0; i < p.Length; i++)
                    {
                        sonuc *= p[i];

                    }

                    break;
                case "/":
                    for (int i = 0; i < p.Length; i++)
                    {
                        sonuc /= p[i];

                    }

                    break;

            }

            return ""+sonuc;
        }

        

        private void button_hesapla(object sender, EventArgs e)
        {
            var r = (Button)sender;
            textBox1.Text += r.Text;


            string[] p= {""};
            double[] d_p= { };
            String sonuc = "";
            





            if (r.Text == "+")
            {


                p = textBox1.Text.Split('+');


                


            }



          if (r.Text == "-")
            {

                p = textBox1.Text.Split('-');

               



            }
            if (r.Text == "*")
            {
                p = textBox1.Text.Split('*');
              


            }

            if (r.Text == "/")
            {
                p = textBox1.Text.Split('/');


            }
            

            if (r.Text == "=")
            {

                p = textBox1.Text.Split('+');
                d_p = new double[p.Length];
                

                for (int i = 0; i < p.Length; i++)
                {
                    d_p[i] = double.Parse(p[i]);


                    //buraya kadar gelebildim, bu sorunu çözemedim 


                }
                sonuc = islem(r.Text, d_p);



                textBox1.Text = sonuc;


            }


           


        }
    }
     
   



    }


