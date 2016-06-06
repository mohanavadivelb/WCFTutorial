using GeoLib.Contracts;
using GeoLib.Proxies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using GeoLib.Client.Contracts;

namespace GeoLib.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetZipInfo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtGetZipInfo.Text))
                
            {
                GeoClient geoProxy = new GeoClient("tcpEP");
                ZipCodeData zipCodeData = geoProxy.GetZipInfo(txtGetZipInfo.Text);
                if(zipCodeData !=null)
                {
                    lblCity.Text = zipCodeData.City;
                    lblStateInfo.Text = zipCodeData.State;

                }
                geoProxy.Close();

            }
        }
        private void btnGetZips_Click(object sender, EventArgs e)
        {
            if(txtState.Text !=null)
            {
                NetTcpBinding binding = new NetTcpBinding();
                binding.MaxReceivedMessageSize = 2000000;
                binding.ReliableSession.InactivityTimeout =TimeSpan.FromSeconds(10);
                binding.ReceiveTimeout = TimeSpan.FromSeconds(10);
                EndpointAddress endPointAddress = new EndpointAddress("net.Tcp://localhost/8009/GeoService");
                GeoClient proxy = new GeoClient(binding,endPointAddress);
                IEnumerable<ZipCodeData> zips = proxy.GetZips(txtState.Text);

                foreach (ZipCodeData zip in zips)
                {
                    lstZips.Items.Add(zip.ZipCode);
                }


            }
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            NetTcpBinding binding = new NetTcpBinding();
            EndpointAddress endPointAddress = new EndpointAddress("net.Tcp://localhost/8009/MessageService");
            //ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>("");
            ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>(binding,endPointAddress);
            IMessageService proxy = factory.CreateChannel();
            proxy.ShowMsg(txtMessage.Text);

        }
    }
}
