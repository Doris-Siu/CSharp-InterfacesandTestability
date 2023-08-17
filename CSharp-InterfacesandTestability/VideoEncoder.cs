using System;
namespace CSharp_InterfacesandTestability
{
	public class VideoEncoder
	{
        private readonly List<INotificationChannels> _notificationChannels;

        public VideoEncoder()
		{
			// implements OCP when designing a class - thinks in abstraction
			// -> an interface comes in

			_notificationChannels = new List<INotificationChannels>();

		}

		public void Encode(Video video)
		{
			// video encoding logic..

			foreach (var channel in _notificationChannels)
			{
				channel.Send(new Message());
			}
		}

		public void RegisterNotificationChannel(INotificationChannels channel)
		{
			_notificationChannels.Add(channel);
		}
	}
}

