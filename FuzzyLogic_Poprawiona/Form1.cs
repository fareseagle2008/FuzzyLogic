using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;


using System.Windows.Forms;

namespace FuzzyLogic_Poprawiona
{
    public partial class Form1 : Form
    { 
        ArduinoData arduino;
        Thread t;
        
        public Form1()
        {
            InitializeComponent();
            arduino = new ArduinoData();
           
            
            labelTempWnetrze.Text = Randomizer.GetRandomNumber(5, 30).ToString("#.00");
            labelTempDwor.Text = Randomizer.GetRandomNumber(-20, 40).ToString("#.00");
            
            
        }

       

        

        private void timerTemperatury_Tick(object sender, EventArgs e)
        {
             
            Logika logika = new Logika(Convert.ToDouble(labelTempWnetrze.Text), Convert.ToDouble(labelTempDwor.Text));
            logika.Reguly();
            logika.OdswiezImg(pictureBoxKlima, pictureBoxPiecyk,pictureBox1,labelTempWnetrze);
            labelTempWnetrze.Text = (Convert.ToDouble(labelTempWnetrze.Text) + logika.OdswiezTempPokoju()).ToString("#.00");
            mocPiec.Text = logika.pc.ToString();
            mocKlima.Text = logika.kl.ToString();
            mocSciana.Text = logika.wp.ToString();
            label1.Text = arduino.Photoresistor().ToString();
            ZmianaPoryDnia(arduino.Photoresistor());

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

        
        private void ZmianaPoryDnia(int czas)
        {

             timerTemperatury.Stop();
            
            
                if (czas <= 500)
                {
                    pictureBoxPoraDnia.Image = Properties.Resources.dzien;
                    pictureBoxPoraDnia.Invalidate();
                }
                else
                {
                    pictureBoxPoraDnia.Image = Properties.Resources.noc;
                    pictureBoxPoraDnia.Invalidate();
                }
            
           timerTemperatury.Start();
        }

        private void buttonNewRandom_Click(object sender, EventArgs e)
        {
            bool poprawne = true;

            FormaRandomizujaca forma = new FormaRandomizujaca();
            forma.ShowDialog();
            
            if(forma.DialogResult == DialogResult.OK)
            {
                do
                {
                    try
                    {
                        forma.NowyRandom(labelTempWnetrze, labelTempDwor);
                        poprawne = true;
                    }
                    catch (Exception ex)
                    {
                        poprawne = false;

                        if (forma.minRandomek.Text == "")
                            MessageBox.Show("Pole temperatura minimalna jest puste");
                        else if (forma.maxRandomek.Text == "")
                            MessageBox.Show("Pole temperatura maksymalna jest puste");
                        else
                            MessageBox.Show("Error");
                        forma.ShowDialog();

                    }
                } while (poprawne != true);
            }
            
        }

       

      
    }
}
