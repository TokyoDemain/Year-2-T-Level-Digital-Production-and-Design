using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelApp
{
    internal class Hotel
    {
        Dictionary<int, Room> roomsDict = new Dictionary<int, Room>();
        Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
        Dictionary<int, bool> availabilityDict = new Dictionary<int, bool>();
        public int count = 0;
        public Hotel()
        {
            IEnumerable<int> rooms = Enumerable.Range(1, 40);
            foreach (int i in rooms)
            {
                Room room = new Room();
                roomsDict.Add(i, room);
            }
        }

        public bool BookRoom(int roomNumber, string customerName)
        {
            Checks checks = new Checks();
            if (checks.intBoundryCheck(1,40,roomNumber) == true) {
                if (customers.ContainsKey(customerName))
                {
                    Customer customer1 = customers[customerName];
                    if (customer1.roomNumber == 0)
                    {
                        customers[customerName].roomNumber = roomNumber;
                        Customer customer = customers[customerName];
                        customer.roomNumber = roomNumber;
                        roomsDict[roomNumber].OccupyRoom();
                        count = count = 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Customer customer = new Customer();
                customer.roomNumber = roomNumber;
                customer.name = customerName;
                roomsDict[roomNumber].OccupyRoom();
                customers.Add(customerName, customer);
                count = count + 1;
                return true;
            }
        }

        public bool VacateRoom(string customername)
        {
            if (customers.ContainsKey(customername))
            {
                Customer customer1 = customers[customername];
                if (customer1.roomNumber != 0)
                {
                    Customer customer = customers[customername];
                    int roomNumber = customer.roomNumber;
                    roomsDict[roomNumber].Vacate();
                    customer.roomNumber = 0;
                    count = count - 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int ShowIncome()
        {
            return count * 120;
        }

        public int ReportOnName(string customerName)
        {
            if (customers.ContainsKey(customerName))
            {
                Customer customer = customers[customerName];
                int roomNumber = customer.roomNumber;
                return roomNumber;
            }
            else
            {
                return 0;
            }
        }

        public new Dictionary<int, bool> ReportOnAllRooms()
        {
            IEnumerable<int> rooms2 = Enumerable.Range(1, 40);
            foreach (int i in rooms2)
            {
                availabilityDict[i] = roomsDict[i].roomTaken;
            }
            return availabilityDict;
        }

       
    }
}
