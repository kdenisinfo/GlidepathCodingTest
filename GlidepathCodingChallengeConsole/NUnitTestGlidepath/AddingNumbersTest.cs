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
        public void Adding_Numbers_Total_Numbers_Checkins_LessThan152()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(6 , 7);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(13, totalnumber);
        }

        [Test]
        public void Adding_Numbers_Total_Numbers_Chekins_MoreThan152()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(78, 137);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(63, totalnumber);
        }

       [Test]
        public void Adding_Numbers_Total_Numbers_Chekins_EqualTo152()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(100, 52);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(152, totalnumber);
        }

        [Test]
        public void Adding_Numbers_Total_Numbers_Chekins_Negative()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(-100, 52);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(-48, totalnumber);
        }

        [Test]
        public void Adding_Numbers_Total_Numbers_Chekins_Negative_Both()
        {
            // Arrange
            var addingnumbers = new AddingNumbers(-100, -52);

            // Act
            var totalnumber = addingnumbers.TotalNumber;

            //Assert
            Assert.AreEqual(-152, totalnumber);
        }
    }
}