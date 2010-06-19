using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HandlekurvMocking;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart(new EmailMessageSenderAdapter());

            cart.PlaceOrder();
        }
    }
}
