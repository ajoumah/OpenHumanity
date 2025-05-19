using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class SectorsGalleryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            // Get a DataTable object containing the catalog departments
            grid.DataSource = CatalogAccess.GetAllSectorsDetailsForAdmin();
            
            grid.PageSize = 70;/*20;*/
            // Bind the data bound controls to the data source
            grid.DataBind();
        }
        protected void grid_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
        protected void grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grid.DataSource = CatalogAccess.GetAllSectorsDetailsForAdmin();
            grid.PageIndex = e.NewPageIndex;
            grid.DataBind();
        }

        // Cancel edit mode
        protected void grid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }


        private void ScrollGrid(int rowIndex)
        {

        }
        // Delete a record
        protected void grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ////// Get the ID of the record to be deleted
            string sectorID = grid.DataKeys[e.RowIndex].Value.ToString();
            bool success = CatalogAccess.DeleteSectorByIDForAdmin(sectorID);

            //grid.EditIndex = -1;
            //// Display status message
            statusLabel.Text = success ? "تم الحذف بنجاح" : "فشل الحذف";
            //// Reload the grid
            BindGrid();
        }

        // Create a new department
        protected void createDepartment_Click(object sender, EventArgs e)
        {
            //// Execute the insert command
            //bool success = CatalogAccess.AddDepartment(newName.Text, newDescription.Text);
            //// Display status message
            //statusLabel.Text = success ? "Insert successful" : "Insert failed";
            //// Reload the grid
            //BindGrid();
        }
    }
}