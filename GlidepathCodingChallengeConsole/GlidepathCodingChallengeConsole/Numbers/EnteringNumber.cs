using System;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class EnteringNumber : IEnteringNumber
    {
        private string stringnumber { get; set; }
        public int Number { get; private set; }

        public EnteringNumber(string number) {
            this.stringnumber = number;
         }

        public bool ParseNumber()
        {
            //this.Number = Int32.Parse(number,); // anothetr way to use same but will throws exceptions  

            int results;
            bool success = Int32.TryParse(this.stringnumber, out results); // pretty much will have no exceptions

            if (!success) return false;

            return true; 
        }

    }
} 
