using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_random(object sender, EventArgs e)
        {
            int alt = Convert.ToInt16(numericUpDown1.Value);
            int ust = Convert.ToInt16(numericUpDown2.Value);
            if (ust - alt < 20)
                return;
            bool cntrl;
            //hata 1 random dizisini döngünün yukarısında tanımlamak gerekir
            int[] dizi = new int[20];
            Random rn = new Random();

            for (int i = 1; i <= 20; i++)
            {

                cntrl = false;

                int temp = -1;

                do
                {
                    temp = rn.Next(alt, ust);//temp do nun içinde olması gerekir aksi taktirde değer üretemez

                    cntrl = false;
                    for (int j = 0; j < i; j++) {
                        if (temp == dizi[j])
                        {
                            cntrl = true;
                            break;
                        }

                    }


                } while (cntrl == true);

                dizi[i - 1] = temp;
                Button bt = (Button)this.Controls["Button" + i];//buttton tanımlası yapmayı unuttun
                bt.BackColor = Color.Yellow;
                bt.Text = temp.ToString();
                


            }







        }

        private void button20_Click(object sender, EventArgs e)
        {
            kontrol((Button)sender);
        }


        public void kontrol(Button bt)
        {
            if (Convert.ToInt16(bt.Text) % 2 == 1) return;
            bt.BackColor = Color.White;

            int id = Convert.ToInt16(bt.Name.Substring(6));
            Button[] komsu = new Button[4];
            komsu[0] = id > 5 ? (Button)this.Controls["button" + (id - 5)] : null;
            komsu[1] = id < 16 ? (Button)this.Controls["button" + (id + 5)] : null;
            komsu[2] = id % 5 != 1 ? (Button)this.Controls["button" + (id - 1)] : null;
            komsu[3] = id % 5 != 0 ? (Button)this.Controls["button" + (id + 1)] : null;

            for(int i = 0; i < komsu.Length; i++)
            {
                if (komsu[i]!=null &&komsu[i].BackColor!=Color.White )
                {
                    kontrol(komsu[i]);
                }


            }









        } 
    }
}
