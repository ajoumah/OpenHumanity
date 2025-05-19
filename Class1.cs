using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Onder1
{
    public class Class1
    {
      private static Regex purifyUrlRegex = new Regex("[^-\u0621-\u064A0-9_ ]", RegexOptions.Compiled);

     
      private static Regex dashesRegex = new Regex("[-_ ]+", RegexOptions.Compiled);

     
      private static string PrepareUrlText(string urlText)
    {
        
        urlText = purifyUrlRegex.Replace(urlText, "");

        
        urlText = urlText.Trim();

       
        urlText = dashesRegex.Replace(urlText, "-");

        
        return urlText;
    }
      private static string BuildAbsolute(string relativeUri)
            {
                
                Uri uri = HttpContext.Current.Request.Url;
                
                string app = HttpContext.Current.Request.ApplicationPath;
                if (!app.EndsWith("/")) app += "/";
                relativeUri = relativeUri.TrimStart('/');
               
                return HttpUtility.UrlPathEncode(
                  String.Format("http://{0}{1}{2}",
                  uri.Host,  app, relativeUri));
            }
      public static string ToSector(string sectorId)
            {
                  
                  SectorDetails Sector = CatalogAccess.GetSectorDetails(sectorId);
                  string sectorUrlName = PrepareUrlText(Sector.Name);

                  
            
                  //return BuildAbsolute(String.Format("{0}-d{1}", sectorUrlName, sectorId));
            
           
            return BuildAbsolute(String.Format("Sector.aspx?SectorID={0}", sectorId));

            }
     
      public static string ToSectorByName(string sectorName)
            {
                int sectorId = 0;
                sectorId =CatalogAccess.GetSectorIdByName(sectorName);
                return ToSector(sectorId.ToString());
                //return BuildAbsolute(String.Format("Sector.aspx?sectorID={0}",sectorId));

            }
     
      public static string ToProgram(string programId)
      {
                
                 ProgramDetails programDetails = CatalogAccess.GetProgramDetails(programId);
                 string programUrlName = PrepareUrlText(programDetails.Name);

                 

                 //return BuildAbsolute(String.Format("{0}-p{1}", programUrlName, programId));

                 return BuildAbsolute(String.Format("Programs.aspx?ProgramID={0}", programId));

      }
     public static string ToProject(string projectId)
        {

            ProjectDetails projectDetails = CatalogAccess.GetProjectDetails(projectId);
            string projectUrlName = PrepareUrlText(projectDetails.Name);



            //return BuildAbsolute(String.Format("{0}-j{1}", projectUrlName, projectId));

            return BuildAbsolute(String.Format("Project.aspx?ProjectID={0}", projectId));
           

        }

        public static string ToNews(string newsId)
            {
              
              NewsDetails newsDetails = CatalogAccess.GetNewsDetails(newsId);
              string newsUrlName = PrepareUrlText(newsDetails.Title);

            //return BuildAbsolute(String.Format("{0}-n{1}", newsUrlName, newsId));

            return BuildAbsolute(String.Format("News.aspx?NewsID={0}", newsId));

        }

        public static string ToNewsGallery(string sectorId,  string page)
        {
            string SectorName = "";
            if(sectorId=="0")
            {
                SectorName = "الأخبار_الرئيسية";
            }
            else 
            { 
               
               SectorDetails Sectordetails = CatalogAccess.GetSectorDetails(sectorId);
               string newsUrlName = PrepareUrlText("أخبار" + " "+Sectordetails.Name);
                SectorName = newsUrlName;
            }
            if (page == "1")
            { 
                //return BuildAbsolute(String.Format("{0}-ng{1}", SectorName, sectorId));
                return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}", sectorId));
                
            }
            else
            { 
                //return BuildAbsolute(String.Format("{0}-ng{1}-pg{2}", SectorName, sectorId, page));
                return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}&Page={1}", sectorId,page));
                //"NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}"
            }

            //else
            //    return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}&Page={1}", sectorId, page));


        }
      public static string ToNewsGallery(string sectorId)
        {
            return ToNewsGallery(sectorId, "1");
        }
        public static string ToNewsGalleryProgram(string programId, string page)
        {
            string SectorName = "";
            

                ProgramDetails ProgramDetails = CatalogAccess.GetProgramDetails(programId);
                string newsUrlName = PrepareUrlText("أخبار" + " " + ProgramDetails.Name);
                SectorName = newsUrlName;
            
            if (page == "1")
                //return BuildAbsolute(String.Format("{0}-ngp{1}", SectorName, programId));
                return BuildAbsolute(String.Format("NewsGallery.aspx?ProgramID={0}", programId));

            else
                //return BuildAbsolute(String.Format("{0}-ngp{1}-pg{2}", SectorName, programId, page));
                return BuildAbsolute(String.Format("NewsGallery.aspx?ProgramID={0}&Page={1}", programId, page));

        }
        public static string ToNewsGalleryProgram(string programId)
        {
            return ToNewsGalleryProgram(programId, "1");
        }
        public static string ToNewsGalleryProject(string projectId, string page)
        {
            string SectorName = "";


            ProjectDetails ProjectDetails = CatalogAccess.GetProjectDetails(projectId);
            string newsUrlName = PrepareUrlText("أخبار" + " " + ProjectDetails.Name);
            SectorName = newsUrlName;

            if (page == "1")
            { 
                return BuildAbsolute(String.Format("NewsGallery.aspx?ProjectID={0}", projectId));
                //return BuildAbsolute(String.Format("{0}-ngj{1}", SectorName, projectId));
            }
            else
            { 
                return BuildAbsolute(String.Format("NewsGallery.aspx?ProjectID={0}&Page={1}", projectId, page));
                //return BuildAbsolute(String.Format("{0}-ngj{1}-pg{2}", SectorName, projectId, page));
            }

        }
        public static string ToNewsGalleryProject(string projectId)
        {
            return ToNewsGalleryProject(projectId, "1");
        }
        public static string ToVideoGallery(string sectorId, string page)
        {
            string SectorName = "";
            if (sectorId == "0")
            {
                SectorName = "معرض_الفيديو";
            }
            else
            {

                SectorDetails Sectordetails = CatalogAccess.GetSectorDetails(sectorId);
                string newsUrlName = PrepareUrlText("معرض فيديو" + " " + Sectordetails.Name);
                SectorName = newsUrlName;
            }
            if (page == "1")
                return BuildAbsolute(String.Format("VideoGallery.aspx?SectorID={0}", sectorId));
            //return BuildAbsolute(String.Format("{0}-vg{1}", SectorName, sectorId));

            else
                return BuildAbsolute(String.Format("VideoGallery.aspx?SectorID={0}&Page={1}", sectorId, page));
            //return BuildAbsolute(String.Format("{0}-vg{1}-pg{2}", SectorName, sectorId, page));


            //else
            //    return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}&Page={1}", sectorId, page));


        }
        public static string ToVideoGallery(string sectorId)
        {
            return ToVideoGallery(sectorId, "1");
        }
        public static string ToVideoGalleryProgram(string programId, string page)
        {

                string SectorName = "";
                ProgramDetails ProgramDetails = CatalogAccess.GetProgramDetails(programId);
                string newsUrlName = PrepareUrlText("معرض فيديو" + " " + ProgramDetails.Name);
                SectorName = newsUrlName;
            
            if (page == "1")
                return BuildAbsolute(String.Format("VideoGallery.aspx?ProgramID={0}", programId));
            //return BuildAbsolute(String.Format("{0}-vgp{1}", SectorName, programId));
            else
                return BuildAbsolute(String.Format("VideoGallery.aspx?ProgramID={0}&Page={1}", programId, page));
            //return BuildAbsolute(String.Format("{0}-vgp{1}-pg{2}", SectorName, programId, page));


            //else
            //    return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}&Page={1}", sectorId, page));


        }
        public static string ToVideoGalleryProgram(string programId)
        {
            return ToVideoGalleryProgram(programId, "1");
        }

        public static string ToVideoGalleryProject(string projectId, string page)
        {

            string SectorName = "";
            ProjectDetails ProjectDetails = CatalogAccess.GetProjectDetails(projectId);
            string newsUrlName = PrepareUrlText("معرض فيديو" + " " + ProjectDetails.Name);
            SectorName = newsUrlName;

            if (page == "1")
                return BuildAbsolute(String.Format("VideoGallery.aspx?ProjectID={0}", projectId));
               //return BuildAbsolute(String.Format("{0}-vgj{1}", SectorName, projectId));
            else
                return BuildAbsolute(String.Format("VideoGallery.aspx?ProjectID={0}&Page={1}", projectId, page));
            //return BuildAbsolute(String.Format("{0}-vgj{1}-pg{2}", SectorName, projectId, page));
        }
        public static string ToVideoGalleryProject(string projectId)
        {
            return ToVideoGalleryProject(projectId, "1");
        }
        public static string ToImageGallery(string sectorId, string page)
        {
            string SectorName = "";
            if (sectorId == "0")
            {
                SectorName = "معرض_الصور";
            }
            else
            {
               
                SectorDetails Sectordetails = CatalogAccess.GetSectorDetails(sectorId);
                string newsUrlName = PrepareUrlText("معرض صور" + " " + Sectordetails.Name);
                SectorName = newsUrlName;
            }
            if (page == "1")
                return BuildAbsolute(String.Format("Gallery.aspx?SectorID={0}", sectorId));
            //return BuildAbsolute(String.Format("{0}-ig{1}", SectorName, sectorId));
            else
                return BuildAbsolute(String.Format("Gallery.aspx?SectorID={0}&Page={1}", sectorId, page));
            //return BuildAbsolute(String.Format("{0}-ig{1}-pg{2}", SectorName, sectorId, page));

            //if (page == "1")
            //    return BuildAbsolute(String.Format("NewsGallery.aspx?SectorID={0}", sectorId));





        }
        public static string ToImageGallery(string sectorId)
        {
            return ToImageGallery(sectorId, "1");
        }

        public static string ToImageGalleryProgram(string programId, string page)
        {
            string SectorName = "";
            

                ProgramDetails ProgramDetails = CatalogAccess.GetProgramDetails(programId);
                string newsUrlName = PrepareUrlText("معرض صور" + " " + ProgramDetails.Name);
                SectorName = newsUrlName;
            
            if (page == "1")
                return BuildAbsolute(String.Format("Gallery.aspx?ProgramID={0}", programId));
            //return BuildAbsolute(String.Format("{0}-igp{1}", SectorName, programId));
            else
                return BuildAbsolute(String.Format("Gallery.aspx?ProgramID={0}&Page={1}", programId, page));
            //return BuildAbsolute(String.Format("{0}-igp{1}-pg{2}", SectorName, programId, page));

        }
        public static string ToImageGalleryProgram(string programId)
        {
            return ToImageGalleryProgram(programId, "1");
        }
        public static string ToImageGalleryProject(string projectId, string page)
        {
            string SectorName = "";


            ProjectDetails ProjectDetails = CatalogAccess.GetProjectDetails(projectId);
            string newsUrlName = PrepareUrlText("معرض صور" + " " + ProjectDetails.Name);
            SectorName = newsUrlName;

            if (page == "1")
                return BuildAbsolute(String.Format("Gallery.aspx?ProjectID={0}", projectId));
            // return BuildAbsolute(String.Format("{0}-igj{1}", SectorName, projectId));
            else
                return BuildAbsolute(String.Format("Gallery.aspx?ProjectID={0}&Page={1}", projectId, page));
            //return BuildAbsolute(String.Format("{0}-igj{1}-pg{2}", SectorName, projectId, page));

        }
        public static string ToImageGalleryProject(string projectId)
        {
            return ToImageGalleryProject(projectId, "1");
        }
        public static string ToSearch(string searchString, bool allWords, string page)
    {
            if (page == "1")
                return BuildAbsolute(
                String.Format("/Search.aspx?Search={0}&AllWords={1}", searchString, allWords.ToString()));

            else
                return BuildAbsolute(
                String.Format("/Search.aspx?Search={0}&AllWords={1}&Page={2}", searchString, allWords.ToString(), page));

    }

        public static string ToSearchImage(string searchString, bool allWords, string page)
        {
            if (page == "1")
                return BuildAbsolute(
                String.Format("/SearchImage.aspx?Search={0}&AllWords={1}", searchString, allWords.ToString()));

            else
                return BuildAbsolute(
                String.Format("/SearchImage.aspx?Search={0}&AllWords={1}&Page={2}", searchString, allWords.ToString(), page));

        }

        public static string ToSearchVideo(string searchString, bool allWords, string page)
        {
            if (page == "1")
                return BuildAbsolute(
                String.Format("/VideoSearch.aspx?Search={0}&AllWords={1}", searchString, allWords.ToString()));

            else
                return BuildAbsolute(
                String.Format("/VideoSearch.aspx?Search={0}&AllWords={1}&Page={2}", searchString, allWords.ToString(), page));

        }


    }
    
}