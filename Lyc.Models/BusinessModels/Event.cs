using System;
using System.ComponentModel.DataAnnotations;

namespace Lyc.Models.BusinessModels
{
    public class Event
    {
        public Event()
        {
            EventLocation = new EventLocation();
        }
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public string Description { get; set; }

        public int MaxSeats { get; set; }

        //public List<string> Categories { get; set; }

        public EventLocation EventLocation { get; set; }

    }
}