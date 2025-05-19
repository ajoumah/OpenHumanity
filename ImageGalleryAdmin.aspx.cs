using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class ImageGalleryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            // Get a DataTable object containing the catalog departments
            grid.DataSource = CatalogAccess.GetAllImageInAllForAdmin();
            grid.PageSize = 70;/*20;*/
            // Bind the data bound controls to the data source
            grid.DataBind();
        }
        protected void grid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //// Set the row for which to enable edit mode
            //grid.EditIndex = e.NewEditIndex;
            //// Set status message 
            //statusLabel.Text = "تحرير السطر رقم # " + (e.NewEditIndex + 1).ToString();
            //ScrollGrid(e.NewEditIndex);
            //// Reload the grid
            //BindGrid();
        }
        protected void grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grid.DataSource = CatalogAccess.GetAllImageInAllForAdmin();
            grid.PageIndex = e.NewPageIndex;
            grid.DataBind();
        }

        // Cancel edit mode
        protected void grid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //// Cancel edit mode
            //grid.EditIndex = -1;
            //// Set status message
            //statusLabel.Text = "الغاء عملية التحديث";
            //// Reload the grid
            //BindGrid();
        }

        // Update row
        //protected void grid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    // Retrieve updated data 
        //     string newsID = grid.DataKeys[e.RowIndex].Value.ToString();
        //    string projectID = ((TextBox)grid.Rows[e.RowIndex].FindControl("ProjectIDTextBox")).Text; 
        //    string title = ((TextBox)grid.Rows[e.RowIndex].FindControl("TitleTextBox")).Text;
        //    string details = ((TextBox)grid.Rows[e.RowIndex].FindControl("DetailsTextBox")).Text;
        //    DateTime date = Convert.ToDateTime(((TextBox)grid.Rows[e.RowIndex].FindControl("DateTextBox")).Text);
        //    string imageID = ((Label)grid.Rows[e.RowIndex].FindControl("ImageIDLabel")).Text;
        //    //grid.Rows[e.RowIndex].Focus();
        //    //grid.tableElement.ScrollTo(5, 4); 
        //    ScrollGrid(e.RowIndex);
        //    System.Web.UI.WebControls.Image img = (System.Web.UI.WebControls.Image)grid.Rows[e.RowIndex].FindControl("ImageNewsEdit") ;
        //    string url = img.ImageUrl;
        //    var text = url;
        //    int metadataStart = text.IndexOf("data:image/jpg;base64,");
        //    if (metadataStart != -1)
        //    {

        //        text = text.Remove(metadataStart, metadataStart + 22);
        //    }
        //    byte[] OriginalContent= Convert.FromBase64String(text);
        //    bool primaryImage = (((CheckBox)grid.Rows[e.RowIndex].FindControl("PrimaryImageCheckBox")).Checked);
        //    //
        //    FileUpload fu = (FileUpload)grid.Rows[e.RowIndex].FindControl("fileupload");
        //    byte[] content = OriginalContent;
        //    if (fu.HasFile)
        //    {

        //        //string file = fu.FileName;
        //        //content = ImageToStream(file);
        //        content = fu.FileBytes;

        //    }
        //    //

        //    bool success = CatalogAccess.UpdateNews( newsID, projectID,  title,  details, date, imageID,  content,  primaryImage);

        //    grid.EditIndex = -1;
        //    // Display status message
        //    statusLabel.Text = success ? "تم التحديث" : "فشل التحديث";
        //    // Reload the grid
        //    BindGrid();
        //}
        private void ScrollGrid(int rowIndex)
        {
            //// int intScrollTo = rowIndex * (int)this.grid.RowStyle.Height.Value;
            //int intScrollTo = rowIndex;
            //string strScript = string.Empty;
            //strScript += "var gridView = document.getElementById('" + grid.ClientID + "');\n";
            //strScript += "if (gridView != null && gridView.parentElement != null && gridView.parentElement.parentElement != null)\n";
            //strScript += "  gridView.parentElement.parentElement.scrollTop = " + intScrollTo + ";\n";
            //ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "ScrollGrid", strScript, true);
        }
        // Delete a record
        protected void grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ////// Get the ID of the record to be deleted
            string imageID = grid.DataKeys[e.RowIndex].Value.ToString();
            bool success = CatalogAccess.DeleteImageByIDForAdmin(imageID);

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