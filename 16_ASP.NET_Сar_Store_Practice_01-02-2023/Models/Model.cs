﻿namespace _16_ASP.NET_Practice_01_02_2023.Models
{
    public class Auto
    {
      public string Brand { get; set; }
      public string Model { get; set; }
      public string Year { get; set; }
      public string Price { get; set; }

      public Auto(string brand, string model, string year, string price)
      {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
      }
    }


}
