using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI.WebControls;

using System.Linq;

using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
namespace Onder1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    StatusText.Text = string.Format("Hello {0}!!", User.Identity.GetUserName());
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;

                    //if (User.IsInRole("Admin "))
                    //{     
                    // Label1.Text="the user "+ User.Identity.GetUserName() + "is in Admin Role";
                    //}
                    //else
                    //{
                    //    Label1.Text = "the user is not  "+" " + User.Identity.GetUserName() +  " in Admin Role";
                    //}
                    ////////////
                    var userStore1 = new RoleStore<IdentityRole>();
                    var manager1 = new RoleManager<IdentityRole>(userStore1);
                    //var user1 = new IdentityRole() { Name = "Admin " };
                    ///////////

                    //IdentityResult result1 = manager1.Create(user1);
                    /////////

                    //manager.GetRoles();
                    //var roles = (from r in manager1.Roles select r.Name).ToList();
                    //Label1.Text = "here are all roles  " + " " + User.;
                    var userStore = new UserStore<IdentityUser>();
                    var manager = new UserManager<IdentityUser>(userStore);
                    var userStore2 = new RoleStore<IdentityRole>();
                    var manager2 = new RoleManager<IdentityRole>(userStore2);
                    var users = manager.Users;
                    var roles = new List<string>();
                    string userId = User.Identity.GetUserId();

                    // get user roles
                    //List<string> roles5 = manager.GetRoles(userId).;
                    //LabelUSer.Text = users.ToString();
                    //LabelRole.Text = roles5.ToString();
                    var user5 = manager.FindById(userId);
                    var roles8 = manager.GetRoles(userId);
                    if (roles8.Count!=0) { 
                    LabelRole.Text = roles8[0].ToString();
                    }
                    //OK(new { User = user, Roles = roles });
                }
                else
                {
                    LoginForm.Visible = true;
                }
                // Default UserStore constructor uses the default connection string named: DefaultConnection


                ///

            }
        }
        
            protected void SignIn(object sender, EventArgs e)
            {
                var userStore = new UserStore<IdentityUser>();
                var userManager = new UserManager<IdentityUser>(userStore);
                var user = userManager.Find(UserName.Text, Password.Text);

                if (user != null)
                {
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                    Response.Redirect("~/Login.aspx");
                }
                else
                {
                    StatusText.Text = "Invalid username or password.";
                    LoginStatus.Visible = true;
                }
            }

            protected void SignOut(object sender, EventArgs e)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                authenticationManager.SignOut();
                Response.Redirect("~/Login.aspx");
            }

        }
}
