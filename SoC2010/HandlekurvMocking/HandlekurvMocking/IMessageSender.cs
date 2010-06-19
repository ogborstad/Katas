using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlekurvMocking
{
    public interface IMessageSender
    {
        void Send(string email, string message);
    }
}
