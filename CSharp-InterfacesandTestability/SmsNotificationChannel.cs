using System;
namespace CSharp_InterfacesandTestability
{
	public class SmsNotificationChannel : INotificationChannels
	{
		

        void INotificationChannels.Send(Message message)
        {
            Console.WriteLine("Sending sms...");
        }
    }
}

