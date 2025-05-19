using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onder1
{
    public static class OnderShopConfiguration
    {
        private static string dbConnectionString;
       
        private static string dbProviderName;
        
        private readonly static int newsDescriptionLength;
        
        private readonly static int projectsDescriptionLength;
       
        private readonly static int newsPerPage;
       
        private readonly static int imagePerPage;
        
        private readonly static string siteName;
        static OnderShopConfiguration()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["OnderShopConnectionString"].ConnectionString;
            dbProviderName = ConfigurationManager.ConnectionStrings["OnderShopConnectionString"].ProviderName;
            newsPerPage = System.Int32.Parse(ConfigurationManager.AppSettings["NewsPerPage"]);
            imagePerPage = System.Int32.Parse(ConfigurationManager.AppSettings["ImagesPerPage"]);
            newsDescriptionLength = System.Int32.Parse(ConfigurationManager.AppSettings["NewsDescriptionLength"]);
            projectsDescriptionLength= System.Int32.Parse(ConfigurationManager.AppSettings["ProjectsDescriptionLength"]);
            siteName = ConfigurationManager.AppSettings["SiteName"];
        }
        
        public static string DbConnectionString
        {
            get
            {
                return dbConnectionString;
            }
        }

        
        public static string DbProviderName
        {
            get
            {
                return dbProviderName;
            }
        }

        
        public static string MailServer
        {
            get
            {
                return ConfigurationManager.AppSettings["MailServer"];
            }
        }

       
        public static string MailUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["MailUsername"];
            }
        }

        
        public static string MailPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["MailPassword"];
            }
        }

        
        public static string MailFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["MailFrom"];
            }
        }

       
        public static bool EnableErrorLogEmail
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["EnableErrorLogEmail"]);

            }
        }

        
        public static string ErrorLogEmail
        {
            get
            {
                return ConfigurationManager.AppSettings["ErrorLogEmail"];
            }
        }

        public static int NewsDescriptionLength
        {
            get
            {
                return newsDescriptionLength;
            }
        }
        public static int ProjectsDescriptionLength
        {
            get
            {
                return projectsDescriptionLength;
            }
        }
       
        public static int NewsPerPage
        {
            get
            {
                return newsPerPage;
            }
        }
       
        public static int ImagePerPage
        {
            get
            {
                return imagePerPage;
            }
        }
        
        public static string SiteName
        {
            get
            {
                return siteName;
            }
        }

    }
}