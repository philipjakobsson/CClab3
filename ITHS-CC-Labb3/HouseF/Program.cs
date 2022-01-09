using HouseF;

HouseFactory factory = new();

House smallHouse = factory.CreateHouse("smallhouse");
Console.WriteLine(smallHouse);
Console.WriteLine("===========================");

House normalHouse = factory.CreateHouse("normalHouse");
Console.WriteLine(normalHouse);
Console.WriteLine("===========================");

House bigHouse = factory.CreateHouse("bighouse");
Console.WriteLine(bigHouse);
Console.WriteLine("===========================");