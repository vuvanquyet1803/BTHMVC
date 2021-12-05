using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class LapTop:Computer
    {
        public string NhaSanXuat  { get; set; }
        public string Gia  { get; set; }
    }
}