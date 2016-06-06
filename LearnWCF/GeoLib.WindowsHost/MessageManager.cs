using GeoLib.WindowsHost.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLib.WindowsHost.Services
{
   // [ServiceBehavior(UseSynchronizationContext = false)]
    public class MessageManager: IMessageService
    {
       
       
        public void ShowMessage(string message)
        {
            Form1.form.ShowMessage(message);
        }   
    }
}
