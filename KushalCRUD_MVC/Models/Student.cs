namespace KushalCRUD_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
    }
}
