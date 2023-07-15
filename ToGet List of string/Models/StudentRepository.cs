namespace ToGet_List_of_string.Models
{
    public static class StudentRepository
    {
        public static List<Student>Students { get; set; }= new List<Student>()
        {
            new Student
            {
                id = 1,

                studentName="Prabha",

                age=24
            },
             new Student
            {
                id = 2,

                studentName="Deva",

                age=22
            },
              new Student
            {
                id = 3,

                studentName="Thivagar",

                age=24
            }
        };
    }
}
