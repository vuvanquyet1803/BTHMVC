using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Employee
    {
        [DisplayName("Số thứ tự")]
        public string EmployeeID  { get; set; }
        [DisplayName("Họ tên")]
        public string EmployeeName  { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}