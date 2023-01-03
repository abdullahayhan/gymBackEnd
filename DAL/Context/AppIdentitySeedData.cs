using Microsoft.AspNetCore.Identity;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class AppIdentitySeedData
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Admin",
                    UserName="Admin",
                    Email = "arenagym@gmail.com",
                };
                var x = await userManager.CreateAsync(user, "aA.&12345");
            }
        }
    }
}
