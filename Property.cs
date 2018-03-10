using System;

namespace _02_classes
{
    public class PropertyPerson
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }

        public PropertyPerson(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

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