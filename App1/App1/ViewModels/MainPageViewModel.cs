using System;
using System.Collections.Generic;
using System.Text;
using XCalendar.Core.Models;

namespace App1.ViewModels
{
    public class MainPageViewModel
    {
        public Calendar<CalendarDay> Calendar { get; set; } = new Calendar<CalendarDay>();
    }
}
