using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic_Poprawiona
{
    class Macierz_regul
    {
        double najzimniej = 0;
        double zimno = 0;
        double optymalnie = 0;
        double cieplo = 0;
        double najcieplej = 0;

        double oknZamZimno = 0;
        double oknZamOptymalnie = 0;
        double oknZamCieplo = 0;

        double[] klimaMala = new double[3];
        double[] klimaSrednia = new double[3];
        double[] klimaDuza = new double[3];
        double[] klimaBrak = new double[6];

        double[] piecykBrak = new double[6];
        double[] piecykMale = new double[3];
        double[] piecykSrednie = new double[3];
        double[] piecykDuze = new double[3];

        double[,] macierz = new double[5, 3];

        public Macierz_regul(double Najzimniej, double Zimno, double Optymalnie, double Cieplo, double Najcieplej,
                            double OknZamZimno, double OknZamOptymalnie, double OknZamCieplo)
        {
            najzimniej = Najzimniej;
            zimno = Zimno;
            optymalnie = Optymalnie;
            cieplo = Cieplo;
            najcieplej = Najcieplej;

            oknZamZimno = OknZamZimno;
            oknZamOptymalnie = OknZamOptymalnie;
            oknZamCieplo = OknZamCieplo;
            WypelnijMacierz();
            WypiszMacierz();
        }

        public void WypelnijMacierz()
        {
            #region pierwszyRzad
            if (najzimniej > 0 && oknZamZimno > 0)
            {
                if (najzimniej > oknZamZimno)
                    macierz[0, 0] = najzimniej;
                else
                    macierz[0, 0] = oknZamZimno;
            }
            if (zimno > 0 && oknZamZimno > 0)
            {
                if (zimno > oknZamZimno)
                    macierz[1, 0] = zimno;
                else
                    macierz[1, 0] = oknZamZimno;
            }
            if (optymalnie > 0 && oknZamZimno > 0)
            {
                if (optymalnie > oknZamZimno)
                    macierz[2, 0] = optymalnie;
                else
                    macierz[2, 0] = oknZamZimno;
            }
            if (cieplo > 0 && oknZamZimno > 0)
            {
                if (cieplo > oknZamZimno)
                    macierz[3, 0] = cieplo;
                else
                    macierz[3, 0] = oknZamZimno;
            }
            if (najcieplej > 0 && oknZamZimno > 0)
            {
                if (najcieplej > oknZamZimno)
                    macierz[4, 0] = najcieplej;
                else
                    macierz[4, 0] = oknZamZimno;
            }
            #endregion
            #region drugiRzad
            if (najzimniej > 0 && oknZamOptymalnie > 0)
            {
                if (najzimniej > oknZamOptymalnie)
                    macierz[0, 1] = najzimniej;
                else
                    macierz[0, 1] = oknZamOptymalnie;
            }
            if (zimno > 0 && oknZamOptymalnie > 0)
            {
                if (zimno > oknZamOptymalnie)
                    macierz[1, 1] = zimno;
                else
                    macierz[1, 1] = oknZamOptymalnie;
            }
            if (optymalnie > 0 && oknZamOptymalnie > 0)
            {
                if (optymalnie > oknZamOptymalnie)
                    macierz[2, 1] = optymalnie;
                else
                    macierz[2, 1] = oknZamOptymalnie;
            }
            if (cieplo > 0 && oknZamOptymalnie > 0)
            {
                if (cieplo > oknZamOptymalnie)
                    macierz[3, 1] = cieplo;
                else
                    macierz[3, 1] = oknZamOptymalnie;
            }
            if (najcieplej > 0 && oknZamOptymalnie > 0)
            {
                if (najcieplej > oknZamOptymalnie)
                    macierz[4, 1] = najcieplej;
                else
                    macierz[4, 1] = oknZamOptymalnie;
            }
            #endregion
            #region trzeciRzad
            if (najzimniej > 0 && oknZamCieplo > 0)
            {
                if (najzimniej > oknZamCieplo)
                    macierz[0, 2] = najzimniej;
                else
                    macierz[0, 2] = oknZamCieplo;
            }
            if (zimno > 0 && oknZamCieplo > 0)
            {
                if (zimno > oknZamOptymalnie)
                    macierz[1, 2] = zimno;
                else
                    macierz[1, 2] = oknZamCieplo;
            }
            if (optymalnie > 0 && oknZamCieplo > 0)
            {
                if (optymalnie > oknZamCieplo)
                    macierz[2, 2] = optymalnie;
                else
                    macierz[2, 2] = oknZamCieplo;
            }
            if (cieplo > 0 && oknZamCieplo > 0)
            {
                if (cieplo > oknZamCieplo)
                    macierz[3, 2] = cieplo;
                else
                    macierz[3, 2] = oknZamCieplo;
            }
            if (najcieplej > 0 && oknZamCieplo > 0)
            {
                if (najcieplej > oknZamCieplo)
                    macierz[4, 2] = najcieplej;
                else
                    macierz[4, 2] = oknZamCieplo;
            }
            #endregion
        }
        public void WypiszMacierz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(macierz[j, i].ToString("0.##") + "\t\t");
                }
                Console.Write("\n");
            }
            Wyostrzenie();
        }

        public void Wyostrzenie()
        {
            klimaMala[0] = macierz[3, 0];
            klimaMala[1] = macierz[2, 1];
            klimaMala[2] = macierz[1, 2];

            klimaSrednia[0] = macierz[4, 0];
            klimaSrednia[1] = macierz[3, 1];
            klimaSrednia[2] = macierz[2, 2];

            klimaDuza[0] = macierz[4, 1];
            klimaDuza[1] = macierz[3, 2];
            klimaDuza[2] = macierz[4, 2];

            klimaBrak[0] = macierz[0, 0];
            klimaBrak[1] = macierz[1, 0];
            klimaBrak[2] = macierz[2, 0];
            klimaBrak[3] = macierz[0, 1];
            klimaBrak[4] = macierz[1, 1];
            klimaBrak[5] = macierz[0, 2];
            double klima = (klimaMala.Max() * 1 + klimaSrednia.Max() * 2 + klimaDuza.Max() * 3) /
                            (klimaBrak.Max() + klimaMala.Max() + klimaSrednia.Max() + klimaDuza.Max());

            piecykBrak[0] = macierz[4, 0];
            piecykBrak[1] = macierz[3, 1];
            piecykBrak[2] = macierz[4, 1];
            piecykBrak[3] = macierz[2, 2];
            piecykBrak[4] = macierz[3, 2];
            piecykBrak[5] = macierz[4, 2];

            piecykMale[0] = macierz[3, 0];
            piecykMale[1] = macierz[2, 1];
            piecykMale[2] = macierz[2, 2];

            piecykSrednie[0] = macierz[2, 0];
            piecykSrednie[1] = macierz[1, 1];
            piecykSrednie[2] = macierz[0, 2];

            piecykDuze[0] = macierz[1, 0];
            piecykDuze[1] = macierz[0, 0];
            piecykDuze[2] = macierz[0, 1];

            double piecyk = (piecykMale.Max() * 1 + piecykSrednie.Max() * 2 + piecykDuze.Max() * 3) / (piecykBrak.Max() + piecykMale.Max() + piecykSrednie.Max() + piecykDuze.Max());
            //MessageBox.Show(piecyk.ToString());
            //Console.WriteLine("KLIMA = " + klima);
            //Console.WriteLine("PIECYK = " + piecyk);
            //Console.WriteLine("Przykładowy wplyw na temperature: " + (piecyk - klima).ToString("#.##"));
            //MessageBox.Show(macierz[0, 0].ToString() + "\t" + macierz[1, 0].ToString() + "\t" + macierz[2, 0].ToString() + "\t" + macierz[3, 0].ToString() + "\t" + macierz[4, 0].ToString() + "\n" +
            //                macierz[0, 1].ToString() + "\t" + macierz[1, 1].ToString() + "\t" + macierz[2, 1].ToString() + "\t" + macierz[3, 1].ToString() + "\t" + macierz[4, 1].ToString() + "\n" +
             //               macierz[0, 2].ToString() + "\t" + macierz[1, 2].ToString() + "\t" + macierz[2, 2].ToString() + "\t" + macierz[3, 2].ToString() + "\t" + macierz[4, 2].ToString());
        }

        public double PiecykWartosc()
        {
            return (piecykMale.Max() * 1 + piecykSrednie.Max() * 2 + piecykDuze.Max() * 3) / (piecykBrak.Max() + piecykMale.Max() + piecykSrednie.Max() + piecykDuze.Max());
        }

        public double KlimaWartosc()
        {
            return (klimaMala.Max() * 1 + klimaSrednia.Max() * 2 + klimaDuza.Max() * 3) /
                            (klimaBrak.Max() + klimaMala.Max() + klimaSrednia.Max() + klimaDuza.Max());
        }
    }
}
