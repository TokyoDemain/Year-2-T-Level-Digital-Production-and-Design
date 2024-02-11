using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    internal class Customer
    {
        public string name;
        public int roomNumber = 0;
        public string GetName()
        {
            return name;
        }
        public int GetRoomNumber()
        {
            return roomNumber;
        }
        
    }
}
