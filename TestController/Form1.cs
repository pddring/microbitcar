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
            car.SetSpeed(int.Parse(txtSpeed.Text));
        }

        private void chkDoors_CheckedChanged(object sender, EventArgs e)
        {
            car.OpenDoors(chkDoors.Checked);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(lstCOMPorts.SelectedIndex > -1)
            {
                car.SetPort(lstCOMPorts.SelectedItem.ToString());
                car.Connected = true;
                car.ReceivedData += Car_ReceivedData;
            }
            
        }

        private void Car_ReceivedData(object sender, CarController.ReceiveLineEventArgs e)
        {
            lstOutput.BeginInvoke(new Action(() => {
                lstOutput.Items.Add(e.DataReceived);
                lstOutput.SelectedIndex = lstOutput.Items.Count - 1;
            }));
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCOMPorts.Items.Clear();
            lstCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void btnHorn_Click(object sender, EventArgs e)
        {
            car.SetHorn(int.Parse(txtHorn.Text));
        }

        private void btnCustomSend_Click(object sender, EventArgs e)
        {

            car.Send(txtCustom.Text);
            txtCustom.Text = "";
            txtCustom.Select();
        }

        private void lblDistance_Click(object sender, EventArgs e)
        {
            lblDistance.Text = car.GetDistance().ToString() + "mm";
        }

        private void distanceTimer_Tick(object sender, EventArgs e)
        {
            lblDistance.Text = car.GetDistance().ToString() + "mm";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            car.Connected = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }
    }
}
