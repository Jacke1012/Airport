using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AirplaneClient
{

    public enum ConnectState
    {
        Disconnected, Connecting, Connected
    }

    public partial class Form1 : Form
    {

        TcpClient client;
        int port = 123;
        IPAddress address;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Connect_Click(object sender, EventArgs e)
        {
            if (await Connect() == false)
            {
                MessageBox.Show("Failed to connect");
                BtnConnect.Enabled = true;
                SetConnectionState(ConnectState.Disconnected);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConnectionState(ConnectState.Disconnected);
            BtnDisconnect.Enabled = false;
        }

        private async Task<bool> Connect()
        {
            SetConnectionState(ConnectState.Connecting);
            address = IPAddress.Parse("127.0.0.1");
            client = new TcpClient();
            client.NoDelay = true;
            BtnConnect.Enabled = false;

            Task connectTask = client.ConnectAsync(address, port);
            int numOfDelays = 0;
            do
            {
                await Task.Delay(10);
                numOfDelays++;
                if (numOfDelays >= 100)
                {
                    return false;
                }
            } while (!connectTask.IsCompleted);

            if (client.Connected)
            {
                BtnDisconnect.Enabled = true;
                SetConnectionState(ConnectState.Connected);
            }
            else
            {
                MessageBox.Show("Failed to connect");
                BtnConnect.Enabled = true;
                SetConnectionState(ConnectState.Disconnected);
            }

            return true;
        }

        async void Send()
        {
            if (!client.Connected)
            {
                bool result = await Connect();
                if (!result)
                {
                    MessageBox.Show("Connection Lost");
                    DisconnectServer();
                    return;
                }
            }

            byte[] sendData = Encoding.Unicode.GetBytes($"{tbxReg.Text},{tbxCallSign.Text}");
            client.GetStream().Write(sendData, 0, sendData.Length);
            client.Close();
        }

        void DisconnectServer()
        {
            client.Close();
            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
            SetConnectionState(ConnectState.Disconnected);
        }

        private void SetConnectionState(ConnectState state)
        {
            switch (state)
            {
                case ConnectState.Disconnected:
                    lblConnected.ForeColor = Color.Red;
                    lblConnected.Text = "Not Connected";
                    break;
                case ConnectState.Connecting:
                    lblConnected.ForeColor = Color.Yellow;
                    lblConnected.Text = "Connecting";
                    break;
                case ConnectState.Connected:
                    lblConnected.ForeColor = Color.Green;
                    lblConnected.Text = "Connected";
                    break;
                default:
                    break;
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectServer();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectServer();
        }
    }
}
