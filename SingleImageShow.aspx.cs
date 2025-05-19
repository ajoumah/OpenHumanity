using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class SingleImageShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string imageId = Request.QueryString["ImageID"];
            PopulateControls();

        }

        private void PopulateControls()
        {
            string imageId = Request.QueryString["ImageID"];
            //string sectorId = Request.QueryString["SectorID"];

            //string page = Request.QueryString["Page"];
            //if (page == null) page = "1";

            //int howManyPages = 1;

            //string firstPageUrl = "";
            //string pagerFormat = "";
            //SectorDetails details;
            //string programId = Request.QueryString["ProgramID"];
            //ProgramDetails Programdetails;
            //string projectId = Request.QueryString["ProjectID"];
            //ProjectDetails Projectdetails;
            if ((imageId != null) && (CatalogAccess.CheckInImage(imageId)))
            {
                //Projectdetails = CatalogAccess.GetProjectDetails(projectId);
                //details = CatalogAccess.GetSectorDetails(sectorId);
                SectorNameLabel.Text = "معرض صور";

                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "#ff9102";
                //if (Projectdetails.SectorName == "قطاع التعليم")
                //{
                //    hex = "#4a61ad";
                //}
                //else
                //if (Projectdetails.SectorName == "قطاع الثقافة و الفنون")
                //{
                //    hex = "#fdb912";
                //}
                //else
                //if (Projectdetails.SectorName == "قطاع التنمية المجتمعية")
                //{
                //    hex = "#e42428";
                //}
                //else
                //if (Projectdetails.SectorName == "قطاع الرياضة")
                //{
                //    hex = "#71bf44";
                //}
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


                ImageRepeater.DataSource = CatalogAccess.GetImagesByID(imageId);
                ImageRepeater.DataBind();

                //firstPageUrl = Class1.ToImageGalleryProject(projectId, "1");
                //pagerFormat = Class1.ToImageGalleryProject(projectId, "{0}");
                //BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
            }
            else
            {
                
                
            }
        }
    }
}