using System;
namespace CSharp_InterfacesandTestability
{
	public interface ILogger
	{
        void LogError(string message);
        void LogInfo(string message);

    }
}

