using GlidepathCodingChallengeConsole.Numbers;
using NUnit.Framework;

namespace Tests
{
    public class FilesHandlerTest
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
        public void Files_Handler_Checkins_Path()
        {
            var filehandler = new FilesHandler("trial.txt", @"C:\homes\users\");

            var filepath = @"C:\homes\users\trial.txt";

            //Assert
            Assert.AreEqual( filepath, filehandler.FullPathName);
        }

    }
}