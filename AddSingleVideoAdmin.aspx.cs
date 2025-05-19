using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

namespace Onder1
{
    public partial class AddSingleVideoAdmin : System.Web.UI.Page
    {
        private const string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
        private static Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
        private static string[] validAuthorities = { "youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be" };

        public static VideoDetails videoDetails = new VideoDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            string videoId = Request.QueryString["VideoID"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((videoId != null) && (CatalogAccess.CheckInVideo(videoId)))
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

            string videoId = Request.QueryString["VideoID"];

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




            DropDownListProjects.Items.Clear();
            DataTable projectsCategories = CatalogAccess.GetAllProjectsForAdmin();
            string projectId, projectName;

            DropDownListProjects.Items.Add(new ListItem() { Text = "اختر من القائمة", Value = "0" });
            for (int i = 0; i < projectsCategories.Rows.Count; i++)
            {

                projectId = projectsCategories.Rows[i]["ProjectID"].ToString();
                projectName = projectsCategories.Rows[i]["SectorName"].ToString() + "/" + projectsCategories.Rows[i]["ProgramsName"].ToString() + "/" + projectsCategories.Rows[i]["ProjectsName"].ToString();
                DropDownListProjects.Items.Add(new ListItem() { Text = projectName, Value = projectId });

            }






        }


        protected void CreateButton_Click(object sender, EventArgs e)
        {

            int CreateVideoID = -3;
            string projectID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;

            DateTime date = Convert.ToDateTime(datepicker.Text);

           // bool success = false;

            string youtubeUrl = "https://www.youtube.com/embed/";
            bool UpdateVideo = false;
            if (TextBoxVideoUrl.Text.Count() != 0)
            {
                //string embed = "";
                //embed = TextBoxVideoUrl.Text;
                //int meta = embed.IndexOf("=");
                ////int end= text.IndexOf("&");
                //string newk = "";
                //newk = embed.Substring(meta + 1, 11);
                //youtubeUrl = youtubeUrl + newk;
               // Uri myUri = Uri.pa;
                Uri myUri = new Uri(TextBoxVideoUrl.Text);
                youtubeUrl = youtubeUrl + ExtractVideoIdFromUri(myUri);
                string textDetails = "";
                textDetails = TextBoxVideoDetails.Text;
                UpdateVideo = CatalogAccess.CreateVideo(out CreateVideoID, projectID, title, textDetails, youtubeUrl,date);

            }
            //



            if (UpdateVideo)
            {
                Response.Redirect("SingleVideoAdmin.aspx?VideoID=" + CreateVideoID.ToString() + "&Publish=true");
            }
            else
            {
                statusLabel.Text = "هناك خطأ";
            }



        }

        

        public string ExtractVideoIdFromUri(Uri uri)
        {

            try
            {
                string authority = new UriBuilder(uri).Uri.Authority.ToLower();

                //check if the url is a youtube url
                if (validAuthorities.Contains(authority))
                {
                    //and extract the id
                    var regRes = regexExtractId.Match(uri.ToString());
                    if (regRes.Success)
                    {
                        return regRes.Groups[1].Value;
                    }
                }
            }
            catch { }


            return null;
        }
    }
}