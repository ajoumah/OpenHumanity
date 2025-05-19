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
    public partial class SingleNewsAdmin : System.Web.UI.Page
    {
        public static NewsAllDetails NewsDetails=new NewsAllDetails();
        List<RelatedImage> ListOfRelatedImage = new List<RelatedImage>();
        List<Keyword> ListOfKeywords = new List<Keyword>();

        private const string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
        private static Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
        private static string[] validAuthorities = { "youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be" };
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["NewsID"];
            bool isTrue = Request.QueryString["Publish"] == "true";
            if (!IsPostBack)
            { 
                
                 PopulateControls();
               
            }
            else
            if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            {
                if (NewsDetails.Details.ToString().Length > 700)
                {
                    DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
                }
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
            if ((newsId != null) && (CatalogAccess.CheckInNews(newsId)))
            {
                NewsDetails = CatalogAccess.GetNewsDetailsForAdmin((newsId));
                
                TitleTextBox.Text = NewsDetails.Title;
                
               
                ImageNews.ImageUrl = NewsDetails.Image;
                if (NewsDetails.VideoUrl != string.Empty)
                { 
                    VideoFrame.Src = NewsDetails.VideoUrl;
                    VideoFrame.Style["display"] = "block";
                    ImageNews.Style["display"] = "none";
                    
                }
                LabelDate.Text = NewsDetails.Date.ToString("dd /MM /yyyy");
                LabelBelongsTo.Text= NewsDetails.Sector + "/" + NewsDetails.Program + "/" + NewsDetails.Project;
                DetailsTextBox.Text = NewsDetails.Details;
               
                TextBoxVideoUrl.Text = NewsDetails.VideoUrl;
                TextBoxVideoTitle.Text = NewsDetails.VideoTitle;
                if (NewsDetails.Details.ToString().Length > 700)
                {
                    DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
                }
                datepicker.Text = NewsDetails.Date.ToString("dd/MM/yyyy");
                DropDownListProjects.Items.Clear();
                DataTable projectsCategories = CatalogAccess.GetAllProjectsForAdmin();
                string projectId, projectName;
                for (int i = 0; i < projectsCategories.Rows.Count; i++)
                {
                    
                    projectId = projectsCategories.Rows[i]["ProjectID"].ToString();
                    projectName = projectsCategories.Rows[i]["SectorName"].ToString() + "/" + projectsCategories.Rows[i]["ProgramsName"].ToString() + "/" + projectsCategories.Rows[i]["ProjectsName"].ToString() ;
                    DropDownListProjects.Items.Add(new ListItem() { Text = projectName, Value = projectId });

                }
                 DropDownListProjects.SelectedValue = NewsDetails.ProjectID.ToString();
                
                ListOfRelatedImage = GetRelatedImageByNewsID(newsId);
                System.Web.UI.WebControls.Image ControlImage;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                for (int i=0;i< ListOfRelatedImage.Count;i++)
                {
                    ControlImage = (System.Web.UI.WebControls.Image)cph.FindControl("Image" + i.ToString());
                    ControlImage.ImageUrl = ListOfRelatedImage[i].Image;
                }
                
                
                ListOfKeywords = GetKeywordsByNewsID(newsId);
                System.Web.UI.WebControls.TextBox ControlTextBox;
                for (int i = 0; i < ListOfKeywords.Count; i++)
                {
                    ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                    ControlTextBox.Text = ListOfKeywords[i].Word;
                }
                



            }
            else
            {
                

            }

            
        }
        
        protected void NewsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            System.Web.UI.WebControls.Image ControlImage = (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
            HtmlControl contentPanel1 = (HtmlControl)e.Item.FindControl("VideoFrame");
           
            

            if (contentPanel1 != null)
            {
                if (contentPanel1.Attributes["src"] != null)
                {

                    contentPanel1.Style["display"] = "block";
                    ControlImage.Style["display"] = "none";
                }

            }

        }

        protected void UpadateButton_Click(object sender, EventArgs e)
        {

           
            string projectID = DropDownListProjects.SelectedValue;
            
            string title = TitleTextBox.Text;
            string details = DetailsTextBox.Text;
            DateTime date = Convert.ToDateTime(datepicker.Text);
           
            
            string url = NewsDetails.Image;
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

            bool success = CatalogAccess.UpdateNews(NewsDetails.NewsID.ToString(), projectID, title, details, date, NewsDetails.ImageID.ToString(), content, true);
            ///////////
            ////////////
            string youtubeUrl = "https://www.youtube.com/embed/";
            bool UpdateVideo=true;
            if (TextBoxVideoUrl.Text.Count()!=0)
            {
                //string embed = "";
                //embed = TextBoxVideoUrl.Text;
                //int meta = embed.IndexOf("=");
                ////int end= text.IndexOf("&");
                //string newk = "";
                //newk = embed.Substring(meta+1,11);

                //youtubeUrl = youtubeUrl + newk;
                Uri myUri = new Uri(TextBoxVideoUrl.Text);
                youtubeUrl = youtubeUrl + ExtractVideoIdFromUri(myUri);
                if ((youtubeUrl!= NewsDetails.VideoUrl)&&(TextBoxVideoTitle.Text.Count()>0)&&(NewsDetails.VideoID!=-2))
                  {
                    UpdateVideo = CatalogAccess.UpdateVideoByNewsIDForAdmin(NewsDetails.NewsID.ToString(), NewsDetails.VideoID.ToString(), youtubeUrl, TextBoxVideoTitle.Text);
                  }
                  else
                  if((NewsDetails.VideoID == -2)&& (TextBoxVideoTitle.Text.Count() > 0))
                  {
                    UpdateVideo = CatalogAccess.InsertVideoByNewsIDForAdmin(NewsDetails.NewsID.ToString(), youtubeUrl, TextBoxVideoTitle.Text);
                   }
                
            }
            else
            if ((TextBoxVideoUrl.Text.Count() == 0) && (NewsDetails.VideoUrl.Count() > 0))
            {
                UpdateVideo = CatalogAccess.DeleteVideoByNewsIDForAdmin(NewsDetails.NewsID.ToString(), NewsDetails.VideoID.ToString());
            }
            ////////////

            bool UpdateRelatedImage;
            System.Web.UI.WebControls.FileUpload ControlFile;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
            ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
            ListOfRelatedImage = GetRelatedImageByNewsID(NewsDetails.NewsID.ToString());
            UpdateRelatedImage = true;
            for (int i = 0; i < ListOfRelatedImage.Count; i++)
            {
                ControlFile = (System.Web.UI.WebControls.FileUpload)cph.FindControl("fileupload" + i.ToString());
                UpdateRelatedImage = true;
                if (ControlFile.HasFile)
                {
                    content = ControlFile.FileBytes;
                    UpdateRelatedImage= CatalogAccess.UpdateRelatedImageByIDForAdmin(ListOfRelatedImage[i].ImageID.ToString(), content);

                }
               if (UpdateRelatedImage == false)
                   break;
            }

            ///////////
            ListOfKeywords = GetKeywordsByNewsID(NewsDetails.NewsID.ToString());
            for (int i = ListOfKeywords.Count; i < 5; i++)
            {
                Keyword KW = new Keyword();
                KW.Word = string.Empty;
                ListOfKeywords.Add(KW);
            }
            System.Web.UI.WebControls.TextBox ControlTextBox;
            bool UpdateKeyword = true;
            for (int i = 0; i < 5; i++)
            {
                ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                if ((ControlTextBox.Text.Count() != 0) && (ListOfKeywords[i].Word.Count() != 0) && (ControlTextBox.Text != ListOfKeywords[i].Word))
                {
                    UpdateKeyword = CatalogAccess.DeleteKeywordByNewsIDForAdmin(NewsDetails.NewsID.ToString(), ListOfKeywords[i].KeywordID.ToString());
                    UpdateKeyword = CatalogAccess.UpdateKeywordByNewsIDForAdmin(NewsDetails.NewsID.ToString(), ControlTextBox.Text);
                }
                else
                if((ControlTextBox.Text.Count() == 0) && (ListOfKeywords[i].Word.Count() != 0))
                {
                    UpdateKeyword = CatalogAccess.DeleteKeywordByNewsIDForAdmin(NewsDetails.NewsID.ToString(), ListOfKeywords[i].KeywordID.ToString());
                }
                else
                if ((ControlTextBox.Text.Count() != 0) && (ListOfKeywords[i].Word.Count() == 0))
                {
                    UpdateKeyword = CatalogAccess.UpdateKeywordByNewsIDForAdmin(NewsDetails.NewsID.ToString(), ControlTextBox.Text);
                }
                else
                if ((ControlTextBox.Text.Count() != 0) && (ListOfKeywords[i].Word.Count() != 0))
                {
                    UpdateKeyword = CatalogAccess.UpdateKeywordByNewsIDForAdmin(NewsDetails.NewsID.ToString(), ControlTextBox.Text);
                }
                if (UpdateKeyword == false)
                    break;

            }
           

            if (success|| UpdateKeyword|| UpdateRelatedImage || UpdateVideo)
            {
                NewsDetails = CatalogAccess.GetNewsDetailsForAdmin((NewsDetails.NewsID.ToString()));
                ImageNews.ImageUrl = NewsDetails.Image;
                VideoFrame.Src = NewsDetails.VideoUrl;
                LabelDate.Text = NewsDetails.Date.ToString("dd MMMM yyyy");
                LabelBelongsTo.Text = NewsDetails.Sector + "/" + NewsDetails.Program + "/" + NewsDetails.Project;
                if (NewsDetails.Details.ToString().Length > 700)
                {
                    DetailsTextBox.Height = NewsDetails.Details.ToString().Length - (NewsDetails.Details.ToString().Length) / 4;
                }
                ListOfRelatedImage = GetRelatedImageByNewsID(NewsDetails.NewsID.ToString());
                ///////
                ImageNews.ImageUrl = NewsDetails.Image;
                ImageNews.Style["display"] = "block";
                VideoFrame.Style["display"]= "none";
                if (NewsDetails.VideoUrl != string.Empty)
                {
                    VideoFrame.Src = NewsDetails.VideoUrl;
                    VideoFrame.Style["display"] = "block";
                    ImageNews.Style["display"] = "none";

                }
                ////////
                TextBoxVideoUrl.Text= NewsDetails.VideoUrl;
                TextBoxVideoTitle.Text = NewsDetails.VideoTitle;
                System.Web.UI.WebControls.Image ControlImage;//= (System.Web.UI.WebControls.Image)e.Item.FindControl("ImageNews");
                cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                for (int i = 0; i < ListOfRelatedImage.Count; i++)
                {
                    ControlImage = (System.Web.UI.WebControls.Image)cph.FindControl("Image" + i.ToString());
                    ControlImage.ImageUrl = ListOfRelatedImage[i].Image;
                }
                ListOfKeywords = GetKeywordsByNewsID(NewsDetails.NewsID.ToString());
                for (int i = 0; i < 5; i++)
                {
                    ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                    ControlTextBox.Text =null;
                }
                for (int i = 0; i < ListOfKeywords.Count; i++)
                {
                    ControlTextBox = (System.Web.UI.WebControls.TextBox)cph.FindControl("TextBoxKeyword" + i.ToString());
                    ControlTextBox.Text = ListOfKeywords[i].Word;
                }

            }
            
            statusLabel.Text = (success && UpdateKeyword && UpdateRelatedImage&& UpdateVideo) ? "تم التحديث بنجاح" : "فشل التحديث";

           
        }
        private List<RelatedImage> GetRelatedImageByNewsID(string newsid)
        {
            DataTable ImageDataTable = CatalogAccess.GetImageInNews(newsid); 
            int imageId;
            string image;
            RelatedImage RImage = new RelatedImage();
            List<RelatedImage> ListRelatedImage = new List<RelatedImage>();
            for (int i = 0; i < ImageDataTable.Rows.Count; i++)
            {

                imageId = Int32.Parse((ImageDataTable.Rows[i]["ImageID"].ToString()));
                image = ImageDataTable.Rows[i]["SectorImage"].ToString();
                RImage.ImageID = imageId;
                RImage.Image = image;
                ListRelatedImage.Add(RImage);

            }
            return ListRelatedImage;
        }

        private List<Keyword> GetKeywordsByNewsID(string newsid)
        {
            DataTable WordDataTable = CatalogAccess.GetKeywordInNews((newsid));
            int keywordId;
            string word;
            Keyword Kword = new Keyword();
            List<Keyword> ListofKeywords = new List<Keyword>();
            for (int i = 0; i < WordDataTable.Rows.Count; i++)
            {

                keywordId = Int32.Parse((WordDataTable.Rows[i]["KeywordID"].ToString()));
                word = WordDataTable.Rows[i]["Word"].ToString();
                Kword.KeywordID = keywordId;
                Kword.Word = word;
                ListofKeywords.Add(Kword);

            }
            return ListofKeywords;
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
