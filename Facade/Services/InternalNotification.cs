using System;

namespace MyNamespace
{
    public class InternalNotification
    {
        public void SendNotification(int userId, string content)
        {
            Console.WriteLine("Wysłałem powiadomienie do wenwętrznego systemu powiadomień");
        }
    }
}
