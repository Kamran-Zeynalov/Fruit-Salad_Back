﻿namespace ProperSalads.Models
{
    public class FruitSalad : BaseModel
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public List<SaladAndFruit>? SaladAndFruits { get; set; }
        public List<Size>? Sizes { get; set; }
        public List<Ckal>? Ckals { get; set; }
        public List<Feedback>? FeedBacks { get; set; }





    }
}
