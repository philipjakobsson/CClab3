using NUnit.Framework;
using HouseF;
using HouseFB;
using System;
using System.Collections.Generic;

namespace HouseF.Tests
{
    [TestFixture]
    public class HouseFactoryTest
    {
        HouseFactory houseFactory;
        House smallHouse;
        House normalHouse;
        House bigHouse;

        public void OneTimeSetup()
        {
            houseFactory = new HouseFactory();
            smallHouse = houseFactory.CreateHouse("smallhouse");
            normalHouse = houseFactory.CreateHouse("normalhouse");
            bigHouse = houseFactory.CreateHouse("bighouse");
        }

        [TestCase("smallhouse")]
        public void CreateHouse_GivenString_smallhouse_ReturnTypeSmallHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<SmallHouse>());
        }

        [TestCase("normalhouse")]
        public void CreateHouse_GivenString_mediumhouse_ReturnTypeNormalHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<NormalHouse>());
        }

        [TestCase("bighouse")]
        public void CreateHouse_GivenString_bighouse_ReturnTypeBigHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<BigHouse>());
        }

        [TestCase("faultyKey")]
        public void CreateHouse_GivenFaultyKey_ThrowsKeyNotFoundException(string houseName)
        {
            Assert.Throws<KeyNotFoundException>(() => houseFactory.CreateHouse(houseName));
        }

        [Test]
        public void CreateHouse_SmallHouseHasGarageAndSwimmingPool_IsFalse()
        {
            Assert.That(smallHouse.HasGarage && smallHouse.HasSwimmingPool, Is.False);
        }

        [Test]
        public void CreateHouse_BigHouseHasGarageAndSwimmingPool_IsTrue()
        {
            Assert.That(bigHouse.HasGarage && bigHouse.HasSwimmingPool, Is.True);
        }

        [Test]
        public void CreateHouse_GivenSmallHouse_NoOfRoomsIsEqualToOne()
        {
            Assert.That(smallHouse.NoOfRooms, Is.EqualTo(1));
        }

    }
}