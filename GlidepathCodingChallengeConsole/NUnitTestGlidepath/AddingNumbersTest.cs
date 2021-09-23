using GlidepathCodingChallengeConsole.Numbers;
using NUnit.Framework;

namespace Tests
{
    public class AddingNumbersTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestPass()
        {
            //Assert
            Assert.Pass();
        }

        [Test]
        public void AddingNumbers_TotalNumbers_Colculations()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(6 , 7);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(13, totalnumber);
        }

        [Test]
        public void AddingNumbers_TotalNumbers_Calculations_MoreThan152()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(78, 137);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(63, totalnumber);
        }
    }
}