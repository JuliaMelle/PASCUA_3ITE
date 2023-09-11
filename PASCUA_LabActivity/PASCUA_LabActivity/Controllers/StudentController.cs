﻿using Microsoft.AspNetCore.Mvc;
using PASCUA_LabActivity.Models;


namespace PASCUA_LabActivity.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
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
        public IActionResult Index()
        {
            
            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}