using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;

namespace Onder1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var user = new IdentityUser() { UserName = UserName.Text };
            ////////////
            var userStore1 = new RoleStore<IdentityRole>();
            var manager1 = new RoleManager<IdentityRole>(userStore1);
            var user1 = new IdentityRole() { Name = "Administrators" };
            ///////////
            IdentityResult result = manager.Create(user, Password.Text);
            IdentityResult result1 = manager1.Create(user1);
            /////////
            var result3 = manager.AddToRole(user.Id, "Administrators");
            //manager.GetRoles();
            //var roles = (from r in manager1.Roles select r.Name).ToList();
            ///
            if (result.Succeeded)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                StatusMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}