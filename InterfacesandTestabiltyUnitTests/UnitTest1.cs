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

    




    public class FakeShippingCalculator : IShippingCalculator
    {
public float CalculateShipping(Order order)
        {
            return 1;
        }

    }
}
