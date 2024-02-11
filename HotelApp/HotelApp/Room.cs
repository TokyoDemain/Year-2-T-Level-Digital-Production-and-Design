using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    internal class Room
    {
        private int roomNumber;
        public bool roomTaken = false;

        public string GetCustomerName()
        {
            Customer customer = new Customer();
            return customer.GetName();
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public bool IsOccupied()
        {
            return roomTaken;
        }

        public void OccupyRoom()
        {
            roomTaken = true;
        }
        
        public void Vacate()
        {
            roomTaken = false;
        }
    }

}
