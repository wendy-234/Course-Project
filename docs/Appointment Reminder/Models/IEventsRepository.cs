using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_Reminder.Models
{
    public interface IEventsRepository
    {
        IQueryable<Events> Events { get; }
    }
}
