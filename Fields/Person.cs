﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
