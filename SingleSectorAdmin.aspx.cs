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
    public partial class SingleSectorAdmin : System.Web.UI.Page
    {
        public static SectorDetails sectorDetails = new SectorDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            string SectorId = Request.QueryString["SectorID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((SectorId != null) && (CatalogAccess.CheckInSectors(SectorId)))
            {

                if (sectorDetails.Description.ToString().Length > 700)
                {
                    DetailsTextBox.Height = sectorDetails.Description.ToString().Length - (sectorDetails.Description.ToString().Length) / 4;
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

            string SectorId = Request.QueryString["SectorID"];
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
            if ((SectorId != null) && (CatalogAccess.CheckInSectors(SectorId)))
            {
                sectorDetails = CatalogAccess.GetSectorDetails(SectorId);

                TitleTextBox.Text = sectorDetails.Name;
                DetailsTextBox.Text = sectorDetails.Description;
                //DetailsTextBox.Height = projectDetails.Description.ToString().Length ;
                ImageNews.ImageUrl = sectorDetails.Logo;
                StructureImage.ImageUrl = sectorDetails.Skeleton;
                NotesTextBox.Text = sectorDetails.Notes.ToString();
                           

                


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

            

            string title = TitleTextBox.Text;
            string description = DetailsTextBox.Text;

            string notes = NotesTextBox.Text;

            bool success = false;

            //
            string url = sectorDetails.Logo;
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
            string urlStruct = sectorDetails.Skeleton;
            var textStruct = urlStruct;
            int metadataStartStruct = textStruct.IndexOf("data:image/jpg;base64,");
            if (metadataStartStruct != -1)
            {

                textStruct = textStruct.Remove(metadataStartStruct, metadataStartStruct + 22);
            }
            byte[] OriginalContentStruct = Convert.FromBase64String(textStruct);

            byte[] contentStruct = OriginalContentStruct;
            if (fileupload1.HasFile)
            {
                contentStruct = fileupload1.FileBytes;
            }
            //
            success = CatalogAccess.UpdateSector(sectorDetails.SectorID.ToString(),  title, description, contentStruct, content, notes);
            //
            if (success)
            {

                sectorDetails = CatalogAccess.GetSectorDetails(sectorDetails.SectorID.ToString());
                TitleTextBox.Text = sectorDetails.Name;
                DetailsTextBox.Text = sectorDetails.Description;
                ImageNews.ImageUrl = sectorDetails.Logo;
                StructureImage.ImageUrl = sectorDetails.Skeleton;
                NotesTextBox.Text = sectorDetails.Notes.ToString();

                //LabelBelongsTo.Text = programDetails.SectorName;
                if (sectorDetails.Description.ToString().Length > 700)
                {
                    DetailsTextBox.Height = sectorDetails.Description.ToString().Length - (sectorDetails.Description.ToString().Length) / 4;
                }
                ////////

            }
            statusLabel.Text = (success) ? "تم التحديث بنجاح" : "فشل التحديث";
        }
    }
}