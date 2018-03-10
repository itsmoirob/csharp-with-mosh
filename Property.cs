using System;

namespace _02_classes
{
    public class PropertyPerson
    {
        public PropertyPerson(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}