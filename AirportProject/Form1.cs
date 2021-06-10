using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportProject.Classes;
using System.Net;
using System.Net.Sockets;

namespace AirportProject
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        int port = 123;


        List<Airplane> allAirplanes = new List<Airplane>();

        static Model A320 = new Model("A320",253, new Dimensions(50, 10, 100));

        static Engine CFM56 = new Engine("CFM56",15, 20);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allAirplanes.Add(new Airplane("SE123", A320, CFM56));
            RefreshTable();

            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            BeginListen();
        }
        string result;
        async void BeginListen()
        {
            client = await listener.AcceptTcpClientAsync();
            byte[] buffer = new byte[1000];
            int inputSize = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

            result = Encoding.Unicode.GetString(buffer, 0, inputSize);

            string[] resultString; 
            resultString = result.Split(',');

            if (allAirplanes.Exists(x => x.regestration == resultString[0]))
            {
                allAirplanes.Find(x => x.regestration == resultString[0]).callSign = resultString[1];
            }

            client.Close();

            BeginListen();
        }

        public void RefreshTable()
        {
            airplaneListBox.Items.AddRange(allAirplanes.ToArray());
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (airplaneListBox.SelectedIndex != -1)
            {
                ShowInfo((Airplane)airplaneListBox.Items[airplaneListBox.SelectedIndex]);
            }
        }

        Airplane currentAircraft;
        public void ShowInfo(Airplane airplane)
        {
            currentAircraft = airplane;
            tbxReg.Text = airplane.regestration;
            tbxCall.Text = airplane.callSign;
            btnModel.Text = airplane.model.modelName;
            btnEngine.Text = airplane.engine.engineName;
        }

        private void tbxReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            currentAircraft.model.OpenInfo();
        }

        private void callSignSet_Click(object sender, EventArgs e)
        {
            currentAircraft.callSign = tbxCall.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
        }
    }
}
