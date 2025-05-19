using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["NewsID"];
            PopulateControls();
            
        }

        private void PopulateControls()
        {
            
            string newsId = Request.QueryString["NewsID"];
            
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

           
            
            if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            {
                NewsRepeater.DataSource = CatalogAccess.GetNewsByID((newsId));
                NewsRepeater.DataBind();

                
                DataTable KeyWordDatatable=CatalogAccess.GetKeywordInNews((newsId));
                KeyWordRepeater.DataSource = KeyWordDatatable;
                KeyWordRepeater.DataBind();
                string listOfKeyord = "";
                if (KeyWordDatatable.Rows.Count > 0)
                {
                    
                    foreach (DataRow row in KeyWordDatatable.Rows)
                    {
                        listOfKeyord = listOfKeyord + " " + row["Word"];
                    }
                    
                }
                
                RepeaterRelatedNews.DataSource = CatalogAccess.SearchRelated(listOfKeyord, "FALSE", "1", out int howManyPages);
                RepeaterRelatedNews.DataBind();
                
            }
            else
            {
                // 
                //list.DataSource =
                //CatalogAccess.GetProductsOnFrontPromo(page, out howManyPages);
                //list.DataBind();
                
                //int currentPage = Int32.Parse(page);

            }

            // 
            //topPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, false);
            //bottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
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
    }
}