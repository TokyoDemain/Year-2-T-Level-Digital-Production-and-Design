using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    internal class Checks
    {
        public bool StringPresense(string string1)
        {
            if (string.IsNullOrEmpty(string1)) { return false; }
            else { return true; }
        }
        public bool intPresense(int int1)
        {
            string string1 = int1.ToString();
            if (string.IsNullOrEmpty (string1)) { return false; }
            else { return true; }
        } 
        public bool boolPresense(bool bool1)
        {
            if (bool1 != true & bool1 != false) { return false; }
            else { return true; }
        }
        public bool intBoundryCheck(int upperBound, int lowerBound, int number)
        {
            if (number < upperBound & number > lowerBound) { return true; }
            else { return false; }
        }

    }
}
