using System;
namespace CSharp_InterfacesandTestability
{
	public class MailNotificationChannel :INotificationChannels
	{

        void INotificationChannels.Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}

