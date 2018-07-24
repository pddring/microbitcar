using System;

namespace CarController
{
    public class CarController
    {
        protected bool _connected = false;
        protected System.IO.Ports.SerialPort port;

        public CarController()
        {
            port = new System.IO.Ports.SerialPort();
            port.BaudRate = 115200;
        }

        public void SetPort(string portName)
        {
            port.PortName = portName;
        }

        public bool Connected
        {
            get
            {
                return port.IsOpen;
            }
            set
            {
                if(value)
                {
                    port.Open();
                } else
                {
                    port.Close();
                }
            }
        }
    }
}
