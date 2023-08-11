
namespace main;

public class main
{
    
    static void Main(string[] args)
    {
        //real case
        emailService a = new emailService(new emailSender());
        a.sendEmail("haha");
        //unit test case
        emailService b = new emailService(new mockemailSender());
        b.sendEmail("haha");
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