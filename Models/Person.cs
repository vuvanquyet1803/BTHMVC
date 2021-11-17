using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Person
    {
        [DisplayName("Số thứ tự")]
        public string PersonID  { get; set; }
        [DisplayName("Họ tên")]
        public string PersonName  { get; set; }
    }
}