using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.moodle
{
    class LotteryTicket
    {
        public int NumberCode { get; set; }

        public LotteryTicket(int numberCode)
        {
            NumberCode = numberCode;
        }
    }
}
