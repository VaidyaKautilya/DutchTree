using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTree.Services
{
    public interface IMailService
    {
        public void SendMessage(string to, string subject, string body);
    }
}
