using System.Collections.Generic;

namespace MyNamespace
{
    public class NotificationFacade
    {
        public EmailNotification EmailNotification {get; private set;}
        public InternalNotification InternalNotification {get; private set;}
        public MobileNotification MobileNotification {get; private set;}
        public SmsNotification SmsNotification {get; private set;}
        
        public NotificationFacade(EmailNotification emailNotification, InternalNotification internalNotification, MobileNotification mobileNotification, SmsNotification smsNotification)
        {
            EmailNotification = emailNotification;
            InternalNotification = internalNotification;
            MobileNotification = mobileNotification;
            SmsNotification = smsNotification;
        }
        
        public void SendNotification(IEnumerable<User> users, string content){
            foreach(User user in users){
                EmailNotification.SendNotification(content, user.Email);
            }
            
            foreach(User user in users){
                SmsNotification.SendSmsNotification(user.PhoneNumber, content);
            } 
            
            foreach(User user in users){
                InternalNotification.SendNotification(user.UserId, content);
            }   
            
            foreach(User user in users){
                MobileNotification.SendNotification(user.UserId, content);
            }                                     
        }
        
      
    }
}
