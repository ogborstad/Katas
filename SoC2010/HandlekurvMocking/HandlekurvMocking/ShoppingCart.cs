using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlekurvMocking
{
    public class ShoppingCart
    {
        private IMessageSender messageSender;


        public ShoppingCart(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public void PlaceOrder()
        {
            messageSender.Send("mail@goeran.no", "Your order was placed!");
        }
    }
}
