using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class BigHouse : House
    {
        public BigHouse()
        {
            NoOfRooms = 8;
            NoOfWindows = 16;
            StreetAdress = "LargeHouse street 1";
            HasSwimmingPool = true;
            ParkingSpotsInGarage = 5;
        }
    }
}