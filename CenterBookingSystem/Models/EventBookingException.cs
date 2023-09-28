using System;

namespace CenterBookingSystem.Models
{        
    public class EventBookingException:Exception{
        public EventBookingException(string message):base(message)
        {}
    }
}
