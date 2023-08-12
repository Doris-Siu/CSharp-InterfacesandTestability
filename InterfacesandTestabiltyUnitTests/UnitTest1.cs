using main;
namespace InterfacesandTestabiltyUnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //[ExpectedException(typeof(InvalidOperationException))]


    // METHODNAME_CONDITION_EXPECTATION
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

        var order = new Order
        {
            Shipment = new Shipment()
        };
    

    Assert.That(() => orderProcessor.Process(order),
                Throws.TypeOf<InvalidOperationException>());
    }


    [Test]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        
        var order = new Order();

        orderProcessor.Process(order);

        Assert.IsTrue(order.IsShipped);
        Assert.That(order.Shipment.Cost, Is.EqualTo(1));
        Assert.That(order.Shipment.ShippingDate, Is.EqualTo(DateTime.Today.AddDays(1)));
        //Assert.AreEqual(1, order.Shipment.Cost);
        //Assert.AreEqual(DateTime.Today.Add(1), order.Shipment.ShippingDate);

    }





    public class FakeShippingCalculator : IShippingCalculator
    {
public float CalculateShipping(Order order)
        {
            return 1;
        }

    }
}
