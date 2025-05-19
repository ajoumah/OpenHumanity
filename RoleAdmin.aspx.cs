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
    public partial class RoleAdmin : System.Web.UI.Page
    {
        public static IdentityRole WHICH = new IdentityRole();
        protected void Page_Load(object sender, EventArgs e)
        {
            string roleId = Request.QueryString["Id"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((roleId != null) && (CatalogAccess.CheckInRole(roleId)))
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
                var roleStore1 = new RoleStore<IdentityRole>();
                var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                WHICH = rolemanager1.FindById(roleId);
                //
                List<IdentityUser> Dt = new List<IdentityUser>();
                List<IdentityUser> SelectedDt = new List<IdentityUser>();
                Dt = manager.Users.ToList();
                List<IdentityUserRole> listOfRole;
                for (int i = 0; i < Dt.Count; i++)
                {
                    listOfRole = Dt[i].Roles.ToList();
                    for (int j = 0; j < listOfRole.Count; j++)
                    {
                        if (listOfRole[j].RoleId == roleId)
                        {
                            SelectedDt.Add(Dt[i]);
                            
                        }

                    }
                }
                for (int i = 0; i < SelectedDt.Count; i++)
                {
                    Dt.Remove(SelectedDt[i]);
                }
                    
                grid.DataSource = SelectedDt;
                grid.PageSize = 70;
                grid.DataBind();
                //
                grid1.DataSource = Dt;
                grid1.PageSize = 70;
                grid1.DataBind();
                RoleNameLabel.Text = WHICH.Name;
                //


            }
        }

        private void PopulateControls()
        {

            string roleId = Request.QueryString["Id"];
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
            if ((roleId != null) && (CatalogAccess.CheckInRole(roleId)))
            {   //
                var roleStore1 = new RoleStore<IdentityRole>();
                var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
                WHICH = rolemanager1.FindById(roleId);
                RoleNameLabel.Text = WHICH.Name;
                ///
                var userStore = new UserStore<IdentityUser>();
                var manager = new UserManager<IdentityUser>(userStore);
                
                List<IdentityUser> Dt = new List<IdentityUser>();
                List<IdentityUser> SelectedDt = new List<IdentityUser>();
                Dt = manager.Users.ToList();
                List<IdentityUserRole> listOfRole;
                for (int i = 0; i < Dt.Count; i++)
                {
                    listOfRole = Dt[i].Roles.ToList();
                    for (int j = 0; j < listOfRole.Count; j++)
                    {
                        if (listOfRole[j].RoleId == roleId)
                        {
                            SelectedDt.Add(Dt[i]);
                           
                        }

                    }
                }
                for (int i = 0; i < SelectedDt.Count; i++)
                {
                    Dt.Remove(SelectedDt[i]);
                }
                CheckBoxListUser.Items.Clear();
                string projectId, projectName;
                for (int i = 0; i < SelectedDt.Count; i++)
                {
                    projectId = SelectedDt[i].Id;
                    projectName = SelectedDt[i].UserName;
                    CheckBoxListUser.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                    CheckBoxListUser.Items[i].Selected = true;

                }
                CheckBoxListUser.DataBind();
                //
                CheckBoxListToJoin.Items.Clear();
                
                for (int i = 0; i < Dt.Count; i++)
                {
                    projectId = Dt[i].Id;
                    projectName = Dt[i].UserName;
                    CheckBoxListToJoin.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                    CheckBoxListToJoin.Items[i].Selected = false;

                }
                CheckBoxListToJoin.DataBind();
                //
                grid.DataSource = SelectedDt;
                grid.PageSize = 70;
                grid.DataBind();
                //
                grid1.DataSource = Dt;
                grid1.PageSize = 70;
                grid1.DataBind();
               
            }
            else
            {


            }


        }
        
        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {



        }
        protected void grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            WHICH = rolemanager1.FindById(WHICH.Id);
            RoleNameLabel.Text = WHICH.Name;
            ///
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            List<IdentityUser> Dt = new List<IdentityUser>();
            List<IdentityUser> SelectedDt = new List<IdentityUser>();
            Dt = manager.Users.ToList();
            List<IdentityUserRole> listOfRole;
            for (int i = 0; i < Dt.Count; i++)
            {
                listOfRole = Dt[i].Roles.ToList();
                for (int j = 0; j < listOfRole.Count; j++)
                {
                    if (listOfRole[j].RoleId == WHICH.Id)
                    {
                        SelectedDt.Add(Dt[i]);
                    }

                }
            }
            for (int i = 0; i < SelectedDt.Count; i++)
            {
                Dt.Remove(SelectedDt[i]);
            }
            CheckBoxListUser.Items.Clear();
            string projectId, projectName;
            for (int i = 0; i < SelectedDt.Count; i++)
            {
                projectId = SelectedDt[i].Id;
                projectName = SelectedDt[i].UserName;
                CheckBoxListUser.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                CheckBoxListUser.Items[i].Selected = true;

            }
            CheckBoxListUser.DataBind();
            //
            CheckBoxListToJoin.Items.Clear();

            for (int i = 0; i < Dt.Count; i++)
            {
                projectId = Dt[i].Id;
                projectName = Dt[i].UserName;
                CheckBoxListToJoin.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                CheckBoxListToJoin.Items[i].Selected = false;

            }
            CheckBoxListToJoin.DataBind();
            //
            grid.DataSource = SelectedDt;
            grid.PageIndex = e.NewPageIndex;
            grid.DataBind();
           
        }
        protected void UpadateButton_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            bool? resultRemove=null;
            bool? resultAdd=null ;
            //
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            List<IdentityRole> listOfAllRole = rolemanager1.Roles.ToList();
            //
            //string projectID = DropDownListProjects.SelectedValue;
           //CheckBoxListUser.DataBind();
            for (int i = 0; i < CheckBoxListUser.Items.Count; i++)
            {
                if (CheckBoxListUser.Items[i].Selected)
                {
                    
                }
                else
                {
                    var result3 = manager.RemoveFromRole(CheckBoxListUser.Items[i].Value,WHICH.Name);
                    if (result3.Succeeded)
                    {
                        resultRemove = true;
                    }
                    else
                    {
                        resultRemove = false;
                        break;
                    }
                }
            }
            
                //statusLabel.Text = "تم التعديل بنجاح";
                for (int i = 0; i < CheckBoxListToJoin.Items.Count; i++)
                {
                    if (CheckBoxListToJoin.Items[i].Selected)
                    {
                        var result3 = manager.AddToRole(CheckBoxListToJoin.Items[i].Value, WHICH.Name);
                        if (result3.Succeeded)
                        {
                           resultAdd = true;
                        }
                        else
                        {
                          resultAdd = false;
                          break;
                        } 
                }
                   
                }
            if (((resultRemove == true)&&(resultAdd==true))|| ((resultRemove == true) && (resultAdd == null))|| ((resultRemove == null) && (resultAdd == true)))
            {
                statusLabel.Text = "تم التعديل بنجاح";
                userStore = new UserStore<IdentityUser>();
                manager = new UserManager<IdentityUser>(userStore);
                List<IdentityUser> Dt = new List<IdentityUser>();
                List<IdentityUser> SelectedDt = new List<IdentityUser>();
                Dt = manager.Users.ToList();
                List<IdentityUserRole> listOfRole;
                for (int i = 0; i < Dt.Count; i++)
                {
                    listOfRole = Dt[i].Roles.ToList();
                    for (int j = 0; j < listOfRole.Count; j++)
                    {
                        if (listOfRole[j].RoleId == WHICH.Id)
                        {
                            SelectedDt.Add(Dt[i]);

                        }

                    }
                }
                for (int i = 0; i < SelectedDt.Count; i++)
                {
                    Dt.Remove(SelectedDt[i]);
                }
                CheckBoxListUser.Items.Clear();
                string projectId, projectName;
                for (int i = 0; i < SelectedDt.Count; i++)
                {
                    projectId = SelectedDt[i].Id;
                    projectName = SelectedDt[i].UserName;
                    CheckBoxListUser.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                    CheckBoxListUser.Items[i].Selected = true;

                }
                CheckBoxListUser.DataBind();
                //
                CheckBoxListToJoin.Items.Clear();

                for (int i = 0; i < Dt.Count; i++)
                {
                    projectId = Dt[i].Id;
                    projectName = Dt[i].UserName;
                    CheckBoxListToJoin.Items.Add(new ListItem() { Text = projectName, Value = projectId });
                    CheckBoxListToJoin.Items[i].Selected = false;

                }
                CheckBoxListUser.DataBind();
                CheckBoxListToJoin.DataBind();
                //
                grid.DataSource = SelectedDt;
                grid.PageSize = 70;
                grid.DataBind();
                //
                grid1.DataSource = Dt;
                grid1.PageSize = 70;
                grid1.DataBind();
                RoleNameLabel.Text = WHICH.Name;
            }
            else
            if((resultRemove == false)||(resultAdd==false))
            {
                statusLabel.Text = "هناك خطأ";
            }

        }

      

     

       
    }
}