namespace ProperSalads.Models
{
    public class Fruit : BaseModel
    {
        public string? Name { get; set; }
        public int Ckal { get; set; }
        public ICollection<SaladAndFruit>? SaladAndFruits { get; set; }
        public ICollection<FruitVitamin>? fruitSaladVitamins { get; set; }
    }
}
