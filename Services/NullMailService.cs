using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DutchTree.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }


        public void SendMessage(string to,string subject,string body)
        {
            _logger.LogInformation($"To:{to} , Subject:{subject} , body : {body}");
        }
    }
}
