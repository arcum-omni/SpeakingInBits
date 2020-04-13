using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SpeakingInBits.Models
{
    public static class IdentityHelper
    {
        // Role Names
        public const string InstructorRole = "Instructor";
        public const string StudentRole = "Student";

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

        public static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            RoleManager<IdentityRole> roleMgr = provider.GetRequiredService<RoleManager<IdentityRole>>();

            // create role if it does not exist
            foreach (string role in roles)
            {
                bool doesRoleExist = await roleMgr.RoleExistsAsync(role);

                if (!doesRoleExist)
                {
                    await roleMgr.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
