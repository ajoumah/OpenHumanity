using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

using Microsoft.AspNet.Identity.Owin;
namespace Onder1
{
    public partial class Administator1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            if (authenticationManager.User.IsInRole("Owner"))
            {
                usersdropdownDropdown.Visible = true;
                link.Visible = true;
            }
            

        }
    }
}