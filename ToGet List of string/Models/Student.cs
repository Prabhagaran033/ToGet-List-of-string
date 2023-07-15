using System.ComponentModel.DataAnnotations;

namespace ToGet_List_of_string.Models
{
    public class Student

    {

        [Key]
        public int id { get; set; }

        public string studentName { get; set; }

        public int age { get; set; }




    }
}
