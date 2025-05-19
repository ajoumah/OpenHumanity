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
    public partial class SingleProgramAdmin : System.Web.UI.Page
    {
        public static ProgramDetails programDetails = new ProgramDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            string ProgramId = Request.QueryString["ProgramID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((ProgramId != null) && (CatalogAccess.CheckInPrograms(ProgramId)))
            {

                if (programDetails.Description.ToString().Length > 700)
                {
                    DetailsTextBox.Height = programDetails.Description.ToString().Length - (programDetails.Description.ToString().Length) / 4;
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

            string ProgramId = Request.QueryString["ProgramID"];
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
            if ((ProgramId != null) && (CatalogAccess.CheckInProjects(ProgramId)))
            {
                programDetails = CatalogAccess.GetProgramDetailsForAdmin(ProgramId);

                TitleTextBox.Text = programDetails.Name;
                DetailsTextBox.Text = programDetails.Description;
                //DetailsTextBox.Height = projectDetails.Description.ToString().Length ;
                ImageNews.ImageUrl = programDetails.Logo;
                
                NotesTextBox.Text = programDetails.Notes.ToString();

                LabelBelongsTo.Text = programDetails.SectorName ;
                
                DropDownListProjects.Items.Clear();

                DataTable sectorCategories = CatalogAccess.GetAllSectorsForAdmin();
                string sectorId, sectorName;


                for (int i = 0; i < sectorCategories.Rows.Count; i++)
                {

                    sectorId = sectorCategories.Rows[i]["SectorID"].ToString();
                    sectorName = sectorCategories.Rows[i]["Name"].ToString() ;
                    DropDownListProjects.Items.Add(new ListItem() { Text = sectorName, Value = sectorId });

                }
                DropDownListProjects.SelectedValue = programDetails.SectorID.ToString();


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

            string sectorID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
            string description = DetailsTextBox.Text;
            
            string notes = NotesTextBox.Text;

            bool success = false;

            //
            string url = programDetails.Logo;
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
            success = CatalogAccess.UpdateProgram(programDetails.ProgramID.ToString(), sectorID, title, description, content,  notes);
            //
            if (success)
            {

                programDetails = CatalogAccess.GetProgramDetailsForAdmin(programDetails.ProgramID.ToString());
                TitleTextBox.Text = programDetails.Name;
                DetailsTextBox.Text = programDetails.Description;
                ImageNews.ImageUrl = programDetails.Logo;
               
                NotesTextBox.Text = programDetails.Notes.ToString();

                LabelBelongsTo.Text = programDetails.SectorName ;
                if (programDetails.Description.ToString().Length > 700)
                {
                    DetailsTextBox.Height = programDetails.Description.ToString().Length - (programDetails.Description.ToString().Length) / 4;
                }
                ////////

            }
            statusLabel.Text = (success) ? "تم التحديث بنجاح" : "فشل التحديث";
        }
    }
}