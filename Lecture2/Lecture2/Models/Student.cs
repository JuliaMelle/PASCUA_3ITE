namespace Lecture2.Models
{
    public enum Major
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
    public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday{ get; set; }
        public Major Major { get; set; }
        public string Email { get; set; }

       
    
    }
}