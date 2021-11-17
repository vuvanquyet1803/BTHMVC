using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Student
    {
        [DisplayName("Số thứ tự")]
        public int Id { get; set; }
        [DisplayName("Họ tên")]
        public string? Name { get; set; }
        [DisplayName("Ngày sinh")]

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        [DisplayName("Địa chỉ")]
        public string? Adrres { get; set; }
        [DisplayName("Tuổi")]
        public int Age { get; set; }
    }
}