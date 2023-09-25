using PASCUA_LabActivity.Models;
using PASCUA_LabActivity.Services;
namespace PASCUA_LabActivity.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get;}
        public List<Instructor> InstructorList { get; }
        //Contructor
        public MyFakeDataService()
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Julia",LastName = "Pascua", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-07-19"), GPA = 1.0, Email = "jm@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Jul",LastName = "Toledo", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-12-05"), GPA = 1, Email = "jayemp@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Alexa",LastName = "Chua", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-02-15"), GPA = 1.5, Email = "ac@gmail.com"
                }
            };
            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Jm",LastName = "Pascua",IsTenured=true, Rank = Rank.instructor,HiringDate = DateTime.Parse("2022-07-19"),
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Jul",LastName = "Toledo", IsTenured=true,  Rank = Rank.AssistantProfessor,HiringDate = DateTime.Parse("2022-12-05")
                }
            };
        } // public MFDS
    }
}
