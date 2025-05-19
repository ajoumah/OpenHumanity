using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace Onder1.UserControls
{
    public partial class NewsControl : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack == false)
            //{
                PopulateControls();
            //}
        }
        private void PopulateControls()
        {
            //string hex = "";
            // 
            string sectorId = Request.QueryString["SectorID"];
            // 
            string programId = Request.QueryString["ProgramID"];

            string projectId = Request.QueryString["ProjectID"];
            //SectorDetails details;
            // 
            //string page = Request.QueryString["Page"];
            //if (page == null) page = "1";
            // R
            //string searchString = Request.QueryString["Search"];
            // 
            //int howManyPages = 1;
            // pager links format
            //string firstPageUrl = "";
            //string pagerFormat = "";

            //


            // If browsing a category...
            if ((projectId != null) && (CatalogAccess.CheckInProjects(projectId)))
            {
                NewsRepeater.DataSource = CatalogAccess.GetNewsInProject((projectId));
                NewsRepeater.DataBind();
                // Retrieve list of products in a category
                //list.DataSource =
                //CatalogAccess.GetProductsInCategory(categoryId, page, out howManyPages);
                //list.DataBind();
                //// get first page url and pager format
                //firstPageUrl = Link.ToCategory(departmentId, categoryId, "1");
                //pagerFormat = Link.ToCategory(departmentId, categoryId, "{0}");
            }
            else if ((programId != null) && (CatalogAccess.CheckInPrograms(programId)))
            {
                NewsRepeater.DataSource = CatalogAccess.GetNewsInProgram((programId));
                NewsRepeater.DataBind();
                // Retrieve list of products in a category
                //list.DataSource =
                //CatalogAccess.GetProductsInCategory(categoryId, page, out howManyPages);
                //list.DataBind();
                //// get first page url and pager format
                //firstPageUrl = Link.ToCategory(departmentId, categoryId, "1");
                //pagerFormat = Link.ToCategory(departmentId, categoryId, "{0}");
            }
            else  if ((sectorId != null) && (CatalogAccess.CheckInSectors(sectorId)))
            {
                //details = CatalogAccess.GetSectorDetails(sectorId);
                
                // Retrieve list of News on Sector 
                NewsRepeater.DataSource = CatalogAccess.GetNewsInSector(sectorId);
                NewsRepeater.DataBind();
                
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

        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
            System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
            HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");
            
            if (contentPanel1 != null)
            {
                if(contentPanel1.Attributes["src"]!=null)
               {
                   
                   contentPanel1.Style["display"] = "block";
                    ControlImage.Style["display"] = "none";
                }
                
           }
            
        }
        


    }
}