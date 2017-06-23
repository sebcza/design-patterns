using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class SmsNotification
    {
        
        public void SendSmsNotification(int? phoneNumber, string content){
            Console.WriteLine("Wysyłałem sms o treści:" + content + " Na number: "+ phoneNumber);
        }
    }
}
