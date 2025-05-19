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
    public partial class SingleImageAdmin : System.Web.UI.Page
    {
        public static ImageDetails imageDetails = new ImageDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            string imageId = Request.QueryString["ImageID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((imageId != null) && (CatalogAccess.CheckInImage(imageId)))
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

            }
        }

        private void PopulateControls()
        {

            string imageId = Request.QueryString["ImageID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
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
            if (Request.QueryString["Publish"] != null)
            {
                isTrue = Request.QueryString["Publish"] == "true";
                statusLabel.Text = (isTrue) ? "تم النشر بنجاح" : "فشل النشر";
            }
            if ((imageId != null) && (CatalogAccess.CheckInImage(imageId)))
            {
                imageDetails = CatalogAccess.GetImageDetailsForAdmin(imageId);

                TitleTextBox.Text = imageDetails.Title;


                ImageNews.ImageUrl = imageDetails.Image;

                LabelDate.Text = imageDetails.Date.ToString("dd /MM /yyyy");
                LabelBelongsTo.Text = imageDetails.Sector + "/" + imageDetails.Program + "/" + imageDetails.Project;
                //DetailsTextBox.Text = NewsDetails.Details;

                //TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                //TextBoxVideoTitle.Text = NewsDetails.VideoTitle;


                datepicker.Text = imageDetails.Date.ToString("dd/MM/yyyy");
                DropDownListProjects.Items.Clear();
                DataTable projectsCategories = CatalogAccess.GetAllProjectsForAdmin();
                string projectId, projectName;
                for (int i = 0; i < projectsCategories.Rows.Count; i++)
                {

                    projectId = projectsCategories.Rows[i]["ProjectID"].ToString();
                    projectName = projectsCategories.Rows[i]["SectorName"].ToString() + "/" + projectsCategories.Rows[i]["ProgramsName"].ToString() + "/" + projectsCategories.Rows[i]["ProjectsName"].ToString();
                    DropDownListProjects.Items.Add(new ListItem() { Text = projectName, Value = projectId });

                }
                DropDownListProjects.SelectedValue = imageDetails.ProjectID.ToString();








            }
            else
            {


            }


        }

        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            //System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
            //HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");



            //if (contentPanel1 != null)
            //{
            //    if (contentPanel1.Attributes["src"] != null)
            //    {

            //        contentPanel1.Style["display"] = "block";
            //        ControlImage.Style["display"] = "none";
            //    }

            //}

        }

        protected void UpadateButton_Click(object sender, EventArgs e)
        {


            string projectID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;

            DateTime date = Convert.ToDateTime(datepicker.Text);


            string url = imageDetails.Image;
            var text = url;
            int metadataStart = text.IndexOf("data:image/jpg;base64,");
            if (metadataStart != -1)
            {

                text = text.Remove(metadataStart, metadataStart + 22);
            }
            byte[] OriginalContent = Convert.FromBase64String(text);

            byte[] content = OriginalContent;
            if (fileupload.HasFile)
            {


                content = fileupload.FileBytes;

            }
            //

            bool success = CatalogAccess.UpdateImage(imageDetails.ImageID.ToString(), projectID, title, date, content);
            ///////////





            System.Web.UI.WebControls.TextBox ControlTextBox;




            if (success)
            {
                imageDetails = CatalogAccess.GetImageDetailsForAdmin((imageDetails.ImageID.ToString()));
                ImageNews.ImageUrl = imageDetails.Image;

                LabelDate.Text = imageDetails.Date.ToString("dd MMMM yyyy");
                LabelBelongsTo.Text = imageDetails.Sector + "/" + imageDetails.Program + "/" + imageDetails.Project;

                ///////
                ImageNews.ImageUrl = imageDetails.Image;
                ImageNews.Style["display"] = "block";

                ////////



                statusLabel.Text = (success) ? "تم التحديث بنجاح" : "فشل التحديث";


                //}



            }
        }
    }
}
