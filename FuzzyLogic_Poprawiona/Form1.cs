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
        // ArduinoData arduino;
        ChartForm formChart = new ChartForm();
        //double temp = Randomizer.GetRandomNumber(5, 35);
        public Form1()
        {
            InitializeComponent();
            // arduino = new ArduinoData();
            labelTempWnetrze.Text = Randomizer.GetRandomNumber(0, 40).ToString("0.#####");
            labelTempDwor.Text = Randomizer.GetRandomNumber(0, 40).ToString("0.######");
            timerTemperatury.Start();
            
            
            formChart.chartTemp.Series["Temp"].Points.Clear();
            formChart.Show();
            //chart.Series["Series1"].Points.Clear();

        }




        double temp = 0;
        private void timerTemperatury_Tick(object sender, EventArgs e)
        {

            Logika logika = new Logika(Convert.ToDouble(labelTempWnetrze.Text), Convert.ToDouble(labelTempDwor.Text));
            labelTempWnetrze.Text = (Convert.ToDouble(labelTempWnetrze.Text) + Logika.piecyk - Logika.klima + Logika.wplywNaTempWnetrza).ToString("#.######");
            logika.OdswiezImg(pictureBoxKlima, pictureBoxPiecyk,pictureBox1,labelTempWnetrze);
            
            
            formChart.chartTemp.Series["Temp"].Points.AddY(Convert.ToDouble(labelTempWnetrze.Text));
            mocPiec.Text = Logika.piecyk.ToString("0.####");
            mocKlima.Text = Logika.klima.ToString("0.####");
            mocSciana.Text = Logika.wplywNaTempWnetrza.ToString();
            //labelLumeny.Text = arduino.Photoresistor();
            // ZmianaPoryDnia(Convert.ToInt16(arduino.Photoresistor()));

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

        private void buttonGetTemp_Click(object sender, EventArgs e)
        {
            timerTemperatury.Stop();
            //arduino.SendData("1");
            //arduino.Photoresistor();
            //labelTempDwor.Text = arduino.Photoresistor();
            //labelTempDwor.Text = labelTempDwor.Text.Replace("\r", "");
            //labelTempDwor.Text = labelTempDwor.Text.Replace(".", ",");
            timerTemperatury.Start();
        }
    }
}
