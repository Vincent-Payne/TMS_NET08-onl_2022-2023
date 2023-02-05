namespace _16_ASP.NET_Practice_01_02_2023.Models
{
    [Serializable]
    public class Auto
    {
      public uint Id { get; set; }
      public string Brand { get; set; }
      public string Model { get; set; }
      public string Year { get; set; }
      public string Price { get; set; }
      public Auto(uint id, string brand, string model, string year, string price)
      {
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
      }
    }


}
