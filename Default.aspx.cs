using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Onder1;


namespace Onder1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
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
                    
                    Repeater rep = (Repeater)ContainerVideo1.FindControl("VideoRepeater");
                    rep.DataSource = CatalogAccess.GetTop10VideoInDifferentProjects(); //CatalogAccess.GetTopVideo();
                    //rep.DataSource = CatalogAccess.GetTop10VideoInDifferentProjectsOrderByDate();
                    rep.DataBind();
                   
                    LinkButtonNews.PostBackUrl = Class1.ToNewsGallery("0", "1");
                   
                    LinkButtonImageGallery.PostBackUrl = Class1.ToImageGallery("0", "1");
                    LinkButtonVideoGallery.PostBackUrl = Class1.ToVideoGallery("0", "1");
                    LearningNewsRepeater.DataSource = CatalogAccess.GetTopNewsInSector("قطاع التعليم");
                    LearningNewsRepeater.DataBind();
                    CultureNewsRepeater.DataSource = CatalogAccess.GetTopNewsInSector("قطاع الثقافة");
                    CultureNewsRepeater.DataBind();
                    SocietyNewsRepeater.DataSource = CatalogAccess.GetTopNewsInSector("قطاع التنمية");
                    SocietyNewsRepeater.DataBind();
                    SportNewsRepeater.DataSource = CatalogAccess.GetTopNewsInSector("قطاع الرياضة");
                    SportNewsRepeater.DataBind();
                
                LinkButtonLearning.PostBackUrl = Class1.ToSectorByName("التعليم");
                LinkButtonCulture.PostBackUrl = Class1.ToSectorByName("الثقافة");
                LinkButtonSociety.PostBackUrl = Class1.ToSectorByName("التنمية");
                LinkButtonSport.PostBackUrl = Class1.ToSectorByName("الرياضة");

                
                DropDownLearning.PostBackUrl = Class1.ToSectorByName("التعليم");
                DropDownCulture.PostBackUrl = Class1.ToSectorByName("الثقافة");
                DropDownSociety.PostBackUrl = Class1.ToSectorByName("التنمية");
                DropDownSport.PostBackUrl = Class1.ToSectorByName("الرياضة");
            }

        }

        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
            HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");

            if (contentPanel1 != null)
            {
                if (contentPanel1.Attributes["src"] != null)
                {

                    contentPanel1.Style["display"] = "block";
                    ControlImage.Style["display"] = "none";
                }

            }

        }

        protected void LinkButtonLearning_Click(object sender, EventArgs e)
        {
            Response.Redirect(LinkButtonLearning.PostBackUrl);
            
        }
    }
}