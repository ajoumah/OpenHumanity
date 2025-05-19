using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class SingleVideoShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["SectorID"];
            PopulateControls();
        }
        private void PopulateControls()
        {
           

            string videoId = Request.QueryString["VideoID"];
            
            ProjectDetails Projectdetails;
            VideoDetails Videodetails;
            if ((videoId != null) && (CatalogAccess.CheckInVideo(videoId)))
            {
                Videodetails = CatalogAccess.GetVideoDetails(videoId);
                Projectdetails = CatalogAccess.GetProjectDetails(Videodetails.ProjectID.ToString());
                //details = CatalogAccess.GetSectorDetails(sectorId);
                SectorNameLabel.Text = "معرض الفيديو في" + " " + Projectdetails.Name;

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


                VideoGalleryRepeater.DataSource = CatalogAccess.GetVideosByID(videoId);
                VideoGalleryRepeater.DataBind();

                
            }
            
            //else
            //{
            //    SectorNameLabel.Text = "معرض الفيديو";

            //    Style bodyStyle = new Style();
            //    Style BackgoundStyle = new Style();

            //    string hex = "#ff9102";

            //    BackgoundStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
            //    bodyStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(hex);

            //    Style BorderStyle1 = new Style();
            //    Color BorderColor = new Color();
            //    BorderColor = System.Drawing.ColorTranslator.FromHtml(hex);
            //    BorderStyle1.BorderStyle = BorderStyle.Solid;
            //    BorderStyle1.BorderWidth = Unit.Parse("2");
            //    BorderStyle1.BorderColor = BorderColor;

            //    Page.Header.StyleSheet.CreateStyleRule(BorderStyle1, null, ".BorderSectorColor");
            //    Page.Header.StyleSheet.CreateStyleRule(bodyStyle, null, ".SectorColor");
            //    Page.Header.StyleSheet.CreateStyleRule(BackgoundStyle, null, ".SectorBackgoundColor");


            //    VideoGalleryRepeater.DataSource = CatalogAccess.GetAllVideosInAll(page, out howManyPages);
            //    VideoGalleryRepeater.DataBind();

            //    firstPageUrl = Class1.ToVideoGallery("0", "1");
            //    pagerFormat = Class1.ToVideoGallery("0", "{0}");
            //    BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
            //}
        }
    }
}