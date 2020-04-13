using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakingInBits.Models
{
    public static class IdentityHelper
    {
        public static void SetIdentityOptions(IdentityOptions options)
        {
            // Set Sign In Options
            options.SignIn.RequireConfirmedAccount = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;

            // Set Password Strength
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;

            // Set Lockout Options
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            options.Lockout.MaxFailedAccessAttempts = 5;
        }
    }
}
