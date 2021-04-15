using Microsoft.AspNetCore.Identity;
using MyWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebModels.Models.Account
{
    public class AppUser : IdentityUser<string>
    {

        [MaxLength(20)]
        [RegularExpression(@"[a-zA-Z0-9\u0600-\u06FF ]+")]
        public string FirstName { get; set; }

        [MaxLength(20)]
        [RegularExpression(@"[a-zA-Z0-9\u0600-\u06FF ]+")]
        public string LastName { get; set; }

        public DateTime ExpireAt { get; set; } = DateTime.UtcNow;

        public string PictureURL { get; set; }

        public List<RefreshTokenVM> RefreshTokens { get; set; }

    }
}
