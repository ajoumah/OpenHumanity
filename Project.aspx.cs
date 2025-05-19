using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Onder1
{
    public partial class Project : System.Web.UI.Page
    {
        public static int GlobeRows;
        public static int GlobeVideoRows;
        public ProjectDetails details;
        protected void Page_Load(object sender, EventArgs e)
        {
            string projectId = Request.QueryString["ProjectID"];

            if ((projectId != null) && (CatalogAccess.CheckInProjects(projectId)))
            {

                details = CatalogAccess.GetProjectDetails(projectId);
                benifitNoLabel.Text = details.BenefitNo.ToString();
                SectorNameLabel.Text = details.SectorName;
                ProgramNameLabel.Text = details.ProgramName;
                ProjectNameLabel.Text = details.Name;
                DescriptionLabel.Text = details.Description;
                LogoImage.ImageUrl = details.SectorLogo;
                //StuctureImage.ImageUrl = details.Skeleton;
                SectorNameParagraphLabel.Text = "يقدم" + " " + details.Name;
                LinkButtonNews.PostBackUrl = Class1.ToNewsGalleryProject(projectId);
                LinkButtonImageGallery.PostBackUrl = Class1.ToImageGalleryProject(projectId);
                LinkButtonVideoGallery.PostBackUrl = Class1.ToVideoGalleryProject(projectId);
                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "";
                if (details.SectorName == "قطاع التعليم")
                {

                    hex = "#4a61ad";

                    //ImageEye.ImageUrl = "images/eye.png";
                }
                else
                if (details.SectorName == "قطاع الثقافة و الفنون")
                {


                    hex = "#fdb912";

                    //ImageEye.ImageUrl = "images/eyeY.png";
                }
                else
                if (details.SectorName == "قطاع التنمية المجتمعية")
                {


                    hex = "#e42428";

                    //ImageEye.ImageUrl = "images/eyeR.png";
                }
                else
                if (details.SectorName == "قطاع الرياضة")
                {


                    hex = "#71bf44";

                    //ImageEye.ImageUrl = "images/eyeGr.png";
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
                ///
                //System.Web.UI.WebControls.Image ControlImage;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                HtmlControl contentPanel1;
                ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                for (int i = 1; i < 4; i++)
                {
                    contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink" + i.ToString());
                    if (contentPanel1 != null)
                    {

                        contentPanel1.Style["background"] =hex;
                        //contentPanel1.Style.Add("className", "follow-btner-no-hoverer");
                        //contentPanel1.Attributes.Add("class", "className");
                        // contentPanel1.Style.Add(HtmlTextWriterAttribute.Bordercolor.ToString() , "Green");
                        //contentPanel1.Attributes.Add("::after", ":border-right:" + hex);
                        //contentPanel1.Attributes("Style") = "FONT-FAMILY: 'Arial'; COLOR: blue; BACKGROUND-COLOR: yellow";
                        //contentPanel1.Attributes["class"]= "flat a:background :" + hex;
                        //contentPanel1.Attributes["class"] = "flat a:after :" + hex;
                    }
                }
                contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink1");
                contentPanel1.Attributes["href"] = Class1.ToSector(details.SectorID.ToString());
                contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink2");
                contentPanel1.Attributes["href"] = Class1.ToProgram(details.ProgramID.ToString());
                contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink3");
                contentPanel1.Attributes["href"] = Class1.ToProject(details.ProjectID.ToString());
                //contentPanel1.Style.Add(":after:background", hex);
                //contentPanel1.Attributes["class"] = "breadcrumb a:last-child:after:background:" + hex;
                //}
                //System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                //HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");

                //if (contentPanel1 != null)
                //{
                //    if (contentPanel1.Attributes["src"] != null)
                //    {

                //        contentPanel1.Style["display"] = "block";
                //        ControlImage.Style["display"] = "none";
                //    }

                //}
                ///

                //DataTable DT = CatalogAccess.GetProgramsInSector(sectorId);
                //Repeater1.DataSource = DT;
                //Repeater1.DataBind();


                // DataTable GlobeDataTable = CatalogAccess.GetProjectsInSector(sectorId);

                //GlobeRows = GlobeDataTable.Rows.Count;
                //rptProjects.DataSource = GlobeDataTable;
                //rptProjects.DataBind();


                DataTable GlobeVideoTable = CatalogAccess.GetVideoInProject(projectId);

                GlobeVideoRows = GlobeVideoTable.Rows.Count;
                VideoRepeater.DataSource = GlobeVideoTable;
                VideoRepeater.DataBind();
            }
            else
            {

            }
        }

        public string GetClass(object index)
        {
            if (index == null) return "";
            if (Convert.ToInt32(index) == 0) return "active";
            return "";
        }
    }
}