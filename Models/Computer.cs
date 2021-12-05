using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Computer
    {
        public string ID  { get; set; }
        public string Ten  { get; set; }
        public string ThongSo { get; set; }
    }
}