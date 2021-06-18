using System;
using System.Collections.Generic;
using System.Text;

namespace Adt.Challenge.Business.Models
{
    public class Restaurant : Company
    {
        public TimeSpan TimeOpen { get; set; }
        public TimeSpan TimeClosed { get; set; }

    }
}
