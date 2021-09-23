using System;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class AddingNumbers : IAddingNumbers
    {
        public int NumberOne { get; private set; }
        public int NumberTwo { get; private set; }
        public int TotalNumber { get; private set; }

        public AddingNumbers(int numberone, int numbertwo)
        {
            this.NumberOne = numberone;
            this.NumberTwo = numbertwo;

            this.TotalNumber = NumberOne + NumberTwo;

            if (this.TotalNumber > 152) this.TotalNumber -= 152;
        }

        public void DisplayingNumber() { Console.Write("total number is: " + TotalNumber); }
    }

    //public class DisplayingNumber {
    //    private int totalnumber { get; set; }

    //    public DisplayingNumber(int totalnumber) { this.totalnumber = totalnumber; }
    }
