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
            tbSpeed.Value = 0;
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

        private void distanceTimer_Tick(object sender, EventArgs e)
        {
            int distance = car.GetDistance();
            lblDistance.Text = distance.ToString() + "mm";
            if (distance > pbDistance.Maximum)
            {
                pbDistance.Value = pbDistance.Maximum;
            } else
            {
                if(distance < pbDistance.Minimum)
                {
                    pbDistance.Value = pbDistance.Minimum;
                } else
                {
                    pbDistance.Value = distance;
                }
            }
                
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            car.Connected = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    tbSpeed.Value = 10;
                    break;
                case Keys.Down:
                    tbSpeed.Value = -10;
                    break;
                case Keys.Left:
                    radioLeft.Checked = true;
                    break;
                case Keys.Right:
                    radioRight.Checked = true;
                    break;
            }
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            car.SetSpeed(tbSpeed.Value * 10);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            tbSpeed.Value = 0;
            radioForwads.Checked = true;
        }
    }
}
