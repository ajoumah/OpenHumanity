using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace Onder1
{
    public partial class AddSingleImageAdmin : System.Web.UI.Page
    {
        public static ImageDetails imageDetails = new ImageDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            string imageId = Request.QueryString["ImageID"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((imageId != null) && (CatalogAccess.CheckInImage(imageId)))
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

            }
        }

        private void PopulateControls()
        {

            string imageId = Request.QueryString["ImageID"];

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



            
            DropDownListProjects.Items.Clear();
            DataTable projectsCategories = CatalogAccess.GetAllProjectsForAdmin();
            string projectId, projectName;

            DropDownListProjects.Items.Add(new ListItem() { Text = "اختر من القائمة", Value = "0" });
            for (int i = 0; i < projectsCategories.Rows.Count; i++)
            {

                projectId = projectsCategories.Rows[i]["ProjectID"].ToString();
                projectName = projectsCategories.Rows[i]["SectorName"].ToString() + "/" + projectsCategories.Rows[i]["ProgramsName"].ToString() + "/" + projectsCategories.Rows[i]["ProjectsName"].ToString();
                DropDownListProjects.Items.Add(new ListItem() { Text = projectName, Value = projectId });

            }
            





        }

        
        protected void CreateButton_Click(object sender, EventArgs e)
        {

            int CreateImageID = -3;
            string projectID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
           
            DateTime date = Convert.ToDateTime(datepicker.Text);

            bool success = false;
           
            byte[] content;
            if ((fileupload.HasFile) )
            {
                content = fileupload.FileBytes;
                success = CatalogAccess.CreateImage(out CreateImageID, projectID, title, date, content);
                //PrimaryImage = CatalogAccess.InsertImageByIDForAdmin(CreateNewsID.ToString(), content, true, false);
            }
            //


            
            if (success )
            {
                Response.Redirect("SingleImageAdmin.aspx?ImageID=" + CreateImageID.ToString() + "&Publish=true");
            }
            else
            {
                statusLabel.Text = "هناك خطأ";   
            }
            


        }

        

        
    }
}