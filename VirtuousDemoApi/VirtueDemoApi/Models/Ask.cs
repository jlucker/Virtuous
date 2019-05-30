using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtueDemoApi.Models
{
    public class Ask
    {
        public double Amount;
        public string Frequency;

        public Ask(double amount, string frequency)
        {
            Amount = amount;
            Frequency = frequency;
        }
    }
}
