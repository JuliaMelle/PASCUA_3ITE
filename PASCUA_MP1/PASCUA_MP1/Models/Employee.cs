﻿namespace PASCUA_MP1.Models
{
    //public enum Rank
    //{
    //    instructor, AssistantProfessor, AssociateProfessor, Professor
    //}
  
    public class Employee
        {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Email { get; set; }
            public Boolean IsTenured { get; set; } 
   
    }
    }
