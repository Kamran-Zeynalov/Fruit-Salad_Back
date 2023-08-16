﻿namespace ProperSalads.Models
{
    public class SaladAndFruit : BaseModel
    {
        public int FruitId { get; set; }
        public int FruitSaladId { get; set; }
        public Fruit? Fruit { get; set; }
        public FruitSalad? FruitSalad { get; set; }


    }
}
