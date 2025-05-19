using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1.UserControls
{
    public partial class ImageDisplayControl : System.Web.UI.UserControl
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
            // Retrieve SectorID from the query string
            string sectorId = Request.QueryString["SectorID"];
            //sectorId = "1";
            // Retrieve ProgramID from the query string
            string programId = Request.QueryString["ProgramID"];
            // Retrieve NewsID from the query string
            string newsId = Request.QueryString["NewsID"];
            //
            string projectId = Request.QueryString["ProjectID"];


            // If browsing a category...
            if ((projectId != null) && (CatalogAccess.CheckInProjects(projectId)))
            {
                Repeater rep = (Repeater)Container1.FindControl("ImageRepeater");
                rep.DataSource = CatalogAccess.GetImageInProject(projectId); 
                rep.DataBind();

            }
            else if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            {
                Repeater rep = (Repeater)Container1.FindControl("ImageRepeater");
                rep.DataSource = CatalogAccess.GetImageInNews(newsId); 
                rep.DataBind();
                
            }
            else if ((programId != null) && (CatalogAccess.CheckInPrograms(programId)))
            {
                Repeater rep = (Repeater)Container1.FindControl("ImageRepeater");
                rep.DataSource = CatalogAccess.GetImageInProgram(programId); 
                rep.DataBind();
                
            }
            else if ((sectorId != null) && (CatalogAccess.CheckInSectors(sectorId)))
            {
                //details = CatalogAccess.GetSectorDetails(sectorId);

                // Retrieve list of News on Sector 
                Repeater rep = (Repeater)Container1.FindControl("ImageRepeater");
                rep.DataSource = CatalogAccess.GetImageInSector(sectorId); 
                rep.DataBind();

            }
            else
            {
                //Then We are in Default.aspx so that Get Top 10 of Images 
                Repeater rep = (Repeater)Container1.FindControl("ImageRepeater");
                //rep.DataSource = CatalogAccess.GetTopImage(); //CatalogAccess.GetTop10ImageInDifferentProjects();
                rep.DataSource = CatalogAccess.GetTop10ImageInDifferentProjects();
                rep.DataBind();

            }

            
        }
        
    }
}