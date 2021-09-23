using System;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class EntryingNumber : IEntryingNumber
    {
        public int Number { get; private set; }

        public EntryingNumber(string number) {
            this.Number = Int32.Parse(number); // use try parse later
         }
    }
}
