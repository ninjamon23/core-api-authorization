using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Entities
{
    // Extend IdentityUser
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => LastName + ", " + FirstName;
        public DateTime BirthDay { get; set; }
    }
}
