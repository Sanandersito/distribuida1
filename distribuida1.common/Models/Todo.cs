﻿using System;

namespace distribuida1.common.Models
{
    public class Todo
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
