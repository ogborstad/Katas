using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlekurvMocking
{
    public class EmailMessageSenderAdapter : IMessageSender
    {
        public void Send(string email, string message)
        {
            var emailMessageSender = new EmailMessageSender();
            emailMessageSender.Kaboom(email, message);
        }
    }
}
