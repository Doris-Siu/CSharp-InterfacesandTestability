
using CSharp_InterfacesandTestability;

namespace main;

public class main
{

    static void Main(string[] args)
    {
        // interface defines a contract that all classes inheriting from should follow
        // it declares what a class should have while an inheritng class defines the implementation
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();


        // interface and testability

        var orderProcessor = new OrderProcessor(new ShippingCalculator());
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);

        //real case
    emailService a = new emailService(new emailSender());
        a.sendEmail("haha");
        //unit test case
        emailService b = new emailService(new mockemailSender());
        b.sendEmail("haha");


        //interfaces and extensibility
        var dbMigrator = new DbMigrator(new ConsoleLogger());
        dbMigrator.Migrate();

        // changing behaviour: migrate to a file instead of a console by creating a new concrete class
        //var dbMigrator1 = new DbMigrator(new FileLogger("path"));
        //dbMigrator1.Migrate();


        // interfaces and polymorphism
        var encoder = new VideoEncoder();
        encoder.RegisterNotificationChannel(new MailNotificationChannel());
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        encoder.Encode(new Video());

    }

}


// interface benifits: security + multiple inheritances

public interface IPrey
{
    // purely declaration without access modifier
    void Flee();
}
public interface IPredator
{
    void Hunt();
}

public class Rabbit : IPrey
{
    // provides the implementation from the child class
public void Flee()
    {
        Console.WriteLine("The rabbit runs away!");
    }

}

public class Hawk : IPredator
{
public void Hunt()
    {
        Console.WriteLine("The hawk is searching for food!");
    }

}

public class Fish : IPrey, IPredator
{
public void Flee()
    {
        Console.WriteLine("The fish runs away!");
    }

    public void Hunt()
    {
        Console.WriteLine("The fish is searching for smaller fishes!");
    }
}

public class emailService
{
    private IEmailSender es;
    public emailService(IEmailSender injectedES) {
        this.es = injectedES;
    }
    public  void sendEmail(string emailContext)
    {
        //we are not going to send email when it is doing unit testing
        //Console.WriteLine("send email " + emailContext);

        //we detached the responsiblity of email sending from the function by the interface
        es.SendEmail(emailContext);
    }
}


public interface IEmailSender
{
    public void SendEmail(string emailContext);
}


public class emailSender : IEmailSender
{
    public void SendEmail(string emailContext)
    {
        Console.WriteLine("send email " + emailContext);

    }
}

public class mockemailSender : IEmailSender
{
    public void SendEmail(string emailContext)
    {
        Console.WriteLine("do nothing");

    }
}