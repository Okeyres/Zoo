using System.ComponentModel.DataAnnotations;

namespace Zoo.Models
{
    public class AnimalEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Range(1, 100)]
        public int Food { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Range(1, 100, ErrorMessage = "Энергии животного не должна превышать 100")]
        public int Energy { get; set; } = 100;
    }
}
