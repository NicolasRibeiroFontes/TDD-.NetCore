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
                LastName = "Fontes"
            };
            Console.WriteLine(_user.ConcatenateName());

            Console.WriteLine("---------");
            Console.WriteLine("Finish!");
            Console.ReadKey();
        }
    }
}
