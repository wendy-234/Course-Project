using Appointment_Reminder.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_Reminder.Controllers
{
    public class EventsController
    {
        private IEventsRepository repository;
        public EventsController(IEventsRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Events);

        private ViewResult View(IQueryable<Events> events)
        {
            throw new NotImplementedException();
        }
    }
}
