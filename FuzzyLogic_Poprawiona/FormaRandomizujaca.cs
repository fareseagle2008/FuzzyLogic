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
    public partial class FormaRandomizujaca : Form
    {
        public FormaRandomizujaca()
        {
            InitializeComponent();
            comboBoxWyborTemperatury.SelectedIndex = 0;
        }
        bool correct = false;
        public string NowyRandom(Label temperaturaWnetrza, Label temperaturaDworu)
        {

            if (comboBoxWyborTemperatury.SelectedItem.ToString() == "Temperatura wnetrza")
            {
                return temperaturaWnetrza.Text = Randomizer.GetRandomNumber(Convert.ToDouble(textBoxMin.Text), Convert.ToDouble(textBoxMax.Text)).ToString();
            }
            else
            {
                return temperaturaDworu.Text = Randomizer.GetRandomNumber(Convert.ToDouble(textBoxMin.Text), Convert.ToDouble(textBoxMax.Text)).ToString();
            }
        }        
    }
}
