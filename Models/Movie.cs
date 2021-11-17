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
        public string? Title { get; set; }
        [DisplayName("Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Thể loại")]
        public string? Genre { get; set; }
        [DisplayName("Giá bán")]
        public decimal Price { get; set; }
    }
}