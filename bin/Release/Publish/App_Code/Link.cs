using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onder1
{
    public static class Link
    {
        private static string BuildAbsolute(string relativeUri)
        {
            // get current uri
            Uri uri = HttpContext.Current.Request.Url;
            // build absolute path
            string app = HttpContext.Current.Request.ApplicationPath;
            if (!app.EndsWith("/")) app += "/";
            relativeUri = relativeUri.TrimStart('/');
            // return the absolute path
            return HttpUtility.UrlPathEncode(
              String.Format("http://{0}:{1}{2}{3}",
              uri.Host, uri.Port, app, relativeUri));
        }
        public static string ToSector(string sectorId)
        {
            
                return BuildAbsolute(String.Format("Sector.aspx?SectorID={0}", sectorId));
            
        }
        
        public static string ToSectorByName(string sectorName)
        {
            int sectorId=0;
            
            return BuildAbsolute(String.Format("Sector.aspx?SectorID={0}", sectorId));

        }

        public static string ToProgram(string sectorId, string programId)
        {
            
                return BuildAbsolute(String.Format("Sector.aspx?SectorID={0}&ProgramID={1}", sectorId, programId));
            
        }

        

    }
}