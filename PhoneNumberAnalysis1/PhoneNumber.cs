using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberAnalysis1
{
    public static class PhoneNumber
    {
        public static(bool nyCode, bool isFake, string lastDigits) Analyze(string number)
        {
            var isNyCode = false;
            var isFake = false;

            if (number.StartsWith("212"))
            {
                isNyCode = true;
            }
            else
            {
                isNyCode= false;
            }

            if (number.Split("-")[1] == "555")
            {
                isFake = true;
            }
            else
            {
                isFake = false;
            }

            return(isNyCode, isFake, number.Split("-")[2]);
        }
        public static bool isFake((bool nyCode, bool isFake, string lastDigits) input)
        {
            return input.isFake;
        }
    }
}
