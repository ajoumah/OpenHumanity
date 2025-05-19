using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }
        private void PopulateControls()
        {
            //string hex = "";
            // Retrieve DepartmentID from the query string
            string sectorId = Request.QueryString["SectorID"];
            sectorId = "1";
            // Retrieve CategoryID from the query string
            string programId = Request.QueryString["ProgramID"];
            //SectorDetails details;
            // Retrieve Page from the query string
            //string page = Request.QueryString["Page"];
            //if (page == null) page = "1";
            // Retrieve Search string from query string
            //string searchString = Request.QueryString["Search"];
            // How many pages of products?
            //int howManyPages = 1;
            // pager links format
            //string firstPageUrl = "";
            //string pagerFormat = "";

            // If performing a product search


            // If browsing a category...
            if (programId != null)
            {
                // Retrieve list of products in a category
                //list.DataSource =
                //CatalogAccess.GetProductsInCategory(categoryId, page, out howManyPages);
                //list.DataBind();
                //// get first page url and pager format
                //firstPageUrl = Link.ToCategory(departmentId, categoryId, "1");
                //pagerFormat = Link.ToCategory(departmentId, categoryId, "{0}");
            }
            else if ((sectorId != null) && (CatalogAccess.CheckInSectors(sectorId)))
            {
                //details = CatalogAccess.GetSectorDetails(sectorId);

                // Retrieve list of News on Sector 
                Repeater rep = (Repeater)form1.FindControl("ImageRepeater");
                rep.DataSource = GetData(); //CatalogAccess.GetNewsInSector(sectorId);
                rep.DataBind();

                // get first page url and pager format
                //firstPageUrl = Link.ToDepartment(departmentId, "1");
                //pagerFormat = Link.ToDepartment(departmentId, "{0}");
            }
            else
            {
                // Retrieve list of products on catalog promotion
                //list.DataSource =
                //CatalogAccess.GetProductsOnFrontPromo(page, out howManyPages);
                //list.DataBind();
                //// have the current page as integer
                //int currentPage = Int32.Parse(page);

            }

            // Display pager controls
            //topPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, false);
            //bottomPager.Show(int.Parse(page), howManyPages, firstPageUrl, pagerFormat, true);
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Banner_Name"), new DataColumn("NewsImage") });
            dt.Rows.Add("1", "http://static.flickr.com/66/199481236_dc98b5abb3_s.jpg");
            dt.Rows.Add("2", "http://static.flickr.com/75/199481072_b4a0d09597_s.jpg");
            dt.Rows.Add("3", "http://static.flickr.com/57/199481087_33ae73a8de_s.jpg");
            dt.Rows.Add("4", "http://static.flickr.com/77/199481108_4359e6b971_s.jpg");
            dt.Rows.Add("5", "http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg");
            dt.Rows.Add("6", "http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg");
            dt.Rows.Add("7", "http://static.flickr.com/58/199481218_264ce20da0_s.jpg");
            dt.Rows.Add("8", "http://static.flickr.com/69/199481255_fdfe885f87_s.jpg");
            dt.Rows.Add("9", "http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg");
            dt.Rows.Add("10", "http://static.flickr.com/70/229228324_08223b70fa_s.jpg");
            dt.Rows.Add("11", "http://static.flickr.com/70/228228324_08223b70fa_s.jpg");
            dt.Rows.Add("12", "http://static.flickr.com/70/229228323_08223b70fa_s.jpg");
            return dt;
        }
    }
}