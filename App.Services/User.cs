using System;

namespace App.Services
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public string ConcatenateName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public bool ValidEmail()
        {
            return Email.Contains("@") && Email.Contains(".com");
        }

        public int GetDaysOfLife()
        {
            return (DateTime.Now - BirthDate).Days;
        }
    }
}
