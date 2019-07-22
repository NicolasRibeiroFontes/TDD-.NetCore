using App.Services;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTest
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        public void ConcatenateNameCorrect()
        {
            user.FirstName = "TDD";
            user.LastName = ".Net Core";
            Assert.AreEqual(user.ConcatenateName(), "TDD .Net Core");
        }

        [Test]
        public void ValidEmail()
        {
            user.Email = "nicolas.rfontesgmail";
            Assert.False(user.ValidEmail());
            user.Email = "nicolas.rfontes@gmail.com";
            Assert.True(user.ValidEmail());
        }
    }
}