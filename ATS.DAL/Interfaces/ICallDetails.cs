﻿using System;

namespace ATS.DAL.Interfaces
{
    public interface ICallDetails
    {
        DateTime StartedTime { get; set; }
        TimeSpan DurationTime { get; set; }
        string Source { get; set; }
        string Target { get; set; }
        decimal Cost { get; set; }
    }
}