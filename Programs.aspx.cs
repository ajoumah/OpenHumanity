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
    public partial class Programs : System.Web.UI.Page
    {
        public static int GlobeRows;
        public static int GlobeVideoRows;
        public ProgramDetails details;
        protected void Page_Load(object sender, EventArgs e)
        {
            string programId = Request.QueryString["ProgramID"];
            ProgramDetails details;
            //if (Page.IsPostBack == false)
            //{
                
                if ((programId != null) && (CatalogAccess.CheckInPrograms(programId)))
                {
                   
                    details = CatalogAccess.GetProgramDetails(programId);
                    benifitNoLabel.Text = details.BenefitNo.ToString();
                    SectorNameLabel.Text = details.SectorName;
                    DescriptionLabel.Text = details.Description;
                    LogoImage.ImageUrl = details.Logo;
                    //////////
                    SectorNameLabel.Text = details.SectorName;
                    ProgramNameLabel.Text = details.Name;
                    //ProjectNameLabel.Text = details.Name;
                    //DescriptionLabel.Text = details.Description;
                    //LogoImage.ImageUrl = details.SectorLogo;
                     ////////
                   SectorNameParagraphLabel.Text = "برنامج" + " " + details.Name;
                    //LinkButtonNews.PostBackUrl = Class1.ToNewsGalleryProgram(programId);
                    //LinkButtonImageGallery.PostBackUrl = Class1.ToImageGalleryProgram(programId);
                    //LinkButtonVideoGallery.PostBackUrl = Class1.ToVideoGalleryProgram(programId);
                    Style bodyStyle = new Style();
                    Style BackgoundStyle = new Style();
                   
                    string hex = "";
                    if (details.SectorName == "قطاع التعليم")
                    {

                        
                        hex = "#4a61ad";

                        
                    }
                    else
                    if (details.SectorName == "قطاع الثقافة و الفنون")
                    {

                       
                        hex = "#fdb912";

                     
                    }
                    else
                    if (details.SectorName == "قطاع التنمية المجتمعية")
                    {

                       
                        hex = "#e42428";

                       
                    }
                    else
                    if (details.SectorName == "قطاع الرياضة")
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
                    //////////
                    HtmlControl contentPanel1;
                    ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                    for (int i = 1; i < 3; i++)
                    {
                     contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink" + i.ToString());
                       if (contentPanel1 != null)
                       {

                        contentPanel1.Style["background"] = hex;
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
                //////////

                DataTable GlobeDataTable = CatalogAccess.GetProjectsInProgram(programId);
                    
                    GlobeRows = GlobeDataTable.Rows.Count;
                    rptProjects.DataSource = GlobeDataTable;
                    rptProjects.DataBind();

                   
                    DataTable GlobeVideoTable = CatalogAccess.GetVideoInProgram(programId);
                   
                    //GlobeVideoRows = GlobeVideoTable.Rows.Count;
                    //VideoRepeater.DataSource = GlobeVideoTable;
                    //VideoRepeater.DataBind();
                }
                else
                {
                    //redirectToErrorPage
                }

            //}

        }
        public string GetClass(object index)
        {
            if (index == null) return "";
            if (Convert.ToInt32(index) == 0) return "active";
            return "";
        }
    }
}