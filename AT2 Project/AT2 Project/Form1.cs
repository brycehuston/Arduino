using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace AT2_Project
{
    public partial class Form1 : Form
    {
        //declare port variable
        public SerialPort myPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = cmbPort.Text; // COM port from user selection
                myPort.Open();
                myPort.DataReceived += myPort_DataReceived; // call method
            }
            catch (Exception)
            {

                MessageBox.Show("Not Connected. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = myPort.ReadLine(); //read data from Arduino
            BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }
        private delegate void LineReceivedEvent(string line);
        // conver raw data into correct format
        private void LineReceived(string line)
        {
            String[] dataHumTemp = line.Split(',');
            tbOutsideTemp.Text = dataHumTemp[0];
            tbInsideTemp.Text = dataHumTemp[1];
            tbInsideHumidity.Text = dataHumTemp[2];
        }

        // turn on Green RGB light when radio button is checked
        private void RbGreen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbGreen.Checked)
                {
                    myPort.WriteLine("101");
                }
                else
                {
                    myPort.WriteLine("200");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select A Port and Press Connect First", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        //Turn on Red RGB light when radio button is checked
        private void RbRed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbRed.Checked)
                {
                    myPort.WriteLine("102");
                }
                else
                {
                    myPort.WriteLine("201");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select A Port and Press Connect First", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        //Turn on Blue RGB light when radio button is checked
        private void RbBlue_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbBlue.Checked)
                {
                    myPort.WriteLine("103");
                }
                else
                {
                    myPort.WriteLine("202");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select A Port and Press Connect First", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void RbOff_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                myPort.WriteLine("200");
                myPort.WriteLine("201");
                myPort.WriteLine("202");
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select A Port and Press Connect First", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        //Red LED toggle indicated when button is clicked
        bool RedLedStatus = true;
        private void BtnToggle_Click(object sender, EventArgs e)
        {
            if (RedLedStatus)
            {
                myPort.WriteLine("300");
                RedLedStatus = false;
            }
            else
            {
                myPort.WriteLine("301");
                RedLedStatus = true;
            }
        }

        //Method to set the max temperature
        private void TempMax_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cmbTempMax.Text) == 25)
                {
                    myPort.WriteLine("25");
                }
                else if (int.Parse(cmbTempMax.Text) == 26)
                {
                    myPort.WriteLine("26");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Something", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }
    }
}
