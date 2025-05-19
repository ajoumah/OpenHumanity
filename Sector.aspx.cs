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
    
    public partial class Sector1 : System.Web.UI.Page
    {
        public static int GlobeRows;
        public static int GlobeVideoRows;
        public SectorDetails details;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string sectorId = Request.QueryString["SectorID"];
            
                if ((sectorId != null)&&(CatalogAccess.CheckInSectors(sectorId)))
                {
                
                  details = CatalogAccess.GetSectorDetails( sectorId);
                  benifitNoLabel.Text = details.BenefitNo.ToString();
                  SectorNameLabel.Text = details.Name;
                  DescriptionLabel.Text = details.Description;
                  LogoImage.ImageUrl = details.Logo;
                  StuctureImage.ImageUrl = details.Skeleton;
                  SectorNameParagraphLabel.Text="يقدم" + " "+ details.Name;
                  LinkButtonNews.PostBackUrl = Class1.ToNewsGallery(sectorId);
                  LinkButtonImageGallery.PostBackUrl = Class1.ToImageGallery(sectorId);
                  LinkButtonVideoGallery.PostBackUrl = Class1.ToVideoGallery(sectorId);
                  Style bodyStyle = new Style();
                  Style BackgoundStyle = new Style();
                  
                    string hex="" ;
                  if (details.Name == "قطاع التعليم")
                {
                    
                    hex = "#4a61ad";
                    
                    ImageEye.ImageUrl = "images/eye.png";
                }
                  else
                  if (details.Name == "قطاع الثقافة و الفنون")
                {
                    
                 
                    hex = "#fdb912";
                    
                    ImageEye.ImageUrl = "images/eyeY.png";
                }
                  else
                  if (details.Name == "قطاع التنمية المجتمعية")
                {

                    
                    hex = "#e42428";

                    ImageEye.ImageUrl = "images/eyeR.png";
                }
                  else
                  if (details.Name == "قطاع الرياضة")
                {

                   
                    hex = "#71bf44";

                    ImageEye.ImageUrl = "images/eyeGr.png";
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
                    ////
                    HtmlControl contentPanel1;
                    ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                    
                      contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink1"  );
                      if (contentPanel1 != null)
                      {

                        contentPanel1.Style["background"] = hex;
                        
                       }
                     
                contentPanel1 = (HtmlControl)cph.FindControl("SectorNameLink1");
                contentPanel1.Attributes["href"] = Class1.ToSector(details.SectorID.ToString());
                
                ///

                DataTable DT= CatalogAccess.GetProgramsInSector(sectorId);
                  Repeater1.DataSource = DT;
                  Repeater1.DataBind();

                 
                  DataTable GlobeDataTable = CatalogAccess.GetProjectsInSector(sectorId);
                 
                  GlobeRows = GlobeDataTable.Rows.Count;
                  rptProjects.DataSource = GlobeDataTable;
                  rptProjects.DataBind();

                 
                  DataTable GlobeVideoTable = CatalogAccess.GetVideoInSector(sectorId);
                 
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