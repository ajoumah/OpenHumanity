using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.DataProtection;

namespace Onder1
{
    public partial class UserAdmin : System.Web.UI.Page
    {
        
        public static IdentityUser WHO = new IdentityUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = Request.QueryString["Id"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((userId != null) && (CatalogAccess.CheckInUser(userId)))
            {
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
                //
                var userStore = new UserStore<IdentityUser>();
                var manager = new UserManager<IdentityUser>(userStore);
                //var user = new IdentityUser() { UserName = UserName.Text };
                manager.Users.ToList();
                WHO = manager.FindById(userId);
                List<IdentityUserRole> listOfRole = WHO.Roles.ToList();
                IdentityRole iRole = new IdentityRole();
                string roleId, roleName;
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(string));
                table.Columns.Add("Name", typeof(string));
                var roleStore1 = new RoleStore<IdentityRole>();
                var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                for (int i = 0; i < listOfRole.Count; i++)
                {
                    iRole = rolemanager1.FindById(listOfRole[i].RoleId);
                    roleName = iRole.Name;
                    roleId = iRole.Id;
                    table.Rows.Add(roleId, roleName);

                }
                grid.DataSource = table;
                grid.DataBind();

            }
        }

        private void PopulateControls()
        {

            string userId = Request.QueryString["Id"];
            bool isTrue = Request.QueryString["Publish"] == "true";
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
            if (Request.QueryString["Publish"] != null)
            {
                isTrue = Request.QueryString["Publish"] == "true";
                statusLabel.Text = (isTrue) ? "تم النشر بنجاح" : "فشل النشر";
            }
            if ((userId != null) && (CatalogAccess.CheckInUser(userId)))
            {
                var userStore = new UserStore<IdentityUser>();
                var manager = new UserManager<IdentityUser>(userStore);
                //var user = new IdentityUser() { UserName = UserName.Text };
                manager.Users.ToList();
                WHO = manager.FindById(userId);
                
                var roleStore1 = new RoleStore<IdentityRole>();
                var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                
                LabelUserName.Text = WHO.UserName;
                
                List<IdentityUserRole> listOfRole = WHO.Roles.ToList();
                
                string[] rolesArray=new string[10];
                IdentityRole iRole = new IdentityRole();
                //
               
                string roleId, roleName;

                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(string));
                table.Columns.Add("Name", typeof(string));
                

                
                for (int i=0;i< listOfRole.Count;i++) 
                {
                    iRole = rolemanager1.FindById(listOfRole[i].RoleId);
                    roleName = iRole.Name;
                    roleId= iRole.Id;
                    table.Rows.Add(roleId, roleName);
                    
                }
                
                grid.DataSource = table;
                grid.DataBind();
                

                //DropDownListProjects.Items.Clear();
                rolemanager1.Roles.ToList();
                List<IdentityRole> listOfAllRole = rolemanager1.Roles.ToList();
                //DataTable projectsCategories = rolemanager1.Roles.ToList(); ;
                string projectId, projectName;
                for (int i = 0; i < listOfAllRole.Count; i++)
                {

                    projectId = listOfAllRole[i].Id;
                    projectName = listOfAllRole[i].Name;
                    CheckBoxList1.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                    if (listOfRole.Exists(x => x.RoleId== projectId))
                    {
                        CheckBoxList1.Items[i].Selected = true;
                    }

                }
                CheckBoxList1.DataBind();
                

            }
            else
            {


            }


        }

        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            

        }

        protected void UpadateButton_Click(object sender, EventArgs e)
        {
            //
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            //
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            List<IdentityRole> listOfAllRole = rolemanager1.Roles.ToList();
            //
            //string projectID = DropDownListProjects.SelectedValue;
            CheckBoxList1.DataBind();
            for (int i=0;i< listOfAllRole.Count; i++)
            {
              if(  CheckBoxList1.Items[i].Selected)
                {
                    var result3 = manager.AddToRole(WHO.Id, CheckBoxList1.Items[i].Text);
                }
              else
                {
                    var result3 = manager.RemoveFromRole(WHO.Id, CheckBoxList1.Items[i].Text);
                }
            }

            manager.Users.ToList();
            WHO = manager.FindById(WHO.Id);
            List<IdentityUserRole> listOfRole = WHO.Roles.ToList();
            IdentityRole iRole = new IdentityRole();
            string roleId, roleName;
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Name", typeof(string));

            for (int i = 0; i < listOfRole.Count; i++)
            {
                iRole = rolemanager1.FindById(listOfRole[i].RoleId);
                roleName = iRole.Name;
                roleId = iRole.Id;
                table.Rows.Add(roleId, roleName);

            }
            grid.DataSource = table;
            grid.DataBind();
            
        }

        protected void DisableButton_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            IdentityResult userResult = manager.RemovePassword(WHO.Id);
            if (userResult.Succeeded)
            {
                statusLabel.Text = "تم تعطيل المتسخدم";
            }
        }

        protected void ActivateButton_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            //
            var provider = new Microsoft.Owin.Security.DataProtection.DpapiDataProtectionProvider("Sample");
            manager.UserTokenProvider = new Microsoft.AspNet.Identity.Owin.DataProtectorTokenProvider<IdentityUser>(provider.Create("EmailConfirmation"));
            string code = manager.GeneratePasswordResetToken(WHO.Id);
            IdentityResult userResult = manager.ResetPassword(WHO.Id, code, Password.Text);
            if(userResult.Succeeded)
            {
                statusLabel.Text = "تم تفعيل المستخدم وتغيير كلمة المرور بنجاح";
            }
            

            
        }
    }
}