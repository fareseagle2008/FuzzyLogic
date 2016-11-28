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
            labelTempWnetrze.Text = Randomizer.GetRandomNumber(5, 50).ToString("#.00");
            labelTempDwor.Text = Randomizer.GetRandomNumber(-20, 40).ToString("#.00");
        }


        int czas = 0;
        private void timerTemperatury_Tick(object sender, EventArgs e)
        {
            ZmianaPoryDnia(czas);
            Logika logika = new Logika(Convert.ToDouble(labelTempWnetrze.Text), Convert.ToDouble(labelTempDwor.Text));
            logika.Reguly();
            labelTempWnetrze.Text = (Convert.ToDouble(labelTempWnetrze.Text) + logika.OdswiezTempPokoju()).ToString();
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
        private int ZmianaPoryDnia(int czas)
        {
            if (czas <= 100)
            {
                pictureBoxPoraDnia.Image = Properties.Resources.dzien;
                pictureBoxPoraDnia.Invalidate();
            }
            else
            {
                pictureBoxPoraDnia.Image = Properties.Resources.noc;
                pictureBoxPoraDnia.Invalidate();
            }
            if (czas == 150)
            {
                return czas = 0;
            }
            else
            {
                return ++czas;
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
                    MessageBox.Show("Nie rob se jaj");
                }
            }
            
        }
    }
}
