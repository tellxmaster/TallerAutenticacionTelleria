using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TallerAutenticacionTelleria.Infrastructure
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Administrador"))
            {
                await roleManager.CreateAsync(new IdentityRole("Administrador"));
            }

            if (!await roleManager.RoleExistsAsync("Cliente"))
            {
                await roleManager.CreateAsync(new IdentityRole("Cliente"));
            }

            if (!await roleManager.RoleExistsAsync("Vendedor"))
            {
                await roleManager.CreateAsync(new IdentityRole("Vendedor"));
            }
        }
    }

}