namespace PASCUA_LabActivity.Models
{
   public enum Rank
    {
        instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean IsTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }

    }
}
