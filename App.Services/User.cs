using System;

namespace App.Services
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ConcatenateName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
