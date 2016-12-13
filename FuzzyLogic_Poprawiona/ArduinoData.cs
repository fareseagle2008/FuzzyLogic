using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace FuzzyLogic_Poprawiona
{
    class ArduinoData
    {
        SerialPort myPort;
        public ArduinoData() {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = "COM6"; //pod jakim com jest podlaczone trzeba sprawdzic        

                myPort.Parity = Parity.None;
                myPort.DataBits = 8;
                myPort.StopBits = StopBits.One;

                myPort.DtrEnable = true;
                myPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection problem");
            }
        }

        public string Photoresistor()
        {
            string data = myPort.ReadLine();
            return data;
        }

        public void SendData(string message)
        {
            myPort.Write(message);

        }
       


    }
}
