﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private readonly Dictionary<string, Type> _houses;
        public HouseFactory()
        {
            _houses = LoadHouses();
        }

        public House CreateHouse(string houseName)
        {
            ArgumentNullException.ThrowIfNull(houseName);
            return GetHouseFromDictionary(houseName);
        }

        private Dictionary<string, Type> LoadHouses()
        {
            Dictionary<string, Type> availableHouses = new();

            availableHouses.Add("smallhouse", typeof(SmallHouse));
            availableHouses.Add("normalhouse", typeof(NormalHouse));
            availableHouses.Add("bighouse", typeof(BigHouse));

            return availableHouses;
        }

        private House GetHouseFromDictionary(string houseName)
        {
            try
            {
                Type type = _houses[houseName.ToLower()];
                return (House)Activator.CreateInstance(type);
            }
            catch
            {
                throw new KeyNotFoundException($"{houseName} was not found in the factory");
            }
        }
    }
}
