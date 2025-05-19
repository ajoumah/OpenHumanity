using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["SectorID"];
            PopulateControls();

        }

        private void PopulateControls()
        {
            string sectorId = Request.QueryString["SectorID"];
           
            string page = Request.QueryString["Page"];
            if (page == null) page = "1";
           
            int howManyPages = 1;
            
            string firstPageUrl = "";
            string pagerFormat = "";
            SectorDetails details;
            string programId = Request.QueryString["ProgramID"];
            ProgramDetails Programdetails;
            string projectId = Request.QueryString["ProjectID"];
            ProjectDetails Projectdetails;
            if ((projectId != null) && (CatalogAccess.CheckInProjects(projectId)))
            {
                Projectdetails = CatalogAccess.GetProjectDetails(projectId);
                //details = CatalogAccess.GetSectorDetails(sectorId);
                SectorNameLabel.Text = "معرض صور" + " " + Projectdetails.Name;

                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "";
                if (Projectdetails.SectorName == "قطاع التعليم")
                {
                    hex = "#4a61ad";
                }
                else
                if (Projectdetails.SectorName == "قطاع الثقافة و الفنون")
                {
                    hex = "#fdb912";
                }
                else
                if (Projectdetails.SectorName == "قطاع التنمية المجتمعية")
                {
                    hex = "#e42428";
                }
                else
                if (Projectdetails.SectorName == "قطاع الرياضة")
                {
                    hex = "#71bf44";
                }
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


                ImageRepeater.DataSource = CatalogAccess.GetAllImagesInProject(Projectdetails.Name, page, out howManyPages);
                ImageRepeater.DataBind();

                firstPageUrl = Class1.ToImageGalleryProject(projectId, "1");
                pagerFormat = Class1.ToImageGalleryProject(projectId, "{0}");
                BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
            }
            else 
            if ((programId != null) && (CatalogAccess.CheckInPrograms(programId)))
            {
                Programdetails = CatalogAccess.GetProgramDetails(programId);
                //details = CatalogAccess.GetSectorDetails(sectorId);
                SectorNameLabel.Text = "معرض صور" + " " + Programdetails.Name;

                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "";
                if (Programdetails.SectorName == "قطاع التعليم")
                {
                    hex = "#4a61ad";
                }
                else
                if (Programdetails.SectorName == "قطاع الثقافة و الفنون")
                {
                    hex = "#fdb912";
                }
                else
                if (Programdetails.SectorName == "قطاع التنمية المجتمعية")
                {
                    hex = "#e42428";
                }
                else
                if (Programdetails.SectorName == "قطاع الرياضة")
                {
                    hex = "#71bf44";
                }
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


                ImageRepeater.DataSource = CatalogAccess.GetAllImagesInProgram(Programdetails.Name, page, out howManyPages);
                ImageRepeater.DataBind();

                firstPageUrl = Class1.ToImageGalleryProgram(programId, "1");
                pagerFormat = Class1.ToImageGalleryProgram(programId, "{0}");
                BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);

            }
            else if ((sectorId != null) && (CatalogAccess.CheckInSectors(sectorId)))
            {
                
                details = CatalogAccess.GetSectorDetails(sectorId);
                SectorNameLabel.Text = "معرض صور" + " " + details.Name;
                
                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();
                
                string hex = "";
                if (details.Name == "قطاع التعليم")
                {
                   
                    hex = "#4a61ad";

                }
                else
                if (details.Name == "قطاع الثقافة و الفنون")
                {
                    hex = "#fdb912";

                }
                else
                if (details.Name == "قطاع التنمية المجتمعية")
                {
                    hex = "#e42428";

                }
                else
                if (details.Name == "قطاع الرياضة")
                {
                    hex = "#71bf44";

                }
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

                
                ImageRepeater.DataSource = CatalogAccess.GetAllImagesInSector(details.Name, page, out howManyPages);
                ImageRepeater.DataBind();
                
                firstPageUrl = Class1.ToImageGallery(sectorId, "1");
                pagerFormat = Class1.ToImageGallery(sectorId, "{0}");
                BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);

            }
            else
            {
                SectorNameLabel.Text = "معرض صور";
                
                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();
                
                string hex = "#ff9102";

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

               
                ImageRepeater.DataSource = CatalogAccess.GetAllImagesInAll(page, out howManyPages);
                ImageRepeater.DataBind();
                firstPageUrl = Class1.ToImageGallery("0", "1");
                pagerFormat = Class1.ToImageGallery("0", "{0}");
                BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
            }
        }
    }
}