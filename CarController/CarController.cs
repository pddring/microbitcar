using System;

namespace MicroBitCarController
{
    public class CarController
    {
        protected bool _connected = false;
        protected System.IO.Ports.SerialPort port;

        /// <summary>
        /// Create a new car controller object. 
        /// </summary>
        public CarController()
        {
            port = new System.IO.Ports.SerialPort();
            port.BaudRate = 115200;
        }

        /// <summary>
        /// Sets the COM port the micro:bit is connected to. Use System.IO.Ports.SerialPort.GetPortNames to get a list of available ports
        /// </summary>
        /// <param name="portName"></param>
        public void SetPort(string portName)
        {
            Connected = false;
            port.PortName = portName;
        }

        /// <summary>
        /// Connect or disconnects to/from the car
        /// </summary>
        public bool Connected
        {
            get
            {
                return port.IsOpen;
            }
            set
            {
                if (value)
                {
                    port.Open();
                    port.WriteLine("\n\rfrom microbit import *\n\r");
                    port.DataReceived += Port_DataReceived;
                } else
                {
                    port.Close();
                }
            }
        }

        public event ReceivedDataHandler ReceivedData;

        public class ReceiveLineEventArgs : EventArgs
        {
            public string DataReceived;
        }

        public delegate void ReceivedDataHandler(object sender, ReceiveLineEventArgs e);
        protected string lineReceived = "";
        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            lineReceived += port.ReadExisting();
            if(lineReceived.Contains("\n"))
            {
                string []parts = lineReceived.Split('\n');
                if (ReceivedData != null)
                {
                    for(int i = 0; i < parts.Length - 1; i++)
                    {
                        ReceiveLineEventArgs args = new ReceiveLineEventArgs();
                        args.DataReceived = parts[i];
                        ReceivedData(this, args);
                    }
                    lineReceived = parts[parts.Length-1];   
                }


            }
            
            
        }

        /// <summary>
        /// Switches the front lights on or off
        /// </summary>
        /// <param name="lights"></param>
        public void SetHeadLights(bool lights)
        {
            if (lights)
            {
                port.WriteLine("display.show(Image.HAPPY)\n\r");
            }
            else
            {
                port.WriteLine("display.show(Image.SAD)\n\r");
            }
        }

        /// <summary>
        /// Switches the rear lights on or off
        /// </summary>
        /// <param name="lights"></param>
        public void SetBrakeLights(bool lights)
        {

        }

        /// <summary>
        /// Switches the door open motor on or off
        /// </summary>
        /// <param name="doors"></param>
        public void OpenDoors(bool doors)
        {

        }

        /// <summary>
        /// Sets the speed (from -1023 to +1023). 0 will stop the car
        /// </summary>
        /// <param name="speed">Speed of the car (-1023 to 1023)</param>
        public void SetSpeed(int speed)
        {

        }

        /// <summary>
        /// Sets speed to 0 and direction to Forwards
        /// </summary>
        public void Stop()
        {
            SetSpeed(0);
            Steer(Direction.Forwards);
        }

        /// <summary>
        /// Directions the car can steer
        /// </summary>
        public enum Direction
        {
            Forwards, Left, Right
        }

        /// <summary>
        /// Sets the car direction (assuming it's going forwards)
        /// </summary>
        /// <param name="direction">Direction.Forwards, Direction.Left or Direction.Right</param>
        public void Steer(Direction direction)
        {

        }
    }
}
