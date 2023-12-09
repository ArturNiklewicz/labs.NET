using System;
using System.Collections.Generic;

namespace EnumExample
{
    public enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DayOfWeek Day { get; set; }

        public Task(string? name, string? description, DayOfWeek day)
        {
            this.Name = name;
            this.Description = description;
            this.Day = day;
        }

        public override string ToString()
        {
            return $"Task: {Name}\nDescription: {Description}\nDay: {Day}";
        }
    }
}