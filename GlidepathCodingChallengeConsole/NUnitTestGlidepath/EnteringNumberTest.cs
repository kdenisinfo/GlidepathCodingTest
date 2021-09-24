using GlidepathCodingChallengeConsole.Numbers;
using NUnit.Framework;
using System;

namespace Tests
{
    public class EnteringNumberTest
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

        // this required for Parse method
        [Test]
        public void Entered_Number_Format_Invalid_()
        {
            var entering = new EnteringNumber("rf6w1e2217t");

            //Assert
            Assert.AreEqual(entering.ParseNumber(), false);
        }

        [Test]
        public void Entered_Number_Format_Valid_()
        {
            var entering = new EnteringNumber("1265");

            //Assert
            Assert.AreEqual(entering.ParseNumber(), true);
        }

        // this required for Parse method
        //[Test]
        //public void Entered_Number_Format_Invalid()
        //{
        //    //Assert
        //    Assert.Throws<FormatException>(()=>new EnteringNumber("rf6w1e2217t"));
        //}

    }
}