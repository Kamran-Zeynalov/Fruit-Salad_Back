namespace ProperSalads.Models
{
    public class FruitSalad : BaseModel
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public List<SaladAndFruit>? SaladAndFruits { get; set; }
        public List<FruitSaladSize>? fruitSaladSizes { get; set; }

        public List<Feedback>? FeedBacks { get; set; }
        public virtual FruitsaladImages? GetFruitsaladImages { get; set; }





    }
}
