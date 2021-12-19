using System.Collections.Generic;

namespace CoursePoo.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification>? Notifications { get; set; }

        // public void AddNotification(Notification notification)
        // {
        //     Notification.AddRange(notification);
        // }

        public void Add(IEnumerable<Notification> notifications)
        {
            Notification.AddRange(notifications);
        }

        public bool IsInValid => Notifications.Any();
    
    
    }


}