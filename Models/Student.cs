using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string? Adrres { get; set; }

        public int Age { get; set; }
    }
}