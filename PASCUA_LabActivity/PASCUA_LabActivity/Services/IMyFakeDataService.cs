using PASCUA_LabActivity.Models;
using System;
namespace PASCUA_LabActivity.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}


