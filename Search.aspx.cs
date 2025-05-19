using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Data;

namespace Onder1
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string searchString = Request.QueryString["Search"];
            titleLabel.Text = "نتائج البحث عن :";
            descriptionLabel.Text = "\"" + searchString + "\"";
           
            this.Title = OnderShopConfiguration.SiteName + " : البحث في الأخبار : " + searchString;
            PopulateControls();
        }

        private void PopulateControls()
        {
            int GlobeRows;
            
            string page = Request.QueryString["Page"];
            if (page == null) page = "1";
            
            string searchString = Request.QueryString["Search"];
            
            int howManyPages = 1;
            
            string firstPageUrl = "";
            string pagerFormat = "";
            
            if (searchString != null)
            {
               
                string allWords = Request.QueryString["AllWords"];
                
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
                DataTable GlobeDataTable = CatalogAccess.Search(searchString, allWords, page, out howManyPages);
                GlobeRows = GlobeDataTable.Rows.Count;
                if(GlobeRows==0)
                {
                    noResultLabel.Visible =true ;
                    noResultLabel.Text = "لا توجد نتائج";
                }
                NewsSearchRepeater.DataSource = GlobeDataTable;
                NewsSearchRepeater.DataBind();
                
               
                firstPageUrl = Class1.ToSearch(searchString, allWords.ToUpper() == "TRUE", "1");

                pagerFormat = Class1.ToSearch(searchString, allWords.ToUpper() == "TRUE", "{0}");
                BottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);

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
    }
}
