namespace ProperSalads.Models
{
    public class Vitamin : BaseModel
    {
        public string? Name { get; set; }
        public int FruitId { get; set; }
        public Fruit? Fruit { get; set; }
    }
}
