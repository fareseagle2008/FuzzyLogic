using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic_Poprawiona
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timerTemperatury.Start();
            labelTempWnetrze.Text = Randomizer.GetRandomNumber(5, 30).ToString("#.00");
            labelTempDwor.Text = Randomizer.GetRandomNumber(-20, 40).ToString("#.00");
            
        }


       
        private void timerTemperatury_Tick(object sender, EventArgs e)
        {
            
            ZmianaPoryDnia(czas);
            ++czas;
            if (czas == 37) czas = 0;
            Logika logika = new Logika(Convert.ToDouble(labelTempWnetrze.Text), Convert.ToDouble(labelTempDwor.Text));
            logika.Reguly();
            logika.OdswiezImg(pictureBoxKlima, pictureBoxPiecyk,pictureBox1,labelTempWnetrze);
            labelTempWnetrze.Text = (Convert.ToDouble(labelTempWnetrze.Text) + logika.OdswiezTempPokoju()).ToString("#.00");
            
            
        }


        public static bool oknoOtwarte = false;
        private void pictureBoxOkno_Click(object sender, EventArgs e)
        {
            if(!oknoOtwarte)
            {
                pictureBoxOkno.Image = Properties.Resources.okno_open;
                pictureBoxOkno.Invalidate();
                oknoOtwarte = true;
            }
            else
            {
                pictureBoxOkno.Image = Properties.Resources.okno_close;
                pictureBoxOkno.Invalidate();
                oknoOtwarte = false;
            }
        }

        int czas = 0;
        private void ZmianaPoryDnia(int czas)
        {

            
            if (czas <= 20)
             {
               pictureBoxPoraDnia.Image = Properties.Resources.dzien;
               pictureBoxPoraDnia.Invalidate();
             }
            else
            {
                pictureBoxPoraDnia.Image = Properties.Resources.noc;
                pictureBoxPoraDnia.Invalidate();
            }
        }

        private void buttonNewRandom_Click(object sender, EventArgs e)
        {
            FormaRandomizujaca forma = new FormaRandomizujaca();
            forma.ShowDialog();
            if(forma.DialogResult == DialogResult.OK)
            {
                try
                {
                    forma.NowyRandom(labelTempWnetrze, labelTempDwor);
                }
                catch(Exception ex)
                {
                    if(forma.minRandomek.Text == "")
                       MessageBox.Show("Pole temperatura minimalna jest puste");
                    else if (forma.maxRandomek.Text == "")
                       MessageBox.Show("Pole temperatura maksymalna jest puste");
                    else
                        MessageBox.Show("Error");
                    forma.ShowDialog();

                }
            }
            
        }

        
    }
}
