using System;

namespace GlidepathCodingChallengeConsole.Numbers
{
    public class EntryingNumber : IEntryingNumber
    {
        public int Number { get; private set; }

        public EntryingNumber(string[] args) {
            this.Number = Int32.Parse(args[0]);
        }
    }

    //public class DisplayingNumber {
    //    private int totalnumber { get; set; }

    //    public DisplayingNumber(int totalnumber) { this.totalnumber = totalnumber; }
    }
