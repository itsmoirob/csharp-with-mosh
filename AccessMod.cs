using System;

namespace _02_classes
{

    public class AccessModPerson
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

    // public class AccessMod
    // {

    // }
}