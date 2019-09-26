using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuickStart.SharedServices
{
    interface IMessageService
    {
        bool SendMessage(string url, string payload, string method);
        void SendMessage(string url, string method = "GET");
    }
}
