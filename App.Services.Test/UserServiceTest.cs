using NUnit.Framework;

namespace App.Services.Test
{
    public class UserServiceTest
    {
        private User user;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            _userService = new UserService();
            user = new User();
        }

        [Test]
        public void MustInsertUser()
        {
            user.Email = "nicolas.rfontes@gmail.com";
            user.FirstName = "Nicolas";
            user.LastName = "Fontes";
            Assert.NotNull(_userService.InsertUser(user));
        }
    }
}
