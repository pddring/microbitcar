using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroBitCarController;

namespace TestController
{
    public partial class Form1 : Form
    {
        protected CarController car = new CarController();

        public Form1()
        {
            InitializeComponent();
        }

        private void chkRearLights_CheckedChanged(object sender, EventArgs e)
        {
            car.SetBrakeLights(chkRearLights.Checked);
        }

        private void chkHeadlights_CheckedChanged(object sender, EventArgs e)
        {
            car.SetHeadLights(chkHeadlights.Checked);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstCOMPorts.Items.Clear();
            lstCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sliderSpeed.Value = 0;
            car.Stop();
        }

        private void chkDoors_CheckedChanged(object sender, EventArgs e)
        {
            car.OpenDoors(chkDoors.Checked);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            car.SetPort(lstCOMPorts.SelectedValue.ToString());
            car.Connected = true;
        }

        private void radioLeft_CheckedChanged(object sender, EventArgs e)
        {
            if(radioLeft.Checked)
            {
                car.Steer(CarController.Direction.Left);
            }
        }

        private void radioForwads_CheckedChanged(object sender, EventArgs e)
        {
            if (radioForwads.Checked)
            {
                car.Steer(CarController.Direction.Forwards);
            }
        }

        private void radioRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRight.Checked)
            {
                car.Steer(CarController.Direction.Right);
            }
        }

        private void sliderSpeed_Scroll(object sender, EventArgs e)
        {
            car.SetSpeed(sliderSpeed.Value);
        }
    }
}
