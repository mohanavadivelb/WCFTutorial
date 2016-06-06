using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ServiceModel;
using System.Diagnostics;
using GeoLib.WindowsHost.Services;
using GeoLib.WindowsHost.Contracts;

namespace GeoLib.WindowsHost
{
    public partial class Form1 : Form
    {
        public static Form1 form { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Current UI thread : " + Thread.CurrentThread.ManagedThreadId + " Process:" + Process.GetCurrentProcess().Id.ToString();
            button2.Enabled = false;
            form = this;
            syncontext = SynchronizationContext.Current;
        }

        ServiceHost hostGeoManger = null;
        ServiceHost hostMessageManager = null;
        SynchronizationContext syncontext = null;
        private void button1_Click(object sender, EventArgs e)
        {
            hostGeoManger = new ServiceHost(typeof(GeoLib.Service.GeoManager));
            hostMessageManager = new ServiceHost(typeof(GeoLib.WindowsHost.Services.MessageManager));
            hostGeoManger.Open();
            hostMessageManager.Open();
            button1.Enabled = false;
            button2.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            hostGeoManger.Close();
            hostMessageManager.Close();
            
        }
        public void ShowMessage(string message)
        {
            int threadid = Thread.CurrentThread.ManagedThreadId;
            lblMessage.Text = message + " Marshall from " + threadid.ToString() + " to UI thread :  " + Thread.CurrentThread.ManagedThreadId + " Process:" + Process.GetCurrentProcess().Id.ToString();
        }

          //  SendOrPostCallback post = new SendOrPostCallback(args =>
          //{
          //    lblMessage.Text = message + " Marshall from " +threadid.ToString() + " to UI thread :  " + Thread.CurrentThread.ManagedThreadId + " Process:" + Process.GetCurrentProcess().Id.ToString();
          //});

          //  syncontext.Post(post, null);
          // }

        private void lblInProceCall_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
           {
           ChannelFactory<IMessageService> factory = new ChannelFactory<IMessageService>("");
           IMessageService proxy = factory.CreateChannel();
           proxy.ShowMessage(DateTime.Today.ToString());
           factory.Close();
           });
            thread.IsBackground = true;
            thread.Start();

        }
    }
}
