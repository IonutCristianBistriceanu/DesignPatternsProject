﻿using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory.Models.Modern
{
    public class ModernTable : ITable
    {
        public ModernTable(string productFamily, string product, double price)
        {
            ProductFamily = productFamily;
            Product = product;
            Price = price;
        }

        public string ProductFamily { get; }
        public string Product { get; }
        public double Price { get; set; }
    }
}