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
                myPort.Open();
                myPort.DtrEnable = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Connection problem");
            }
        }

        public int Photoresistor()
        {
            int data = Convert.ToInt16(myPort.ReadLine());

            return data;
        }


}
}
