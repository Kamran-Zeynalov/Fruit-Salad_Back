namespace ProperSalads.Models
{
    public class SaladAndFruit : BaseModel
    {
        public int FruitId { get; set; }
        public string? Name { get; set; }
        public Fruit? Fruit { get; set; }
        public FruitSalad? FruitSalad { get; set; }


    }
}
