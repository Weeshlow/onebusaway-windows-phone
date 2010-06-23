﻿using System;
using System.Net;
using System.Collections.Generic;
using OneBusAway.WP7.ViewModel.DataStructures;

namespace OneBusAway.WP7.ViewModel.EventArgs
{
    public class ScheduleForStopEventArgs : ABusServiceEventArgs
    {
        public List<RouteSchedule> schedules { get; private set; }
        public Stop stop { get; private set; }

        public ScheduleForStopEventArgs(Stop stop, List<RouteSchedule> schedules, Exception error)
        {
            this.error = error;
            this.schedules = schedules;
            this.stop = stop;
        }
    }
}
