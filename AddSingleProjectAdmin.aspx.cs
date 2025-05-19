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
    public partial class AddSingleProjectAdmin : System.Web.UI.Page
    {
        

        public static VideoDetails videoDetails = new VideoDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ProjectId = Request.QueryString["ProjectID"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((ProjectId != null) && (CatalogAccess.CheckInProjects(ProjectId)))
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

           
            string ProjectId = Request.QueryString["ProjectID"];
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
            DataTable programCategories = CatalogAccess.GetAllProgramsForAdmin();
            string programId, programName;

            DropDownListProjects.Items.Add(new ListItem() { Text = "اختر من القائمة", Value = "0" });
            for (int i = 0; i < programCategories.Rows.Count; i++)
            {

                programId = programCategories.Rows[i]["ProgramID"].ToString();
                programName = programCategories.Rows[i]["SectorName"].ToString() + "/" + programCategories.Rows[i]["ProgramsName"].ToString() ;
                DropDownListProjects.Items.Add(new ListItem() { Text = programName, Value = programId });

            }






        }


        protected void CreateButton_Click(object sender, EventArgs e)
        {

            int CreateProjectID = -3;
            string programID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
            string description = DetailsTextBox.Text;
            int benefitNo = int.Parse(BenefitNoTextBox.Text);
            string notes = NotesTextBox.Text;
            byte[] content;
            bool success = false;
            if ((fileupload.HasFile))
            {
                content = fileupload.FileBytes;
                success = CatalogAccess.CreateProject(out CreateProjectID, programID,title, description, content,benefitNo,notes);
            }
            
            if (success)
            {
                Response.Redirect("SingleProjectAdmin.aspx?ProjectID=" + CreateProjectID.ToString() + "&Publish=true");
            }
            else
            {
                statusLabel.Text = "هناك خطأ";
            }



        }



       
    }
}