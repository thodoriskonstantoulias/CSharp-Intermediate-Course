using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
    public class PersonLesson6
    {
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
        public PersonLesson6(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
      
    }
}
