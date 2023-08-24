namespace ProperSalads.Models
{
    public class FruitCategory : BaseModel
    {
        public int FruitId { get; set; }
        public int CategoryId { get; set; }
        public Fruit? GetFruit { get; set; }
        public Category? GetCategory { get; set; }


    }
}
