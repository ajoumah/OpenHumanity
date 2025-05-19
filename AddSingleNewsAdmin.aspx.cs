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
    public partial class AddSingleNewsAdmin : System.Web.UI.Page
    {
        public static NewsAllDetails NewsDetails = new NewsAllDetails();
        List<RelatedImage> ListOfRelatedImage = new List<RelatedImage>();
        List<Keyword> ListOfKeywords = new List<Keyword>();

        private const string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
        private static Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
        private static string[] validAuthorities = { "youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be" };
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["NewsID"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            {

                DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
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

            string newsId = Request.QueryString["NewsID"];

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



            //if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            //{
                //NewsDetails = CatalogAccess.GetNewsDetailsForAdmin((newsId));

                //TitleTextBox.Text = NewsDetails.Title;


                //ImageNews.ImageUrl = NewsDetails.Image;
                //if (NewsDetails.VideoUrl != string.Empty)
                //{
                //    VideoFrame.Src = NewsDetails.VideoUrl;
                //    VideoFrame.Style["display"] = "block";
                //    ImageNews.Style["display"] = "none";

                //}
                //LabelDate.Text = NewsDetails.Date.ToString("dd /MM /yyyy");
                //LabelBelongsTo.Text = NewsDetails.Sector + "/" + NewsDetails.Program + "/" + NewsDetails.Project;
                //DetailsTextBox.Text = NewsDetails.Details;

                //TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                //TextBoxVideoTitle.Text = NewsDetails.VideoTitle;

                //DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
                //datepicker.Text = NewsDetails.Date.ToString("dd/MM/yyyy");
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
               // DropDownListProjects.SelectedValue = NewsDetails.ProjectID.ToString();

                //ListOfRelatedImage = GetRelatedImageByNewsID(newsId);
                //System.Web.UI.WebControls.Image ControlImage;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                //ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                //for (int i = 0; i < ListOfRelatedImage.Count; i++)
                //{
                //    ControlImage = (System.Web.UI.WebControls.Image)cph.FindControl("Image" + i.ToString());
                //    ControlImage.ImageUrl = ListOfRelatedImage[i].Image;
                //}


                //ListOfKeywords = GetKeywordsByNewsID(newsId);
                //System.Web.UI.WebControls.TextBox ControlTextBox;
                //for (int i = 0; i < ListOfKeywords.Count; i++)
                //{
                //    ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                //    ControlTextBox.Text = ListOfKeywords[i].Word;
                //}




           // }
            //else
            //{


            //}


        }

        //protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{

        //    System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
        //    HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");



        //    if (contentPanel1 != null)
        //    {
        //        if (contentPanel1.Attributes["src"] != null)
        //        {

        //            contentPanel1.Style["display"] = "block";
        //            ControlImage.Style["display"] = "none";
        //        }

        //    }

        //}

        protected void CreateButton_Click(object sender, EventArgs e)
        {

            int CreateNewsID = -3;
            string projectID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
            string details = DetailsTextBox.Text;
            DateTime date = Convert.ToDateTime(datepicker.Text);

            bool success = CatalogAccess.CreateNews(out CreateNewsID, projectID, title, details, date);
            bool PrimaryImage = false;
            byte[] content;
            if ((fileupload.HasFile)&&(CreateNewsID!=-3))
            {
                content = fileupload.FileBytes;
                PrimaryImage = CatalogAccess.InsertImageByIDForAdmin(CreateNewsID.ToString(), content,true,false);
            }
            //

            
            ///////////
            ////////////
            string youtubeUrl = "https://www.youtube.com/embed/";
            bool UpdateVideo = true;
            if (TextBoxVideoUrl.Text.Count() != 0)
            {
                //string embed = "";
                //embed = TextBoxVideoUrl.Text;
                //int meta = embed.IndexOf("=");
                ////int end= text.IndexOf("&");
                //string newk = "";
                //newk = embed.Substring(meta + 1, 11);
                //youtubeUrl = youtubeUrl + newk;
                Uri myUri = new Uri(TextBoxVideoUrl.Text);
                youtubeUrl = youtubeUrl + ExtractVideoIdFromUri(myUri);
                UpdateVideo = CatalogAccess.InsertVideoByNewsIDForAdmin(CreateNewsID.ToString(), youtubeUrl, TextBoxVideoTitle.Text);

            }
            

            bool UpdateRelatedImage;
            System.Web.UI.WebControls.FileUpload ControlFile;
            ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
            UpdateRelatedImage = true;
            for (int i = 0; i < 10; i++)
            {
                ControlFile = (System.Web.UI.WebControls.FileUpload)cph.FindControl("fileupload" + i.ToString());
                UpdateRelatedImage = true;
                if (ControlFile.HasFile)
                {
                    content = ControlFile.FileBytes;
                    UpdateRelatedImage = CatalogAccess.InsertImageByIDForAdmin(CreateNewsID.ToString(), content, false, true);

                }
                if (UpdateRelatedImage == false)
                    break;
            }

            ///////////
            //ListOfKeywords = GetKeywordsByNewsID(NewsDetails.NewsID.ToString());
            //for (int i = ListOfKeywords.Count; i < 5; i++)
            //{
            //    Keyword KW = new Keyword();
            //    KW.Word = string.Empty;
            //    ListOfKeywords.Add(KW);
            //}
            System.Web.UI.WebControls.TextBox ControlTextBox;
            bool UpdateKeyword = true;
            for (int i = 0; i < 5; i++)
            {
                ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                if ((ControlTextBox.Text.Count() != 0) )
               {
                    
                    UpdateKeyword = CatalogAccess.UpdateKeywordByNewsIDForAdmin(CreateNewsID.ToString(), ControlTextBox.Text);
               }
                 //    else
                 //    
            
                if (UpdateKeyword == false)
                    break;

            }

            if (success && UpdateKeyword && UpdateRelatedImage && UpdateVideo)
            {
                Response.Redirect("SingleNewsAdmin.aspx?NewsID="+ CreateNewsID.ToString()+ "&Publish=true");
            }
            else
            if (success )
            {
                Response.Redirect("SingleNewsAdmin.aspx?NewsID=" + CreateNewsID.ToString()+ "&Publish=true");
            }
            //{
            //if (success || UpdateKeyword || UpdateRelatedImage || UpdateVideo)
            //{
            //    NewsDetails = CatalogAccess.GetNewsDetailsForAdmin((NewsDetails.NewsID.ToString()));
            //    ImageNews.ImageUrl = NewsDetails.Image;
            //    VideoFrame.Src = NewsDetails.VideoUrl;
            //    LabelDate.Text = NewsDetails.Date.ToString("dd MMMM yyyy");
            //    LabelBelongsTo.Text = NewsDetails.Sector + "/" + NewsDetails.Program + "/" + NewsDetails.Project;
            //    DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
            //    ListOfRelatedImage = GetRelatedImageByNewsID(NewsDetails.NewsID.ToString());
            //    ///////
            //    ImageNews.ImageUrl = NewsDetails.Image;
            //    ImageNews.Style["display"] = "block";
            //    VideoFrame.Style["display"] = "none";
            //    if (NewsDetails.VideoUrl != string.Empty)
            //    {
            //        VideoFrame.Src = NewsDetails.VideoUrl;
            //        VideoFrame.Style["display"] = "block";
            //        ImageNews.Style["display"] = "none";

                //    }
                //    ////////
                //    TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                //    TextBoxVideoTitle.Text = NewsDetails.VideoTitle;
                //    System.Web.UI.WebControls.Image ControlImage;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                //    cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                //    for (int i = 0; i < ListOfRelatedImage.Count; i++)
                //    {
                //        ControlImage = (System.Web.UI.WebControls.Image)cph.FindControl("Image" + i.ToString());
                //        ControlImage.ImageUrl = ListOfRelatedImage[i].Image;
                //    }
                //    ListOfKeywords = GetKeywordsByNewsID(NewsDetails.NewsID.ToString());
                //    for (int i = 0; i < 5; i++)
                //    {
                //        ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                //        ControlTextBox.Text = null;
                //    }
                //    for (int i = 0; i < ListOfKeywords.Count; i++)
                //    {
                //        ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                //        ControlTextBox.Text = ListOfKeywords[i].Word;
                //    }

                //}

                //statusLabel.Text = (success && UpdateKeyword && UpdateRelatedImage && UpdateVideo) ? "تم التحديث" : "فشل التحديث";


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