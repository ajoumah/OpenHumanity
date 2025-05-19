using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Rewrite;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace Onder1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //String path = Request.Url.ToString();
            //string pattern = @"^.*-d([0-9]+)$";
            //Regex currencyRegex = new Regex(pattern);
            
            //Match result = Regex.Match(path, pattern);
            //string los;
            //if (currencyRegex.IsMatch(path))
            //{
            //    string key = result.Groups[1].Value;
            //    los = "/Sector.aspx?SectorID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternProgram = @"^.*-p([0-9]+)$";
            //Regex currencyRegex1 = new Regex(patternProgram);
            
            //Match result1 = Regex.Match(path, patternProgram);
            ////string los;
            //if (currencyRegex1.IsMatch(path))
            //{
            
            //    string key = result1.Groups[1].Value;
            //    los = "Programs.aspx?ProgramID=" + key;
            //    Context.RewritePath(los, true);
            //}

            //string patternNews = @"^.*-n([0-9]+)$";
            //Regex currencyRegex3 = new Regex(patternNews);

            //Match result2 = Regex.Match(path, patternNews);
            ////string los;
            //if (currencyRegex3.IsMatch(path))
            //{

            //    string key = result2.Groups[1].Value;
            //    los = "News.aspx?NewsID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGallery = @"^.*-ng([0-9]+)$";
            //Regex currencyRegex4 = new Regex(patternNewsGallery);

            //Match result3 = Regex.Match(path, patternNewsGallery);
            ////string los;
            //if (currencyRegex4.IsMatch(path))
            //{

            //    string key = result3.Groups[1].Value;
            //    los = "NewsGallery.aspx?SectorID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGalleryPage = @"^.*-ng([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex5 = new Regex(patternNewsGalleryPage);

            //Match result4 = Regex.Match(path, patternNewsGalleryPage);
            ////string los;
            //if (currencyRegex5.IsMatch(path))
            //{

            //    string key = result4.Groups[1].Value;
            //    string key2 = result4.Groups[2].Value;
            //    los = "NewsGallery.aspx?SectorID=" + key+ "&Page="+ key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGallery = @"^.*-ig([0-9]+)$";
            //Regex currencyRegex6 = new Regex(patternImageGallery);

            //Match result5 = Regex.Match(path, patternImageGallery);
            ////string los;
            //if (currencyRegex6.IsMatch(path))
            //{

            //    string key = result5.Groups[1].Value;
            //    los = "Gallery.aspx?SectorID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGalleryPage = @"^.*-ig([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex7 = new Regex(patternImageGalleryPage);

            //Match result6 = Regex.Match(path, patternImageGalleryPage);
            ////string los;
            //if (currencyRegex7.IsMatch(path))
            //{

            //    string key = result6.Groups[1].Value;
            //    string key2 = result6.Groups[2].Value;
            //    los = "Gallery.aspx?SectorID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}
            //string patternVideoGallery = @"^.*-vg([0-9]+)$";
            //Regex currencyRegex8 = new Regex(patternVideoGallery);

            //Match result7 = Regex.Match(path, patternVideoGallery);
            ////string los;
            //if (currencyRegex8.IsMatch(path))
            //{

            //    string key = result7.Groups[1].Value;
            //    los = "VideoGallery.aspx?SectorID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternVideoGalleryPage = @"^.*-vg([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex9 = new Regex(patternVideoGalleryPage);

            //Match result8 = Regex.Match(path, patternVideoGalleryPage);
            ////string los;
            //if (currencyRegex9.IsMatch(path))
            //{

            //    string key = result8.Groups[1].Value;
            //    string key2 = result8.Groups[2].Value;
            //    los = "VideoGallery.aspx?SectorID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGalleryProgram = @"^.*-ngp([0-9]+)$";
            //Regex currencyRegex10 = new Regex(patternNewsGalleryProgram);

            //Match result9 = Regex.Match(path, patternNewsGalleryProgram);
            ////string los;
            //if (currencyRegex10.IsMatch(path))
            //{

            //    string key = result9.Groups[1].Value;
            //    los = "NewsGallery.aspx?ProgramID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGalleryProgramPage = @"^.*-ngp([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex11 = new Regex(patternNewsGalleryProgramPage);

            //Match result10 = Regex.Match(path, patternNewsGalleryProgramPage);
            ////string los;
            //if (currencyRegex11.IsMatch(path))
            //{

            //    string key = result10.Groups[1].Value;
            //    string key2 = result10.Groups[2].Value;
            //    los = "NewsGallery.aspx?ProgramID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGalleryProgram = @"^.*-igp([0-9]+)$";
            //Regex currencyRegex12 = new Regex(patternImageGalleryProgram);

            //Match result11 = Regex.Match(path, patternImageGalleryProgram);
            ////string los;
            //if (currencyRegex12.IsMatch(path))
            //{

            //    string key = result11.Groups[1].Value;
            //    los = "Gallery.aspx?ProgramID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGalleryProgramPage = @"^.*-igp([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex13 = new Regex(patternImageGalleryProgramPage);

            //Match result12 = Regex.Match(path, patternImageGalleryProgramPage);
            ////string los;
            //if (currencyRegex13.IsMatch(path))
            //{

            //    string key = result12.Groups[1].Value;
            //    string key2 = result12.Groups[2].Value;
            //    los = "Gallery.aspx?ProgramID=" + key + "&Page=" + key2;
                
            //    Context.RewritePath(los, true);
            //}
            //string patternVideoGalleryProgram = @"^.*-vgp([0-9]+)$";
            //Regex currencyRegex14 = new Regex(patternVideoGalleryProgram);

            //Match result13 = Regex.Match(path, patternVideoGalleryProgram);
            ////string los;
            //if (currencyRegex14.IsMatch(path))
            //{

            //    string key = result13.Groups[1].Value;
            //    los = "VideoGallery.aspx?ProgramID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternVideoGalleryProgramPage = @"^.*-vgp([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex15 = new Regex(patternVideoGalleryProgramPage);

            //Match result14 = Regex.Match(path, patternVideoGalleryProgramPage);
            ////string los;
            //if (currencyRegex15.IsMatch(path))
            //{

            //    string key = result14.Groups[1].Value;
            //    string key2 = result14.Groups[2].Value;
            //    los = "VideoGallery.aspx?ProgramID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}

            //string patternProject = @"^.*-j([0-9]+)$";
            //Regex currencyRegex16 = new Regex(patternProject);

            //Match result15 = Regex.Match(path, patternProject);
            ////string los;
            //if (currencyRegex16.IsMatch(path))
            //{

            //    string key = result15.Groups[1].Value;
            //    los = "Project.aspx?ProjectID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGalleryProject = @"^.*-ngj([0-9]+)$";
            //Regex currencyRegex17 = new Regex(patternNewsGalleryProject);

            //Match result16 = Regex.Match(path, patternNewsGalleryProject);
            ////string los;
            //if (currencyRegex17.IsMatch(path))
            //{

            //    string key = result16.Groups[1].Value;
            //    los = "NewsGallery.aspx?ProjectID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternNewsGalleryProjectPage = @"^.*-ngj([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex18 = new Regex(patternNewsGalleryProjectPage);

            //Match result17 = Regex.Match(path, patternNewsGalleryProjectPage);
            ////string los;
            //if (currencyRegex18.IsMatch(path))
            //{

            //    string key = result17.Groups[1].Value;
            //    string key2 = result17.Groups[2].Value;
            //    los = "NewsGallery.aspx?ProjectID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGalleryProject = @"^.*-igj([0-9]+)$";
            //Regex currencyRegex19 = new Regex(patternImageGalleryProject);

            //Match result18 = Regex.Match(path, patternImageGalleryProject);
            ////string los;
            //if (currencyRegex19.IsMatch(path))
            //{

            //    string key = result18.Groups[1].Value;
            //    los = "Gallery.aspx?ProjectID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternImageGalleryProjectPage = @"^.*-igj([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex20 = new Regex(patternImageGalleryProjectPage);

            //Match result19 = Regex.Match(path, patternImageGalleryProjectPage);
            ////string los;
            //if (currencyRegex20.IsMatch(path))
            //{

            //    string key = result19.Groups[1].Value;
            //    string key2 = result19.Groups[2].Value;
            //    los = "Gallery.aspx?ProjectID=" + key + "&Page=" + key2;

            //    Context.RewritePath(los, true);
            //}

            //string patternVideoGalleryProject = @"^.*-vgj([0-9]+)$";
            //Regex currencyRegex21 = new Regex(patternVideoGalleryProject);

            //Match result20 = Regex.Match(path, patternVideoGalleryProject);
            ////string los;
            //if (currencyRegex21.IsMatch(path))
            //{

            //    string key = result20.Groups[1].Value;
            //    los = "VideoGallery.aspx?ProjectID=" + key;
            //    Context.RewritePath(los, true);
            //}
            //string patternVideoGalleryProjectPage = @"^.*-vgj([0-9]+)-pg([0-9]+)$";
            //Regex currencyRegex22 = new Regex(patternVideoGalleryProjectPage);

            //Match result21 = Regex.Match(path, patternVideoGalleryProjectPage);
            ////string los;
            //if (currencyRegex22.IsMatch(path))
            //{

            //    string key = result21.Groups[1].Value;
            //    string key2 = result21.Groups[2].Value;
            //    los = "VideoGallery.aspx?ProjectID=" + key + "&Page=" + key2;
            //    //NewsGallery.aspx? SectorID = { 0 }&Page ={ 1}
            //    Context.RewritePath(los, true);
            //}

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}