﻿using System.ComponentModel.DataAnnotations;

namespace Web1.entity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }


        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }

        //Navigation
        public Category Category { get; set; }

    }
}
