using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic_Poprawiona
{
    class Logika
    {

        double[] offsetWnetrze = new double[5];
        double[] offsetDworOknoOt = new double[3];
        double[] offsetDworOknoZam = new double[3];

        static double piecyk = 0;
        static double klima = 0;
        static int wplywNaTempWnetrza = 0;

        public double kl { get; set; }
        public double pc { get; set; }
        public int wp { get; set; }
        public Logika(double TemperaturaWnetrza, double TemperaturaDwor)
        {
            Najzimniej(TemperaturaWnetrza);
            Zimno(TemperaturaWnetrza);
            Optymalnie(TemperaturaWnetrza);
            Cieplo(TemperaturaWnetrza);
            Najcieplej(TemperaturaWnetrza);

            DworOknoZamZimno(TemperaturaDwor);
            DworOknoZamOptymalnie(TemperaturaDwor);
            DworOknoZamCieplo(TemperaturaDwor);

            DworOknoOtZimno(TemperaturaDwor);
            DworOknoOtOptymalnie(TemperaturaDwor);
            DworOknoOtCieplo(TemperaturaDwor);
            //WypisanieTestowe();
            Macierz_regul macierz = new Macierz_regul(offsetWnetrze[0], offsetWnetrze[1], offsetWnetrze[2], offsetWnetrze[3], offsetWnetrze[4],
                offsetDworOknoZam[0], offsetDworOknoZam[1], offsetDworOknoZam[2]);
            kl = macierz.KlimaWartosc();
            pc = macierz.PiecykWartosc();
            //MessageBox.Show("Piecyk: " + pc);
            
        }

        #region termy_temp_wnetrza
        //od -inf do 15
        public void Najzimniej(double temperatura)
        {
            if (temperatura <= 8)
            {
                offsetWnetrze[0] = 1;
            }
            else if ((temperatura >= 8) && (temperatura < 15))
            {
                offsetWnetrze[0] = (15 - temperatura) / (15 - 8);
            }
            else if (temperatura >= 15)
            {
                offsetWnetrze[0] = 0;
            }
        }
        //od 11 do 25 med1 = 17 med2 = 21
        public void Zimno(double temperatura)
        {
            if (temperatura < 11)
            {
                offsetWnetrze[1] = 0;
            }
            else if (temperatura >= 11 && temperatura <= 17)
            {
                offsetWnetrze[1] = (temperatura - 11) / (17 - 11);
            }
            else if (temperatura > 17 && temperatura < 21)
            {
                offsetWnetrze[1] = 1;
            }
            else if (temperatura >= 21 && temperatura <= 24)
            {
                offsetWnetrze[1] = (24 - temperatura) / (24 - 21);
            }
            else if (temperatura >= 25)
            {
                offsetWnetrze[1] = 0;
            }
        }

        //od 24 do 29 med 25.5
        public void Optymalnie(double temperatura)
        {
            if (temperatura < 23)
            {
                offsetWnetrze[2] = 0;
            }
            else if (temperatura >= 23 && 25.5 >= temperatura)
            {
                offsetWnetrze[2] = (temperatura - 23) / (25.5 - 23);
            }
            else if (temperatura >= 25.5 && temperatura <= 29)
            {
                offsetWnetrze[2] = (29 - temperatura) / (29 - 25.5);
            }
            else if (temperatura > 29)
            {
                offsetWnetrze[2] = 0;
            }
        }
        //od 29 do 35 med1 = 31 med2 = 33
        public void Cieplo(double temperatura)
        {
            if (temperatura < 27)
            {
                offsetWnetrze[3] = 0;
            }
            else if (temperatura >= 27 && temperatura <= 31)
            {
                offsetWnetrze[3] = (temperatura - 27) / (31 - 27);
            }
            else if (temperatura >= 31 && temperatura <= 33)
            {
                offsetWnetrze[3] = 1;
            }
            else if (temperatura > 33 && temperatura <= 35)
            {
                offsetWnetrze[3] = (35 - temperatura) / (35 - 33);
            }
            else if (temperatura > 35)
            {
                offsetWnetrze[3] = 0;
            }
        }
        //od 35 do inf med1 = 39
        public void Najcieplej(double temperatura)
        {
            if (temperatura < 33)
            {
                offsetWnetrze[4] = 0;
            }
            else if (temperatura >= 33 && temperatura <= 39)
            {
                offsetWnetrze[4] = (temperatura - 33) / (39 - 33);
            }
            else if (temperatura > 39)
            {
                offsetWnetrze[4] = 1;
            }
        }
        #endregion
        #region termy_temp_dworu_okno_zamkniete
        //od -inf do 15 zimno med1 = 13
        public void DworOknoZamZimno(double temperaturaDwor)
        {
            if (temperaturaDwor < 13)
            {
                offsetDworOknoZam[0] = 1;
            }
            else if ((temperaturaDwor >= 13) && (temperaturaDwor < 15))
            {
                offsetDworOknoZam[0] = (15 - temperaturaDwor) / (15 - 13);
            }
            else if (temperaturaDwor >= 15)
            {
                offsetDworOknoZam[0] = 0;
            }
        }
        //od 15 do 30 ok med1 = 20 med2 = 25
        public void DworOknoZamOptymalnie(double temperaturaDwor)
        {
            if (temperaturaDwor < 12)
            {
                offsetDworOknoZam[1] = 0;
            }
            else if (temperaturaDwor >= 12 && temperaturaDwor <= 20)
            {
                offsetDworOknoZam[1] = (20 - temperaturaDwor) / (20 - 12);
            }
            else if (temperaturaDwor > 20 && temperaturaDwor < 25)
            {
                offsetDworOknoZam[1] = 1;
            }
            else if (temperaturaDwor >= 25 && temperaturaDwor < 30)
            {
                offsetDworOknoZam[1] = (30 - temperaturaDwor) / (30 - 25);
            }
        }
        //od 30 do inf goraco

        public void DworOknoZamCieplo(double temperaturaDwor)
        {
            if (temperaturaDwor < 27)
            {
                offsetDworOknoZam[2] = 0;
            }
            else if (temperaturaDwor >= 27 && temperaturaDwor < 30)
            {
                offsetDworOknoZam[2] = (30 - temperaturaDwor) / (30 - 27);
            }
            else if (temperaturaDwor >= 30)
            {
                offsetDworOknoZam[2] = 1;
            }
        }
        #endregion
        #region termy_temp_dworu_okno_otwarte
        //od -inf do 22 zimno
        public void DworOknoOtZimno(double temperaturaDwor)
        {
            if (temperaturaDwor < 17)
            {
                offsetDworOknoOt[0] = 1;
            }
            else if ((temperaturaDwor >= 17) && (temperaturaDwor < 22))
            {
                offsetDworOknoOt[0] = (22 - temperaturaDwor) / (22 - 17);
            }
            else if (temperaturaDwor >= 22)
            {
                offsetDworOknoOt[0] = 0;
            }
        }
        //od 22 do 28 ok
        public void DworOknoOtOptymalnie(double temperaturaDwor)
        {
            if (temperaturaDwor < 22)
            {
                offsetDworOknoOt[1] = 0;
            }
            else if (temperaturaDwor >= 22 && temperaturaDwor <= 24)
            {
                offsetDworOknoOt[1] = (24 - temperaturaDwor) / (24 - 22);
            }
            else if (temperaturaDwor > 24 && temperaturaDwor < 26)
            {
                offsetDworOknoOt[1] = 1;
            }
            else if (temperaturaDwor >= 26 && temperaturaDwor < 28)
            {
                offsetDworOknoOt[1] = (28 - temperaturaDwor) / (28 - 26);
            }
        }
        //od 28 do inf goraco
        public void DworOknoOtCieplo(double temperaturaDwor)
        {
            if (temperaturaDwor < 28)
            {
                offsetDworOknoOt[2] = 0;
            }
            else if (temperaturaDwor >= 28)
            {
                offsetDworOknoOt[2] = 1;
            }
        }
        #endregion


        public void Wyostrzenie()
        {

        }
        //ma być coś w stylu Najzimniej(tempWnetrza) && Zimno(TempDwor) -> Określenie poziomu klimatyzacji ze wzoru i określenie temp pieca

       /* public void WypisanieTestowe()
        {
            for (int i = 0; i < offsetWnetrze.Length; i++)
            {
                Console.WriteLine("Term wnetrza: " + offsetWnetrze[i]);
            }
            for (int i = 0; i < offsetDworOknoZam.Length; i++)
            {
                Console.WriteLine("Term dworu okno zamnk: " + offsetDworOknoZam[i]);
            }
            for (int i = 0; i < offsetDworOknoOt.Length; i++)
            {
                Console.WriteLine("Term dworu okno ot: " + offsetDworOknoOt[i]);
            }
        }*/


        public double OdswiezTempPokoju()
        {
            pc = piecyk;
            kl = klima;
            wp = wplywNaTempWnetrza;
            return piecyk + klima + wplywNaTempWnetrza;
        }

    }
}

