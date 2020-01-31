using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzinİstasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double D_benzin95 = 0, D_benzin97 = 0, D_dizel = 0, D_eurodizel = 0, D_lpg = 0;
        double E_benzin95 = 0, E_benzin97 = 0, E_dizel = 0, E_eurodizel = 0, E_lpg = 0;

        double F_benzin95 = 0, F_benzin97 = 0, F_dizel = 0, F_eurodizel = 0, F_lpg = 0;
        double S_benzin95 = 0, S_benzin97 = 0, S_dizel = 0, S_eurodizel = 0, S_lpg = 0;
        String[] depobilgileri;
        String[] fiyatbilgileri;
        private void button_satisyap(object sender, EventArgs e)
        {


          

            if (numericUpDown1.Enabled == true)
            {
                S_benzin95 =Convert.ToDouble(numericUpDown1.Value);
                D_benzin95 = D_benzin95 - S_benzin95;
                label33.Text = "" + (S_benzin95 * F_benzin95);


            }
           else if (numericUpDown2.Enabled == true)
            {
                S_benzin97 = Convert.ToDouble(numericUpDown2.Value);
                D_benzin97 = D_benzin97 - S_benzin97;
                label33.Text = "" + (S_benzin97 * F_benzin97);
            }
            else if (numericUpDown3.Enabled == true)
            {
                S_dizel = Convert.ToDouble(numericUpDown3.Value);
                D_dizel = D_dizel - S_dizel;
                label33.Text = "" + (S_dizel * F_dizel);

            }
            else if (numericUpDown4.Enabled == true)
            {
                S_eurodizel = Convert.ToDouble(numericUpDown4.Value);
                D_eurodizel = D_eurodizel - S_eurodizel;
                label33.Text = "" + (S_eurodizel * F_eurodizel);

            }
            else if (numericUpDown5.Enabled == true)
            {
                S_lpg = Convert.ToDouble(numericUpDown5.Value);
                D_lpg = D_lpg - S_lpg;
                label33.Text = "" + (S_lpg * F_lpg);
            }

           

            depobilgileri[0] =Convert.ToString( D_benzin95);
            depobilgileri[1] = Convert.ToString(D_benzin97);
            depobilgileri[2] = Convert.ToString(D_dizel);
            depobilgileri[3] = Convert.ToString(D_eurodizel);
            depobilgileri[4] = Convert.ToString(D_lpg);
            System.IO.File.WriteAllLines(Application.StartupPath + "\\Depo.txt", depobilgileri);

            depooku();
            depoyaz();
            progresguncelle();



        }


        

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // String[] yakitturleri = { "Benzin(95)", "Benzin(97)", "Dizel", "Euro Dizel", "LPG" };
            if (comboBox1.Text == "Benzin(95)")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;



            }
          else  if (comboBox1.Text == "Benzin(97)")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;



            }

            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;

            }
            else if (comboBox1.Text == "Euro Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;

            }

            else if (comboBox1.Text == "LPG")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;

            }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }



        private void fiyat_guncelle(object sender, EventArgs e)
        {
            try
            {
            F_benzin95 = F_benzin95 + F_benzin95*Convert.ToDouble(textBox10.Text)/100;
            fiyatbilgileri[0] = Convert.ToString(F_benzin95);
            }
            catch
            {
                textBox10.Text = "Hata";

            }

            try
            {
                F_benzin97 = F_benzin97 + F_benzin97 * Convert.ToDouble(textBox9.Text) / 100;
                fiyatbilgileri[1] = Convert.ToString(F_benzin97);
            }
            catch
            {
                textBox9.Text = "Hata";

            }

            try
            {
                F_dizel = F_dizel + F_dizel * Convert.ToDouble(textBox8.Text) / 100;
                fiyatbilgileri[2] = Convert.ToString(F_dizel);
            }
            catch
            {
                textBox8.Text = "Hata";

            }

            try
            {
                F_eurodizel = F_eurodizel + F_eurodizel * Convert.ToDouble(textBox7.Text) / 100;
                fiyatbilgileri[3] = Convert.ToString(F_eurodizel);
            }
            catch
            {
                textBox7.Text = "Hata";

            }
            try
            {
                F_lpg = F_lpg + F_lpg * Convert.ToDouble(textBox6.Text) / 100;
                fiyatbilgileri[4] = Convert.ToString(F_lpg);
            }
            catch
            {
                textBox6.Text = "Hata";

            }
            System.IO.File.WriteAllLines(Application.StartupPath + "//Fiyat.txt",fiyatbilgileri);

            fiyatoku();
            fiyatyaz();

        }

        
        private void depo_guncelle(object sender, EventArgs e)
        {
            try
            {
                E_benzin95 = Convert.ToDouble(textBox1.Text);
                if (E_benzin95 + D_benzin95 >= 1000||E_benzin95<0)
                {
                    textBox1.Text = "Hata";

                }
                else 
                {
                    D_benzin95 = D_benzin95 + E_benzin95;
                    depobilgileri[0] = Convert.ToString(D_benzin95);

                }
          
            }
            catch
            {
                textBox1.Text = "Hata";

            }

            try
            {
                E_benzin97 = Convert.ToDouble(textBox2.Text);
                if (E_benzin97 + D_benzin97 >= 1000 || E_benzin97 < 0)
                {
                    textBox2.Text = "Hata";

                }
                else
                {
                    D_benzin97 = D_benzin97 + E_benzin97;
                    depobilgileri[1] = Convert.ToString(D_benzin97);

                }

            }
            catch
            {
                textBox2.Text = "Hata";

            }
            try
            {
                E_dizel = Convert.ToDouble(textBox3.Text);
                if (E_dizel + D_dizel >= 1000 || E_dizel < 0)
                {
                    textBox3.Text = "Hata";

                }
                else
                {
                    D_dizel = D_dizel + E_dizel;
                    depobilgileri[2] = Convert.ToString(D_dizel);

                }

            }
            catch
            {
                textBox3.Text = "Hata";

            }

            try
            {
                E_eurodizel = Convert.ToDouble(textBox4.Text);
                if (E_eurodizel + D_eurodizel >= 1000 || E_eurodizel < 0)
                {
                    textBox4.Text = "Hata";

                }
                else
                {
                    D_eurodizel = D_eurodizel + E_eurodizel;
                    depobilgileri[3] = Convert.ToString(D_eurodizel);

                }

            }
            catch
            {
                textBox4.Text = "Hata";

            }

            try
            {
                E_lpg = Convert.ToDouble(textBox5.Text);
                if (E_lpg + D_lpg >= 1000 || E_lpg < 0)
                {
                    textBox5.Text = "Hata";

                }
                else
                {
                    D_lpg = D_lpg + E_lpg;
                    depobilgileri[4] = Convert.ToString(D_lpg);

                }

            }
            catch
            {
                textBox5.Text = "Hata";

            }
            System.IO.File.WriteAllLines(Application.StartupPath + "//Depo.txt",depobilgileri);
            depooku();
            depoyaz();
            progresguncelle();
           



        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;
            String[] yakitturleri = { "Benzin(95)", "Benzin(97)", "Dizel", "Euro Dizel", "LPG" };
            comboBox1.Items.AddRange(yakitturleri);

            


            numericUpDown1.ReadOnly=true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

        
           

            
            depooku();
            depoyaz();
            fiyatoku();
            fiyatyaz();

            progresguncelle();
            numericUpDown1.Maximum = Convert.ToDecimal(D_benzin95);
            numericUpDown2.Maximum = Convert.ToDecimal(D_benzin97);
            numericUpDown3.Maximum = Convert.ToDecimal(D_dizel);
            numericUpDown4.Maximum = Convert.ToDecimal(D_eurodizel);
            numericUpDown5.Maximum = Convert.ToDecimal(D_lpg);





        }
        public void depooku()
        {
            depobilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Depo.txt");
            D_benzin95 = Convert.ToDouble(depobilgileri[0]);
            D_benzin97 = Convert.ToDouble(depobilgileri[1]);
            D_dizel= Convert.ToDouble(depobilgileri[2]);
            D_eurodizel = Convert.ToDouble(depobilgileri[3]);
            D_lpg = Convert.ToDouble(depobilgileri[4]);
        }
        public void depoyaz()
        {
            label6.Text = "" + D_benzin95;
            label7.Text = "" + D_benzin97;
            label8.Text = "" + D_dizel;
            label9.Text = "" + D_eurodizel;
            label10.Text = "" + D_lpg;


        }
        public void progresguncelle()
        {
            progressBar1.Value = Convert.ToInt16(D_benzin95);
            progressBar2.Value = Convert.ToInt16(D_benzin97);
            progressBar3.Value = Convert.ToInt16(D_dizel);
            progressBar4.Value = Convert.ToInt16(D_eurodizel);
            progressBar5.Value= Convert.ToInt16(D_lpg);


        }
        public void fiyatoku()
        {
            fiyatbilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Fiyat.txt");
            F_benzin95 = Convert.ToDouble(fiyatbilgileri[0]);
            F_benzin97 = Convert.ToDouble(fiyatbilgileri[1]);
            F_dizel = Convert.ToDouble(fiyatbilgileri[2]);
            F_eurodizel= Convert.ToDouble(fiyatbilgileri[3]);
            F_lpg = Convert.ToDouble(fiyatbilgileri[4]);


        }
        public void fiyatyaz()
        {
            label21.Text = "" + F_benzin95;
            label20.Text = "" + F_benzin97;
            label19.Text = "" + F_dizel;
            label18.Text = "" + F_eurodizel;
            label17.Text = "" + F_lpg;


        }






    }


}
