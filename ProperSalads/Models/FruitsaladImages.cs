using System.ComponentModel.DataAnnotations.Schema;

namespace ProperSalads.Models
{
    public class FruitsaladImages : BaseModel
    {
        [ForeignKey("FruitSalad")]
        public int Id { get; set; }

        public string? Path { get; set; }
        public virtual FruitSalad? FruitSalad { get; set; }

    }
}
