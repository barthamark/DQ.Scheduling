﻿using System;

namespace DQ.Scheduling.ViewModels
{
    public class CalendarEventViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool AllDay { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Url { get; set; }
    }
}