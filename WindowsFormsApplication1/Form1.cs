using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Srl_MySerial.IsOpen) 
            {
                Srl_MySerial.Open();
                Rtb_RX.Text = "Port Opened :";
            }
            else
            {
                Rtb_RX.Text = "Port Busy :";
            }
        }

        private string rxString;

        private void Srl_MySerial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxString = Srl_MySerial.ReadExisting();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(rxString);
            rxString = " "+asciiBytes[0].ToString();
            this.Invoke(new EventHandler(displayText));
        }

        private void displayText(object o, EventArgs e)
        {
            Rtb_RX.AppendText(rxString);
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Srl_MySerial.Write(Rtb_TX.Text);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Rtb_TX.Clear();
            Rtb_RX.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Srl_MySerial.Close();
        }

        private void Rtb_TX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Srl_MySerial.IsOpen && Cb_IM.Checked)
            {
                char[] chr = new char[1];
                chr[0] = e.KeyChar;
                Srl_MySerial.Write(chr, 0, 1);
            }
        }
    }
}
