using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlekurvMocking
{
    public class EmailMessageSender
    {
        public void Kaboom(string email, string message)
        {
            Console.WriteLine("Send e-post to: " + email);
        }
    }
}
