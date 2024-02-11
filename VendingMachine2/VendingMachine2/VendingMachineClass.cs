using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    internal class VendingMachingClass
    {

        private int chocolate = 10;
        private int crisps = 10;
        private int water = 10;

        public void BuyChocolate()
        {
            chocolate = chocolate - 1;
        }

        public void BuyWater()
        {
            water = water - 1;
        }

        public void buyCrisps()
        {
            crisps = crisps - 1;
        }

        public int CheckChocolate()
        {
            return chocolate;
        }

        public int CheckWater()
        {
            return water;
        }

        public int CheckCrisps()
        {
            return crisps;
        }
    }
}
