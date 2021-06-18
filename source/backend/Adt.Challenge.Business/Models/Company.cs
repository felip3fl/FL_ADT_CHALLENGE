using System;
using System.Collections.Generic;
using System.Text;

namespace Adt.Challenge.Business.Models
{
    public abstract class Company
    {
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public string FantasyName { get; set; }
        public bool Active { get; set; }
    }
}
