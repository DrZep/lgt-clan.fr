using lgt.clan.fr.Data.Interfaces;
using lgt.clan.fr.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public DbInitializer(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initalize()
        {
            _context.Database.EnsureCreated();
           
            if (!_context.Roles.Any())
            {
                var applicationRoles = new ApplicationRole[]
                {
                    new ApplicationRole{ CreatedDate = DateTime.UtcNow, Name= "SuperAdmin", Description= "Rôle destiné au developpeur" },
                    new ApplicationRole{ CreatedDate = DateTime.UtcNow, Name= "Admin", Description= "Rôle permettant l'accès à l'administration" },
                    new ApplicationRole{ CreatedDate = DateTime.UtcNow, Name= "User", Description= "Role de base utilisé pour les inscriptions par défaut." }
                };
                foreach (var ar in applicationRoles)
                {
                    _roleManager.CreateAsync(ar);
                }

                //Create the SuperAdmin Role
                //_roleManager.CreateAsync(new ApplicationRole("SuperAdmin"));
            }
        }
    }
}
