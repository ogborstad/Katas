using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HandlekurvMocking
{
    public class ShoppingCartTests
    {
        [TestFixture]
        public class When_order_is_placed
        {
            [Test]
            public void Assure_confirmation_message_is_sent_to_the_user()
            {
                var messageSenderMock = new MessageSenderMock();
                var shoppingCart = new ShoppingCart(new EmailMessageSenderAdapter());

                shoppingCart.PlaceOrder();

                Assert.AreEqual(1, messageSenderMock.SendCallCount);
            }
        }

        public class MessageSenderMock : IMessageSender
        {
            public int SendCallCount { get; set; }

            public void Send(string email, string message)
            {
                SendCallCount++;
            }
        }
    }
}
