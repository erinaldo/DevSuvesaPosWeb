using DatosFE.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DatosFE.Class
{
    public class Usuarios
    {
        private FEContext entities;
        private UserManager<IdentityUser> manager;
        private SignInManager<IdentityUser> signInManager;



        public Usuarios(UserManager<IdentityUser> manager)
        {
            entities = new FEContext();
            this.manager = manager;
            
        }

        public Usuarios(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
            entities = new FEContext();
        }

        
        public async Task<IdentityResult> crearUsuario(IdentityUser usuario)
        {
            try
            {
                return await manager.CreateAsync(usuario);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SignInResult> ConsultarUsuario(string user, string password)
        {
            try
            {
                return await  signInManager.PasswordSignInAsync(user, password,
                    isPersistent: false, lockoutOnFailure: false); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
