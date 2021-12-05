using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        [DisplayName("Số thứ tự")]
        public int Id { get; set; }
        [DisplayName("Tiêu đề")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        [DisplayName("Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Thể loại")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public string? Genre { get; set; }
        [DisplayName("Giá bán")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public decimal Price { get; set; }
        [DisplayName("Xếp hạnh")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}