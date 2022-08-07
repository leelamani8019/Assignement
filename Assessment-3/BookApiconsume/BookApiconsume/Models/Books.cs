using System.ComponentModel.DataAnnotations;

namespace BookApiconsume.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Zoner { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }
        public int cost { get; set; }
        [Display(Name = "image")]

        public string? bookimg { get; set; }
    }
}
