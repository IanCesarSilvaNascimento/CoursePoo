
using System;

using CoursePoo.NotificationContext;    

namespace CoursePoo.ContentContext
{

    public abstract class Base : Notifiable
    {   
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}