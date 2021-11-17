using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Product
    {
        [DisplayName("Số thứ tự")]
        public string ProductID  { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string ProductName  { get; set; }
        [DisplayName("Đơn giá")]
        public string UnitPrice { get; set; }
        [DisplayName("Số lượng")]
        public string Quantity { get; set; }
    }
}