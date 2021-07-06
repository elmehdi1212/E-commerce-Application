using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        override
        public string Email
        { get; set; }
        [Required]
        [StringLength(256)]
        public string FullName { get; set; }
        [Required]
        [StringLength(256)]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
