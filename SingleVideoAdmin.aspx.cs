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
    public partial class SingleVideoAdmin : System.Web.UI.Page
    {
        public static VideoDetails videoDetails = new VideoDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            string videoId = Request.QueryString["VideoID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((videoId != null) && (CatalogAccess.CheckInVideo(videoId)))
            {

                TextBoxVideoDetails.Height = (videoDetails.Details.ToString().Length - (videoDetails.Details.ToString().Length) / 2);
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

            string videoId = Request.QueryString["VideoID"];
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
            if ((videoId != null) && (CatalogAccess.CheckInVideo(videoId)))
            {
                videoDetails = CatalogAccess.GetVideoDetails(videoId);

                TitleTextBox.Text = videoDetails.Title;
                TextBoxVideoDetails.Text = videoDetails.Details;

                VideoFrame.Src = videoDetails.VideoUrl;

                LabelDate.Text = videoDetails.Date.ToString("dd /MM /yyyy");
                LabelBelongsTo.Text = videoDetails.Sector + "/" + videoDetails.Program + "/" + videoDetails.Project;
                //DetailsTextBox.Text = NewsDetails.Details;

                //TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                //TextBoxVideoTitle.Text = NewsDetails.VideoTitle;


                datepicker.Text = videoDetails.Date.ToString("dd/MM/yyyy");
                DropDownListProjects.Items.Clear();
                DataTable projectsCategories = CatalogAccess.GetAllProjectsForAdmin();
                string projectId, projectName;
                for (int i = 0; i < projectsCategories.Rows.Count; i++)
                {

                    projectId = projectsCategories.Rows[i]["ProjectID"].ToString();
                    projectName = projectsCategories.Rows[i]["SectorName"].ToString() + "/" + projectsCategories.Rows[i]["ProgramsName"].ToString() + "/" + projectsCategories.Rows[i]["ProjectsName"].ToString();
                    DropDownListProjects.Items.Add(new ListItem() { Text = projectName, Value = projectId });

                }
                DropDownListProjects.SelectedValue = videoDetails.ProjectID.ToString();








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

            string details = TextBoxVideoDetails.Text;
            string url = TextBoxVideoUrl.Text;
            string youtubeUrl = "https://www.youtube.com/embed/";
            bool success = false;
            if (TextBoxVideoUrl.Text.Count() != 0)
            {
                string embed = "";
                embed = TextBoxVideoUrl.Text;
                int meta = embed.IndexOf("=");
                //int end= text.IndexOf("&");
                string newk = "";
                newk = embed.Substring(meta + 1, 11);
                youtubeUrl = youtubeUrl + newk;
              
                success = CatalogAccess.UpdateVideo(videoDetails.VideoID.ToString(), projectID, title, details, youtubeUrl, date );
            }
            if (success)
            {
                //imageDetails = CatalogAccess.GetImageDetailsForAdmin((imageDetails.ImageID.ToString()));
                videoDetails = CatalogAccess.GetVideoDetails(videoDetails.VideoID.ToString());
                //ImageNews.ImageUrl = imageDetails.Image;

                LabelDate.Text = videoDetails.Date.ToString("dd MMMM yyyy");
                LabelBelongsTo.Text = videoDetails.Sector + "/" + videoDetails.Program + "/" + videoDetails.Project;

                ///////
                VideoFrame.Src = videoDetails.VideoUrl;
                
            }
            statusLabel.Text = (success) ? "تم التحديث بنجاح" : "فشل التحديث";
        }
    }
}