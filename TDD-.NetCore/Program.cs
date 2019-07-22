using App.Services;
using System;

namespace TDD_.NetCore
{
    public class Program
    {
        public static UserService _userService = new UserService();

        static void Main(string[] args)
        {
            User user = new User
            {
                FirstName = "Nicolas",
                LastName = "Fontes",
                Email = "nicolas.rfontes@gmail.com"
            };
            Console.WriteLine("Concatenate: "+user.ConcatenateName());
            Console.WriteLine("Email Valid: " + (user.ValidEmail() ? user.Email : "Email invalid!"));
            Console.WriteLine("Insert User: " + (_userService.InsertUser(user) != null ? "Register Success" : "Register Failed"));
            Console.WriteLine("---------");
            Console.WriteLine("Finish!");
            Console.ReadKey();
        }
    }
}
