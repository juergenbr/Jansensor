using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace SensorVisualizer
{
    public class SerialConnection
    {
        private SerialPort serialPort1;

        public SerialConnection()
        {
            serialPort1 = new SerialPort();
        }

        public void initSerialPort()
        {
            this.serialPort1.BaudRate = 115200;                             //Set baud rate to 115200 baud
            this.serialPort1.Parity = Parity.None;                          //Set serial port Parity
            this.serialPort1.StopBits = StopBits.One;                       //Set the number of serial port stop bits
            this.serialPort1.DataBits = 8;                                    //Set the number of Data bits
            
        }

        public void resetSerial(){
            if (isPortOpen())
            {
                this.serialPort1.Write("x" + System.Environment.NewLine);
            }
            
        }

        public void connect()
        {
            this.serialPort1.Open();
            serialPort1.Write("v" + System.Environment.NewLine);
            this.serialPort1.Write("+" + System.Environment.NewLine);
            this.serialPort1.Write("+" + System.Environment.NewLine);
        }

        public void CloseSerialOnExit()
        {
            try
            {
                this.serialPort1.DiscardInBuffer();                     //Clear the input buffer
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            finally
            {
                if (this.serialPort1.IsOpen)
                {
                    serialPort1.Close();                                //Close the serial port
                }
            }
        }

        public void setPortName(string name){
            this.serialPort1.PortName = name;
        }

        public bool isPortOpen()
        {
            return serialPort1.IsOpen;
        }

        public string getPortName()
        {
            return serialPort1.PortName;
        }

        internal void setDataReceivedHandler(SerialDataReceivedEventHandler serialDataReceivedEventHandler)
        {
            this.serialPort1.DataReceived += serialDataReceivedEventHandler;
        }
    }
}
