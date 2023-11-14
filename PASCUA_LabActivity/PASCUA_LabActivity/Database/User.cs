using System;
    using Microsoft.AspNetCore.Identity;
namespace PASCUA_LabActivity.Database
{
    public class User : IdentityUser
    {
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }

    }
}
