using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateFirstName("Kartikeya");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestEmail()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateEmail("kartikeya.kumar@capgemini.com");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMobileNum()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateMobileNum("91 7206183244");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPassword()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidatePassword("Kartikeya@19");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(true, "abc@yahoo.com")]
        [DataRow(true, "abc-100@yahoo.com")]
        [DataRow(true, "abc.100@yahoo.com")]
        [DataRow(true, "abc111@abc.com")]
        [DataRow(true, "abc-100@abc.net")]
        [DataRow(true, "abc.100@abc.com.au")]
        [DataRow(true, "abc+100@gmail.com")]
        public void TestValidMultiplEmail(bool expected, string email)
        {
            //Act
            bool actual = Program.ValidateEmail(email);
            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
