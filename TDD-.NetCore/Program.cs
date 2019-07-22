using App.Services;
using System;

namespace TDD_.NetCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            User _user = new User
            {
                FirstName = "Nicolas",
                LastName = "Fontes",
                Email = "nicolas.rfontes@gmail.com"
            };
            Console.WriteLine("Concatenate: "+_user.ConcatenateName());
            Console.WriteLine("Email Valid: " + (_user.ValidEmail() ? _user.Email : "Email invalid!"));

            Console.WriteLine("---------");
            Console.WriteLine("Finish!");
            Console.ReadKey();
        }
    }
}
