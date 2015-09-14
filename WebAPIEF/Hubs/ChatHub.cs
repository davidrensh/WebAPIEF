using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace WebAPIEF
{
    public class ChatHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name + ":" + Context.ConnectionId.Substring(Context.ConnectionId.Length -3, 3) + ";", message);
        }


        /// register online user
        ///
        ///
        public override Task OnConnected()
        {
            string sOnline = "Online";
            Clients.All.addNewMessageToPage(Context.ConnectionId.Substring(Context.ConnectionId.Length - 3, 3), sOnline);
            return base.OnConnected();
        }

        ///
        /// unregister disconected user
        ///
        ///
        public override Task OnDisconnected(bool stopCalled)
        {
            string sOnline = "Offline";
            Clients.All.addNewMessageToPage(Context.ConnectionId.Substring(Context.ConnectionId.Length - 3, 3), sOnline);
            return base.OnDisconnected(stopCalled);
        }
    }
}