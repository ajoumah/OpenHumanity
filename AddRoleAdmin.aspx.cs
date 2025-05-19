using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Web.UI.HtmlControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.DataProtection;
namespace Onder1
{
    public partial class AddRoleAdmin : System.Web.UI.Page
    {
        public static IdentityRole WHICH = new IdentityRole();
        protected void Page_Load(object sender, EventArgs e)
        {
            string roleId = Request.QueryString["Id"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((roleId != null) && (CatalogAccess.CheckInRole(roleId)))
            {
                var userStore = new UserStore<IdentityUser>();
                var manager = new UserManager<IdentityUser>(userStore);
                var roleStore1 = new RoleStore<IdentityRole>();
                var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                WHICH = rolemanager1.FindById(roleId);

                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "";


                hex = "#ff9102";


                BackgoundStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                bodyStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(hex);

                Style BorderStyle1 = new Style();
                Color BorderColor = new Color();
                BorderColor = System.Drawing.ColorTranslator.FromHtml(hex);
                BorderStyle1.BorderStyle = BorderStyle.Solid;
                BorderStyle1.BorderWidth = Unit.Parse("2");
                BorderStyle1.BorderColor = BorderColor;

                Page.Header.StyleSheet.CreateStyleRule(BorderStyle1, null, ".BorderSectorColor");
                Page.Header.StyleSheet.CreateStyleRule(bodyStyle, null, ".SectorColor");
                Page.Header.StyleSheet.CreateStyleRule(BackgoundStyle, null, ".SectorBackgoundColor");

            }
        }

        private void PopulateControls()
        {

            string roleId = Request.QueryString["Id"];
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            WHICH = rolemanager1.FindById(roleId);
            Style bodyStyle = new Style();
            Style BackgoundStyle = new Style();

            string hex = "";


            hex = "#ff9102";


            BackgoundStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
            bodyStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(hex);

            Style BorderStyle1 = new Style();
            Color BorderColor = new Color();
            BorderColor = System.Drawing.ColorTranslator.FromHtml(hex);
            BorderStyle1.BorderStyle = BorderStyle.Solid;
            BorderStyle1.BorderWidth = Unit.Parse("2");
            BorderStyle1.BorderColor = BorderColor;

            Page.Header.StyleSheet.CreateStyleRule(BorderStyle1, null, ".BorderSectorColor");
            Page.Header.StyleSheet.CreateStyleRule(bodyStyle, null, ".SectorColor");
            Page.Header.StyleSheet.CreateStyleRule(BackgoundStyle, null, ".SectorBackgoundColor");

        }


        protected void CreateButton_Click(object sender, EventArgs e)
        {

            string title = TitleTextBox.Text;
              
            IdentityResult result1=new IdentityResult();
            
            if ((title.Length>0))
            {
                var userStore1 = new RoleStore<IdentityRole>();
                var manager1 = new RoleManager<IdentityRole>(userStore1);
                var role1 = new IdentityRole() { Name = title };
                result1 = manager1.Create(role1);
                if (result1.Succeeded)
                {
                    var roleStore1 = new RoleStore<IdentityRole>();
                    var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                    WHICH = rolemanager1.FindByName(title);
                    Response.Redirect("RoleAdmin.aspx?Id=" + WHICH.Id + "&Publish=true");
                }
                else
                {
                    statusLabel.Text = "هناك خطأ";
                }
            }
            //



            



        }
    }
}