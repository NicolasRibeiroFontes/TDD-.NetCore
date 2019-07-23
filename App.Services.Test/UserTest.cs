using App.Services;
using NUnit.Framework;

namespace Tests
{
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        public void ConcatenateNameIncorrect()
        {
            user.FirstName = "TDD";
            user.LastName = ".Net Core";
            Assert.AreNotEqual(user.ConcatenateName(), "TDD .Net");
        }

        [Test]
        public void ConcatenateNameCorrect()
        {
            user.FirstName = "TDD";
            user.LastName = ".Net Core";
            Assert.AreEqual(user.ConcatenateName(), "TDD .Net Core");
        }

        [Test]
        public void ConcatenateNameCorrectUpperCase()
        {
            user.FirstName = "TDD";
            user.LastName = ".Net Core";
            Assert.AreEqual(user.ConcatenateName().ToUpper(), "TDD .NET CORE");
        }

        [Test]
        public void ValidEmail()
        {
            user.Email = "nicolas.rfontesgmail";
            Assert.False(user.ValidEmail());
            user.Email = "nicolas.rfontes@gmail.com";
            Assert.True(user.ValidEmail());
        }

        [Test]
        public void ValidAdult()
        {
            //18 years = 6574 (6570 + 4 29feb)
            user.BirthDate = new System.DateTime(2001, 07, 23);
            Assert.GreaterOrEqual(user.GetDaysOfLife(), 6574);
        }
    }
}