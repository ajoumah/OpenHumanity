using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

using Microsoft.AspNet.Identity.Owin;
using System.Data;

namespace Onder1
{
    public partial class RolesGalleryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            //
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            grid.DataSource = rolemanager1.Roles.ToList();
            grid.PageSize = 70;/*20;*/
            // Bind the data bound controls to the data source
            grid.DataBind();
            
        }
        protected void grid_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
        protected void grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //grid.DataSource = CatalogAccess.GetAllSectorsDetailsForAdmin();
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
            string roleID = grid.DataKeys[e.RowIndex].Value.ToString();
            var roleStore1 = new RoleStore<IdentityRole>();
            var rolemanager1 = new RoleManager<IdentityRole>(roleStore1);
            IdentityRole rle = rolemanager1.FindById(roleID);
            IdentityResult result = rolemanager1.Delete(rle);

            //bool success = CatalogAccess.DeleteSectorByIDForAdmin(sectorID);

            //grid.EditIndex = -1;
            //// Display status message
            statusLabel.Text = result.Succeeded ? "تم الحذف بنجاح" : "فشل الحذف";
            //// Reload the grid
            BindGrid();
        }

        // Create a new department
        protected void createDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}