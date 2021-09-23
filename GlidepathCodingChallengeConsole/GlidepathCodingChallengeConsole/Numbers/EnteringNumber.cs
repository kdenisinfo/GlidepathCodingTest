using System;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class EnteringNumber : IEnteringNumber
    {
        public int Number { get; private set; }

        public EnteringNumber(string number) {
            this.Number = Int32.Parse(number); // use try parse later
         }
    }
}
