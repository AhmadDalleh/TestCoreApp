﻿namespace TestCoreApp.Models
{
    public class Items
    {   

        public int Id{ get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateDate {  get; set; } = DateTime.Now;
    }
}
