using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachingClass
    {

        private int chocolate = 10;
        private int crisps = 10;
        private int water = 10;

        public void BuyCocolate()
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

        public Tuple<int,int,int> CheckStock()
        {

            return Tuple.Create(chocolate, crisps, water);
        }

    }
}
