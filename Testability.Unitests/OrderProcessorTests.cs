using RefreshConsoleApp;
using RefreshConsoleApp.Testability;

namespace Testability.Unitests
{
    public class OrderProcessorTests
    {
        [SetUp]
        public void Setup()
        {
        }


        // METHOD_CONDITION_EXPECTATION
        [Test]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcess = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            
            Assert.Throws<InvalidOperationException>(() => orderProcess.Process(order));

        }

        [Test]
        public void Process_OrderIsNotShipped_TShouldSetPRopertyOfOrder()
        {
            var orderProcess = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcess.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);

        }
    }
}