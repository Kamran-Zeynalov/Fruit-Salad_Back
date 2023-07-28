namespace ProperSalads.Models
{
    public class Fruit : BaseModel
    {
        public string? Name { get; set; }
        public string? Vitamin { get; set; }
        public int Cal { get; set; }
        public List<SaladAndFruit>? SaladAndFruits { get; set; }
        public List<Vitamin>? Vitamins { get; set; }
    }
}
