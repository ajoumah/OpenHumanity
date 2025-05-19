using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace Onder1
{
    public static class Utilities
    {
        static Utilities()
        {
            
        }

       
        public static void SendMail(string from, string to, string subject, string body)
        {
            
            SmtpClient mailClient = new SmtpClient(OnderShopConfiguration.MailServer);
            
            mailClient.Credentials = new NetworkCredential(OnderShopConfiguration.MailUsername, OnderShopConfiguration.MailPassword);
            
            MailMessage mailMessage = new MailMessage(from, to, subject, body);
           
            mailClient.Send(mailMessage);
        }

        
        public static void LogError(Exception ex)
        {
           
            string dateTime = DateTime.Now.ToLongDateString() + ", at " + DateTime.Now.ToShortTimeString();

            
            string errorMessage = "Exception generated on " + dateTime;
            
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            errorMessage += "\n\n Page location: " + context.Request.RawUrl;
            
            errorMessage += "\n\n Message: " + ex.Message;
            errorMessage += "\n\n Source: " + ex.Source;
            errorMessage += "\n\n Method: " + ex.TargetSite;
            errorMessage += "\n\n Stack Trace: \n\n" + ex.StackTrace;
           
            if (OnderShopConfiguration.EnableErrorLogEmail)
            {
                string from = OnderShopConfiguration.MailFrom;
                string to = OnderShopConfiguration.ErrorLogEmail;
                string subject = "BalloonShop Error Report";
                string body = errorMessage;
                SendMail(from, to, subject, body);
            }
        }
    }

}