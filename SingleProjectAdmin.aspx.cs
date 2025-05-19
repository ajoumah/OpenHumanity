using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class SingleProjectAdmin : System.Web.UI.Page
    {
        public static ProjectDetails projectDetails = new ProjectDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            string ProjectId = Request.QueryString["ProjectID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((ProjectId != null) && (CatalogAccess.CheckInProjects(ProjectId)))
            {

                if (projectDetails.Description.ToString().Length > 700)
                {
                    DetailsTextBox.Height = projectDetails.Description.ToString().Length - (projectDetails.Description.ToString().Length) / 4;
                }
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

            string ProjectId = Request.QueryString["ProjectID"];
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
            if ((ProjectId != null) && (CatalogAccess.CheckInProjects(ProjectId)))
            {
                projectDetails = CatalogAccess.GetProjectDetails(ProjectId);

                TitleTextBox.Text = projectDetails.Name;
                DetailsTextBox.Text = projectDetails.Description;
                //DetailsTextBox.Height = projectDetails.Description.ToString().Length ;
                ImageNews.ImageUrl = projectDetails.Logo;
                BenefitNoTextBox.Text = projectDetails.BenefitNo.ToString();
                NotesTextBox.Text = projectDetails.Notes.ToString();

                LabelBelongsTo.Text = projectDetails.SectorName + "/" + projectDetails.ProgramName ;
                //DetailsTextBox.Text = NewsDetails.Details;

                //TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                //TextBoxVideoTitle.Text = NewsDetails.VideoTitle;


                //datepicker.Text = videoDetails.Date.ToString("dd/MM/yyyy");
                DropDownListProjects.Items.Clear();
                
                DataTable programCategories = CatalogAccess.GetAllProgramsForAdmin();
                string programId, programName;

               
                for (int i = 0; i < programCategories.Rows.Count; i++)
                {

                    programId = programCategories.Rows[i]["ProgramID"].ToString();
                    programName = programCategories.Rows[i]["SectorName"].ToString() + "/" + programCategories.Rows[i]["ProgramsName"].ToString();
                    DropDownListProjects.Items.Add(new ListItem() { Text = programName, Value = programId });

                }
                DropDownListProjects.SelectedValue = projectDetails.ProgramID.ToString();








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
            
            string programID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
            string description = DetailsTextBox.Text;
            int benefitNo = int.Parse(BenefitNoTextBox.Text);
            string notes = NotesTextBox.Text;
            
            bool success = false;

            //
            string url = projectDetails.Logo;
            var text = url;
            int metadataStart = text.IndexOf("data:image/jpg;base64,");
            if (metadataStart != -1)
            {

                text = text.Remove(metadataStart, metadataStart + 22);
            }
            byte[] OriginalContent = Convert.FromBase64String(text);

            byte[] content = OriginalContent;
            if (fileupload.HasFile)
            {


                content = fileupload.FileBytes;

            }
            //
             success = CatalogAccess.UpdateProject(projectDetails.ProjectID.ToString(), programID, title, description, content, benefitNo, notes);
            //
            if (success)
            {
                
                projectDetails = CatalogAccess.GetProjectDetails(projectDetails.ProjectID.ToString());
                TitleTextBox.Text = projectDetails.Name;
                DetailsTextBox.Text = projectDetails.Description;
                ImageNews.ImageUrl = projectDetails.Logo;
                BenefitNoTextBox.Text = projectDetails.BenefitNo.ToString();
                NotesTextBox.Text = projectDetails.Notes.ToString();

                LabelBelongsTo.Text = projectDetails.SectorName + "/" + projectDetails.ProgramName;
                if(projectDetails.Description.ToString().Length>700)
                { 
                  DetailsTextBox.Height = projectDetails.Description.ToString().Length - (projectDetails.Description.ToString().Length) / 4;
                }
                ////////

            }
            statusLabel.Text = (success) ? "تم التحديث بنجاح" : "فشل التحديث";
        }
    }
}