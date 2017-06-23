using System;

namespace MyNamespace
{
    public class EmailNotification
    {
        public void SendNotification(string content, string email)
        {
            Console.WriteLine("Wysyałem pwoaidomienie mailem. O treści: " + content);
        }
    }
}
