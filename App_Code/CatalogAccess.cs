using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Onder1
{
    /// <summary>
    /// 
    /// </summary>
    public struct SectorDetails
    {
        public int SectorID;
        public string Name;
        public string Description;
        public string Skeleton;
        public string Logo;
        public string SkeletonCode;
        public string Admin;
        public int EmployeeNo;
        public string Notes;
        public int BenefitNo;
    }
    public struct ProgramDetails
    {
        public int ProgramID;
        public int SectorID;
        public string SectorName;
        public string Name;
        public string Description;
        public string Logo;
        public string SkeletonCode;
        public string Admin;
        public int EmployeeNo;
        public string Notes;
        public int BenefitNo;
    }
    public struct ProjectDetails
    {
        public int ProjectID;
        public int ProgramID;
        public int SectorID;
        public string SectorName;
        public string ProgramName;
        public string Name;
        public string Description;
        public string SectorLogo;
        public string Logo;
        public string SkeletonCode;
        public string Admin;
        public int EmployeeNo;
        public string Notes;
        public int BenefitNo;
    }
    public struct NewsDetails
    {
        public int NewsID;
        public int ProjectID;
        public string Title;
        public string Details;
        public DateTime Date;
        
    }
    public struct NewsAllDetails
    {
        public int NewsID;
        public int ProjectID;
        public string Title;
        public string Details;
        public DateTime Date;
        public int ImageID;
        public string Image;
        public bool PrimaryImage;
        public string Sector;
        public string Program;
        public string Project;
        public int VideoID;
        public string VideoTitle;
        public string VideoUrl;
    }
    public struct ImageDetails
    {
        public int ImageID;
        public int ProjectID;
        public string Title;
        public string Image;
        public DateTime Date;
        public string Sector;
        public string Program;
        public string Project;
        
    }
    public struct VideoDetails
    {
        public int VideoID;
        public int ProjectID;
        public string Title;
        public string Details;
        public string VideoUrl;
        public DateTime Date;
        public string Sector;
        public string Program;
        public string Project;

    }
    public struct RelatedImage
    {
        public int ImageID;
        public string Image;
    }
    public struct Keyword
    {
        public int KeywordID;
        public string Word;
    }


    public static class CatalogAccess
    {
        static CatalogAccess()
        {
            
        }

        
        public static SectorDetails GetSectorDetails(string sectorId)
        {
            SectorDetails details = new SectorDetails();
             
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetSectorDetails";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.SectorID = Int32.Parse(table.Rows[0]["SectorID"].ToString());

                details.Name = table.Rows[0]["Name"].ToString();

                
                
                details.Description = (table.Rows[0]["Description"] == DBNull.Value) ? string.Empty : table.Rows[0]["Description"].ToString(); 
                

                if(table.Rows[0]["Skeleton"] == DBNull.Value)
                {
                    details.Skeleton = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Skeleton"];
                    details.Skeleton = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }


                if (table.Rows[0]["Logo"] == DBNull.Value)
                {
                    details.Logo = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Logo"];
                    details.Logo = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }
                
                details.SkeletonCode = (table.Rows[0]["SkeletonCode"] == DBNull.Value) ? string.Empty : table.Rows[0]["SkeletonCode"].ToString();
                

                details.Admin = (table.Rows[0]["Admin"] == DBNull.Value) ? string.Empty : table.Rows[0]["Admin"].ToString();
               

                details.EmployeeNo = (table.Rows[0]["EmployeeNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["EmployeeNo"].ToString());
                

                details.Notes = (table.Rows[0]["Notes"] == DBNull.Value) ? string.Empty : table.Rows[0]["Notes"].ToString();

                details.BenefitNo = (table.Rows[0]["BenefitNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["BenefitNo"].ToString());

            }
            
           
            return details;
        }

        
        public static ProgramDetails GetProgramDetails(string programId)
        {
            ProgramDetails details = new ProgramDetails();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetProgramDetails";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
           


            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.ProgramID = Int32.Parse(table.Rows[0]["ProgramID"].ToString());
                details.SectorID = Int32.Parse(table.Rows[0]["SectorID"].ToString());
                details.SectorName = table.Rows[0]["SectorName"].ToString();
                details.Name = table.Rows[0]["Name"].ToString();

               

                details.Description = (table.Rows[0]["Description"] == DBNull.Value) ? string.Empty : table.Rows[0]["Description"].ToString();

                                
                if (table.Rows[0]["Logo"] == DBNull.Value)
                {
                    details.Logo = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Logo"];
                    details.Logo = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }

                details.SkeletonCode = (table.Rows[0]["SkeletonCode"] == DBNull.Value) ? string.Empty : table.Rows[0]["SkeletonCode"].ToString();


                details.Admin = (table.Rows[0]["Admin"] == DBNull.Value) ? string.Empty : table.Rows[0]["Admin"].ToString();


                details.EmployeeNo = (table.Rows[0]["EmployeeNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["EmployeeNo"].ToString());


                details.Notes = (table.Rows[0]["Notes"] == DBNull.Value) ? string.Empty : table.Rows[0]["Notes"].ToString();

                details.BenefitNo = (table.Rows[0]["BenefitNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["BenefitNo"].ToString());

            }

            
            return details;
        }
        public static ProgramDetails GetProgramDetailsForAdmin(string programId)
        {
            ProgramDetails details = new ProgramDetails();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetProgramDetailsForAdmin";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);



            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.ProgramID = Int32.Parse(table.Rows[0]["ProgramID"].ToString());
                details.SectorID = Int32.Parse(table.Rows[0]["SectorID"].ToString());
                details.SectorName = table.Rows[0]["SectorName"].ToString();
                details.Name = table.Rows[0]["Name"].ToString();



                details.Description = (table.Rows[0]["Description"] == DBNull.Value) ? string.Empty : table.Rows[0]["Description"].ToString();


                if (table.Rows[0]["Logo"] == DBNull.Value)
                {
                    details.Logo = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Logo"];
                    details.Logo = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }

                details.SkeletonCode = (table.Rows[0]["SkeletonCode"] == DBNull.Value) ? string.Empty : table.Rows[0]["SkeletonCode"].ToString();


                details.Admin = (table.Rows[0]["Admin"] == DBNull.Value) ? string.Empty : table.Rows[0]["Admin"].ToString();


                details.EmployeeNo = (table.Rows[0]["EmployeeNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["EmployeeNo"].ToString());


                details.Notes = (table.Rows[0]["Notes"] == DBNull.Value) ? string.Empty : table.Rows[0]["Notes"].ToString();

                details.BenefitNo = (table.Rows[0]["BenefitNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["BenefitNo"].ToString());

            }


            return details;
        }
        public static ProjectDetails GetProjectDetails(string projectId)
        {
            ProjectDetails details = new ProjectDetails();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetProjectDetails";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);



            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.ProjectID = Int32.Parse(table.Rows[0]["ProjectID"].ToString());
                details.ProgramID = Int32.Parse(table.Rows[0]["ProgramID"].ToString());
                details.SectorID = Int32.Parse(table.Rows[0]["SectorID"].ToString());
                details.SectorName = table.Rows[0]["SectorName"].ToString();
                details.ProgramName = table.Rows[0]["ProgramName"].ToString();
                details.Name = table.Rows[0]["Name"].ToString();



                details.Description = (table.Rows[0]["Description"] == DBNull.Value) ? string.Empty : table.Rows[0]["Description"].ToString();

                if (table.Rows[0]["SectorLogo"] == DBNull.Value)
                {
                    details.SectorLogo = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["SectorLogo"];
                    details.SectorLogo = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }

                if (table.Rows[0]["Logo"] == DBNull.Value)
                {
                    details.Logo = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Logo"];
                    details.Logo = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }

                details.SkeletonCode = (table.Rows[0]["SkeletonCode"] == DBNull.Value) ? string.Empty : table.Rows[0]["SkeletonCode"].ToString();


                details.Admin = (table.Rows[0]["Admin"] == DBNull.Value) ? string.Empty : table.Rows[0]["Admin"].ToString();


                details.EmployeeNo = (table.Rows[0]["EmployeeNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["EmployeeNo"].ToString());


                details.Notes = (table.Rows[0]["Notes"] == DBNull.Value) ? string.Empty : table.Rows[0]["Notes"].ToString();

                details.BenefitNo = (table.Rows[0]["BenefitNo"] == DBNull.Value) ? 0 : Int32.Parse(table.Rows[0]["BenefitNo"].ToString());

            }


            return details;
        }
        public static NewsDetails GetNewsDetails(string newsId)
        {
            NewsDetails details = new NewsDetails();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetNewsByID";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
                                  
            if (table.Rows.Count > 0)
            {
                details.NewsID = Int32.Parse(table.Rows[0]["NewsID"].ToString());

                details.ProjectID = Int32.Parse(table.Rows[0]["ProjectID"].ToString());

                details.Title = table.Rows[0]["Title"].ToString();

               

            }

            
            return details;
        }

        public static VideoDetails GetVideoDetails(string videoId)
        {
            VideoDetails details = new VideoDetails();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "GetVideoDetails";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@VideoID";
            param.Value = videoId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            if (table.Rows.Count > 0)
            {
                details.VideoID = Int32.Parse(table.Rows[0]["VideoID"].ToString());

                details.ProjectID = Int32.Parse(table.Rows[0]["ProjectID"].ToString());

                details.Title = table.Rows[0]["Title"].ToString();
                details.Sector = table.Rows[0]["Sector"].ToString();

                details.Program = table.Rows[0]["Program"].ToString();

                details.Project = table.Rows[0]["Project"].ToString();


                if (table.Rows[0]["Details"] == DBNull.Value)
                {
                    details.Details = string.Empty;
                }
                else
                {
                    details.Details = table.Rows[0]["Details"].ToString();
                }
                if (table.Rows[0]["VideoUrl"] == DBNull.Value)
                {
                    details.VideoUrl = string.Empty;
                }
                else
                {
                    details.VideoUrl = table.Rows[0]["VideoUrl"].ToString();
                }
                if (table.Rows[0]["Date"] == DBNull.Value)
                {
                    details.Date = DateTime.Parse("01/01/1900");
                }
                else
                {
                    details.Date = DateTime.Parse(table.Rows[0]["Date"].ToString());
                }

                

            }


            return details;
        }

        public static NewsAllDetails GetNewsDetailsForAdmin(string newsId)
        {
            NewsAllDetails details = new NewsAllDetails();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetNewsByIDForAdmin";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.NewsID = Int32.Parse(table.Rows[0]["NewsID"].ToString());

                details.ProjectID = Int32.Parse(table.Rows[0]["ProjectID"].ToString());

                details.Title = table.Rows[0]["Title"].ToString();

                details.Sector = table.Rows[0]["Sector"].ToString();

                details.Program = table.Rows[0]["Program"].ToString();

                details.Project = table.Rows[0]["Project"].ToString();

                if (table.Rows[0]["Details"] == DBNull.Value)
                {
                    details.Details = string.Empty;
                }
                else
                {
                    details.Details = table.Rows[0]["Details"].ToString();
                }
                if (table.Rows[0]["Date"] == DBNull.Value)
                {
                    details.Date = DateTime.Parse("01/01/1900");
                }
                else
                {
                    details.Date = DateTime.Parse(table.Rows[0]["Date"].ToString());
                }
                if (table.Rows[0]["ImageID"] == DBNull.Value)
                {
                    details.ImageID = -2;
                }
                else
                {
                    details.ImageID = Int32.Parse(table.Rows[0]["ImageID"].ToString());
                }
                if (table.Rows[0]["Image"] == DBNull.Value)
                {
                    details.Image = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Image"];
                    details.Image = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }



                
                if (table.Rows[0]["VideoID"] == DBNull.Value)
                {
                    details.VideoID = -2;
                }
                else
                {
                    details.VideoID = Int32.Parse(table.Rows[0]["VideoID"].ToString());
                }
                if (table.Rows[0]["VideoUrl"] == DBNull.Value)
                {
                    details.VideoUrl = string.Empty;
                }
                else
                {
                    details.VideoUrl = table.Rows[0]["VideoUrl"].ToString(); 
                }
                if (table.Rows[0]["VideoTitle"] == DBNull.Value)
                {
                    details.VideoTitle = string.Empty;
                }
                else
                {
                    details.VideoTitle = table.Rows[0]["VideoTitle"].ToString();
                }

            }


            return details;
        }

        public static ImageDetails GetImageDetailsForAdmin(string imageId)
        {
            ImageDetails details = new ImageDetails();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetImageDetailsForAdmin";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ImageID";
            param.Value = imageId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {
                details.ImageID  = Int32.Parse(table.Rows[0]["ImageID"].ToString());

                details.ProjectID = Int32.Parse(table.Rows[0]["ProjectID"].ToString());

                details.Title = table.Rows[0]["Title"].ToString();

                details.Sector = table.Rows[0]["Sector"].ToString();

                details.Program = table.Rows[0]["Program"].ToString();

                details.Project = table.Rows[0]["Project"].ToString();

                
                if (table.Rows[0]["Date"] == DBNull.Value)
                {
                    details.Date = DateTime.Parse("01/01/1900");
                }
                else
                {
                    details.Date = DateTime.Parse(table.Rows[0]["Date"].ToString());
                }
                
                if (table.Rows[0]["Image"] == DBNull.Value)
                {
                    details.Image = string.Empty;
                }
                else
                {
                    imgBytes = (byte[])table.Rows[0]["Image"];
                    details.Image = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                }



            }


            return details;
        }
        public static DataTable GetProgramsInSector(string sectorId)
        {
                DataTable table = new DataTable();
            
                
                DbCommand comm = GenericDataAccess.CreateCommand();
               
                comm.CommandText = "CatalogGetProgramsInSector";
                
                DbParameter param = comm.CreateParameter();
                param.ParameterName = "@SectorID";
                param.Value = sectorId;
                param.DbType = DbType.Int32;
                comm.Parameters.Add(param);
                
                param = comm.CreateParameter();
                param.ParameterName = "@DescriptionLength";
                param.Value = OnderShopConfiguration.NewsDescriptionLength;
                param.DbType = DbType.Int32;
                comm.Parameters.Add(param);

                
                table = GenericDataAccess.ExecuteSelectCommand(comm);

                
                table.Columns.Add("Image", typeof(string));

                 
                byte[] imgBytes;
                if (table.Rows.Count > 0)
                {

                    
                    foreach (DataRow row in table.Rows)
                    {

                        if (row["Description"] == DBNull.Value)
                        {
                            row["Description"] = string.Empty;
                        }
                        if (row["Logo"] == DBNull.Value)
                        {
                            row["Image"] = string.Empty;
                        }
                        else
                        {
                            imgBytes = (byte[])row["Logo"];
                            row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                        }
                        if (row["SkeletonCode"] == DBNull.Value)
                        {
                            row["SkeletonCode"] = string.Empty;
                        }
                        if (row["Admin"] == DBNull.Value)
                        {
                            row["Admin"] = string.Empty;
                        }
                        if (row["EmployeeNo"] == DBNull.Value)
                        {
                            row["EmployeeNo"] = 0;
                        }
                        if (row["Notes"] == DBNull.Value)
                        {
                            row["Notes"] = string.Empty;
                        }
                    }
                    
                    table.Columns.Remove("Logo");



                }
            
            
            return table;
        }

        
        public static DataTable GetProjectsInSector(string sectorId)
        {
            DataTable table = new DataTable();
            
                
                DbCommand comm = GenericDataAccess.CreateCommand();
                
                comm.CommandText = "CatalogGetProjectsInSector";
                
                DbParameter param = comm.CreateParameter();
                param.ParameterName = "@SectorID";
                param.Value = sectorId;
                param.DbType = DbType.Int32;
                comm.Parameters.Add(param);
               
                param = comm.CreateParameter();
                param.ParameterName = "@DescriptionLength";
                param.Value = OnderShopConfiguration.ProjectsDescriptionLength;
                param.DbType = DbType.Int32;
                comm.Parameters.Add(param);

                
                 table = GenericDataAccess.ExecuteSelectCommand(comm);

                 
                table.Columns.Add("Image", typeof(string));

                
                byte[] imgBytes;
                if (table.Rows.Count > 0)
                {

                    
                    foreach (DataRow row in table.Rows)
                    {

                        if (row["Description"] == DBNull.Value)
                        {
                            row["Description"] = string.Empty;
                        }
                        if (row["Logo"] == DBNull.Value)
                        {
                            row["Image"] = string.Empty;
                        }
                        else
                        {
                            imgBytes = (byte[])row["Logo"];
                            row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                        }
                        if (row["SkeletonCode"] == DBNull.Value)
                        {
                            row["SkeletonCode"] = string.Empty;
                        }
                        if (row["BenefitNo"] == DBNull.Value)
                        {
                            row["BenefitNo"] = 0;
                        }
                        if (row["Admin"] == DBNull.Value)
                        {
                            row["Admin"] = string.Empty;
                        }
                        if (row["EmployeeNo"] == DBNull.Value)
                        {
                            row["EmployeeNo"] = 0;
                        }
                        if (row["Notes"] == DBNull.Value)
                        {
                            row["Notes"] = string.Empty;
                        }
                    }
                    
                    table.Columns.Remove("Logo");



                }
           
            
            return table;
        }

        public static DataTable GetAllProjectsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllProjectsForAdmin";
            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            return table;
        }
        public static DataTable GetAllProgramsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllProgramsForAdmin";

            table = GenericDataAccess.ExecuteSelectCommand(comm);

            return table;
        }
        public static DataTable GetAllSectorsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllSectorsForAdmin";

            table = GenericDataAccess.ExecuteSelectCommand(comm);

            return table;
        }
        public static DataTable GetProjectsInProgram(string programId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetProjectsInProgram";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.ProjectsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

           
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("Image", typeof(string));

            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Description"] == DBNull.Value)
                    {
                        row["Description"] = string.Empty;
                    }
                    if (row["Logo"] == DBNull.Value)
                    {
                        row["Image"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Logo"];
                        row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["SkeletonCode"] == DBNull.Value)
                    {
                        row["SkeletonCode"] = string.Empty;
                    }
                    if (row["BenefitNo"] == DBNull.Value)
                    {
                        row["BenefitNo"] = 0;
                    }
                    if (row["Admin"] == DBNull.Value)
                    {
                        row["Admin"] = string.Empty;
                    }
                    if (row["EmployeeNo"] == DBNull.Value)
                    {
                        row["EmployeeNo"] = 0;
                    }
                    if (row["Notes"] == DBNull.Value)
                    {
                        row["Notes"] = string.Empty;
                    }
                }
                
                table.Columns.Remove("Logo");



            }

            
            return table;
        }

        public static DataTable GetAllProjectsDetailsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllProjectsDetailsForAdmin";

            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("Image", typeof(string));
            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Description"] == DBNull.Value)
                    {
                        row["Description"] = string.Empty;
                    }
                    if (row["Logo"] == DBNull.Value)
                    {
                        row["Image"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Logo"];
                        row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["SkeletonCode"] == DBNull.Value)
                    {
                        row["SkeletonCode"] = string.Empty;
                    }
                    if (row["BenefitNo"] == DBNull.Value)
                    {
                        row["BenefitNo"] = 0;
                    }
                    if (row["Admin"] == DBNull.Value)
                    {
                        row["Admin"] = string.Empty;
                    }
                    if (row["EmployeeNo"] == DBNull.Value)
                    {
                        row["EmployeeNo"] = 0;
                    }
                    if (row["Notes"] == DBNull.Value)
                    {
                        row["Notes"] = string.Empty;
                    }
                    row["BelongsTo"] = row["SectorName"] + "/" + row["ProgramsName"]; /*+ "/" + row["Project"];*/
                }

                table.Columns.Remove("Logo");



            }


            return table;
        }

        public static DataTable GetAllProgramDetailsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllProgramsDetailsForAdmin";

            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("Image", typeof(string));
            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Description"] == DBNull.Value)
                    {
                        row["Description"] = string.Empty;
                    }
                    if (row["Logo"] == DBNull.Value)
                    {
                        row["Image"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Logo"];
                        row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["SkeletonCode"] == DBNull.Value)
                    {
                        row["SkeletonCode"] = string.Empty;
                    }
                    if (row["BenefitNo"] == DBNull.Value)
                    {
                        row["BenefitNo"] = 0;
                    }
                    if (row["Admin"] == DBNull.Value)
                    {
                        row["Admin"] = string.Empty;
                    }
                    if (row["EmployeeNo"] == DBNull.Value)
                    {
                        row["EmployeeNo"] = 0;
                    }
                    if (row["Notes"] == DBNull.Value)
                    {
                        row["Notes"] = string.Empty;
                    }
                    row["BelongsTo"] = row["SectorName"] ; /*+ "/" + row["Project"];*/
                }

                table.Columns.Remove("Logo");



            }


            return table;
        }

        public static DataTable GetAllSectorsDetailsForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllSectorsDetailsForAdmin";

            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("Image", typeof(string));
            table.Columns.Add("Structure", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Description"] == DBNull.Value)
                    {
                        row["Description"] = string.Empty;
                    }
                    if (row["Logo"] == DBNull.Value)
                    {
                        row["Image"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Logo"];
                        row["Image"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["Skeleton"] == DBNull.Value)
                    {
                        row["Structure"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Skeleton"];
                        row["Structure"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["SkeletonCode"] == DBNull.Value)
                    {
                        row["SkeletonCode"] = string.Empty;
                    }
                    if (row["BenefitNo"] == DBNull.Value)
                    {
                        row["BenefitNo"] = 0;
                    }
                    if (row["Admin"] == DBNull.Value)
                    {
                        row["Admin"] = string.Empty;
                    }
                    if (row["EmployeeNo"] == DBNull.Value)
                    {
                        row["EmployeeNo"] = 0;
                    }
                    if (row["Notes"] == DBNull.Value)
                    {
                        row["Notes"] = string.Empty;
                    }
                    
                }

                table.Columns.Remove("Logo");
                table.Columns.Remove("Skeleton");


            }


            return table;
        }
        public static DataTable GetAllNewsInAll( string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetAllNewsInAll";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);
            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
           
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }
        public static DataTable GetAllNewsInAllForAdmin()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllNewsInAllForAdmin";

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

           

            table.Columns.Add("NewsImage", typeof(string));

            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetAllImageInAllForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllImageInAllForAdmin";

            //DbParameter param = comm.CreateParameter();
            //param.ParameterName = "@SectorID";
            //param.Value = sectorId;
            //param.DbType = DbType.Int32;
            //comm.Parameters.Add(param);



            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("SectorImage", typeof(string));
            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    row["BelongsTo"] = row["ProjectsName"] + "/" + row["ProgramsName"] + "/" + row["SectorName"];


                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetAllVideosInAllForAdmin()
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllVideosInAllForAdmin";

            



            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }
        public static DataTable GetNewsInSector(string sectorId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetNewsInSector";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                     
                        if (row["Image"] == DBNull.Value)
                        {
                          row["NewsImage"] = string.Empty;
                        }
                        else
                        {
                          imgBytes = (byte[])row["Image"];
                          row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                        }
                    
                    
                    
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }
                    
                        row["BelongsTo"] = row["Sector"] +"/"+ row["Program"] +"/"+ row["Project"];
                    

                }
                
                table.Columns.Remove("Image");



            }

            
            return table;
        }

        
        public static DataTable GetNewsInProgram(string programId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetNewsInProgram";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        public static DataTable GetNewsInProject(string projectId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetNewsInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("NewsImage", typeof(string));

            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }

                table.Columns.Remove("Image");



            }


            return table;
        }
        public static DataTable GetNewsByID(string newsId)
        {
            DataTable table = new DataTable();

           
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetNewsByID";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

             
            table.Columns.Add("NewsImage", typeof(string));

            
            table.Columns.Add("Secondary", typeof(string));

            
            table.Columns.Add("BelongsTo", typeof(string));

            
            table.Columns.Add("Details1", typeof(string));

           
            table.Columns.Add("Details2", typeof(string));

            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    else
                    {
                        string totalDetails = row["Details"].ToString();
                        int countTotalDetails = totalDetails.Length;
                        double multi = (countTotalDetails * 30) / 100;
                        int percentageTotal =(int) (Math.Ceiling(multi));
                        int index1;
                        index1 = totalDetails.IndexOf(' ', percentageTotal);
                        string detail1 = totalDetails.Substring(0, index1);
                        string detail2 = totalDetails.Substring(index1 + 1, countTotalDetails - index1 - 1) ;
                        row["Details1"] = detail1;
                        row["Details2"] = detail2;

                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    
                    if (row["SecodaryImage"] == DBNull.Value)
                    {
                        row["Secondary"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["SecodaryImage"];
                        row["Secondary"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");
                table.Columns.Remove("SecodaryImage");



            }

            
            return table;
        }

        public static DataTable GetNewsByIDForAdmin(string newsId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetNewsByID";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("NewsImage", typeof(string));


            table.Columns.Add("Secondary", typeof(string));


            table.Columns.Add("BelongsTo", typeof(string));


            


            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }

                    if (row["SecodaryImage"] == DBNull.Value)
                    {
                        row["Secondary"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["SecodaryImage"];
                        row["Secondary"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }

                table.Columns.Remove("Image");
                table.Columns.Remove("SecodaryImage");



            }


            return table;
        }


        public static DataTable GetKeywordInNews(string newsId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetKeywordInNews";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            table = GenericDataAccess.ExecuteSelectCommand(comm);
            if (table.Rows.Count > 0)
            {

                



            }

            
            return table;
        }

        
        public static DataTable GetImageInSector(string sectorId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetImageInSector";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("SectorImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    

                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    


                }
                
                table.Columns.Remove("Image");



            }

            
            return table;
        }

       
        public static DataTable GetImageInProgram(string programId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetImageInProgram";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


           
            table = GenericDataAccess.ExecuteSelectCommand(comm);

             
            table.Columns.Add("SectorImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }






                }
                
                table.Columns.Remove("Image");



            }

            
            return table;
        }

        public static DataTable GetImageInProject(string projectId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetImageInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("SectorImage", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }






                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetProjectsInImageGallery()
        {
            DataTable projecTable = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetProjectsInImageGallery";

            projecTable = GenericDataAccess.ExecuteSelectCommand(comm);

            return projecTable;
        }
        public static List<ProjectAndDate> GetTop10ImageInDifferentProjectsOrderByDate()
        {
            DataTable Table = new DataTable();
            List<ProjectAndDate> Dt = new List<ProjectAndDate>();
            Table = GetProjectsInImageGallery();
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow row in Table.Rows)
                {
                    ProjectAndDate oneElement = new ProjectAndDate();

                    oneElement.ProjectID = Int32.Parse(row["ProjectID"].ToString());
                    oneElement.Date = DateTime.Parse(row["Date"].ToString());
                    //rowOne=oneTable.Rows[0];
                    //allTable.Rows.Add(rowOne);
                    //Dt.Find();
                    if (!Dt.Exists(x => x.ProjectID == oneElement.ProjectID))
                    {
                        Dt.Add(oneElement);
                    }
                    if (Dt.Count >= 10)
                        break;

                }

            }
            //List<IdentityUser> SelectedDt = new List<IdentityUser>();
            return Dt;
        }
        public static DataTable GetTop10ImageInDifferentProjects()
        {
            ///////////
            //DataTable projecTable = new DataTable();


            //DbCommand comm = GenericDataAccess.CreateCommand();

            //comm.CommandText = "CatalogDistinctProjectForImageGallery";

            //projecTable = GenericDataAccess.ExecuteSelectCommand(comm);

            List<ProjectAndDate> projecList = new List<ProjectAndDate>();
            projecList = GetTop10ImageInDifferentProjectsOrderByDate();

            DataTable allTable = new DataTable();
            allTable.Columns.Add("SectorImage", typeof(string));
            allTable.Columns.Add("ImageID", typeof(int));
            allTable.Columns.Add("Date", typeof(DateTime));
            

            if (projecList.Count > 0)
            {
                DataTable oneTable = new DataTable();

                foreach (ProjectAndDate row in projecList)
                {
                    
                    oneTable= GetImageTopFirstInProject( row.ProjectID.ToString());
                    

                   
                    if (oneTable.Rows.Count > 0)
                    {
                        DataRow rowOne = allTable.NewRow();
                        rowOne["ImageID"] = oneTable.Rows[0]["ImageID"];
                        rowOne["SectorImage"] = oneTable.Rows[0]["SectorImage"];
                        rowOne["Date"] = oneTable.Rows[0]["Date"];
                        //rowOne=oneTable.Rows[0];
                        allTable.Rows.Add(rowOne);
                            
                    }
                    oneTable.Dispose();
                }

            }
            

            return allTable;
        }

        public static DataTable GetImageTopFirstInProject(string projectId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetFirstImageInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            table = GenericDataAccess.ExecuteSelectCommand(comm);


            table.Columns.Add("SectorImage", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }






                }

                table.Columns.Remove("Image");



            }


            return table;
        }
        public static DataTable GetImageInNews(string newsId)
        {
            DataTable table = new DataTable();

           
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetImageInNews";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

           
            table.Columns.Add("SectorImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }






                }
                
                table.Columns.Remove("Image");



            }

            
            return table;
        }

        
        public static DataTable GetVideoInSector(string sectorId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetVideoInSector";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {
                    
                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }

                }
                

            }

           
            return table;
        }
        public static DataTable GetAllVideosInSector(string sectorName, string pageNumber, out int howManyPages)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllVideoInSector";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = sectorName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);



            table = GenericDataAccess.ExecuteSelectCommand(comm);
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }

        public static DataTable GetAllVideosInProgram(string programName, string pageNumber, out int howManyPages)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllVideoInProgram";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = programName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);



            table = GenericDataAccess.ExecuteSelectCommand(comm);
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }

        public static DataTable GetAllVideosInProject(string projectName, string pageNumber, out int howManyPages)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllVideosInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = projectName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);



            table = GenericDataAccess.ExecuteSelectCommand(comm);
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }

        public static DataTable GetVideosByID(string videoId)
        {
            


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "GetVideoDetails";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@VideoID";
            param.Value = videoId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            


            table = GenericDataAccess.ExecuteSelectCommand(comm);

            



            
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }
        public static DataTable GetAllVideosInAll( string pageNumber, out int howManyPages)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllVideosInAll";



            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);



            table = GenericDataAccess.ExecuteSelectCommand(comm);
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }
        public static DataTable GetVideoInProgram(string programId)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetVideoInProgram";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


           
            table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }

                }


            }

            
            return table;
        }

        public static DataTable GetVideoInProject(string projectId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetVideoInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }

                }


            }


            return table;
        }
        public static DataTable GetTopImage()
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetTopImage";
            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("SectorImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {



                    if (row["Image"] == DBNull.Value)
                    {
                        row["SectorImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["SectorImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }






                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        
        public static DataTable GetTopVideo()
        {
            DataTable table = new DataTable();

           
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetTopVideo";
            
            


           
            table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }

                }


            }

           
            return table;
        }

        public static DataTable GetProjectsInVideoGallery()
        {
            DataTable projecTable = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetProjectsInVideoGallery";

            projecTable = GenericDataAccess.ExecuteSelectCommand(comm);

            return projecTable;
        }
        public struct ProjectAndDate
        {
            public int ProjectID;
            public DateTime Date;
        }
        public static List<ProjectAndDate> GetTop10VideoInDifferentProjectsOrderByDate()
        {
            DataTable Table = new DataTable();
            List<ProjectAndDate> Dt = new List<ProjectAndDate>();
            Table = GetProjectsInVideoGallery();
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow row in Table.Rows)
                {
                    ProjectAndDate oneElement = new ProjectAndDate();

                    oneElement.ProjectID = Int32.Parse(row["ProjectID"].ToString());
                    oneElement.Date = DateTime.Parse(row["Date"].ToString());
                    //rowOne=oneTable.Rows[0];
                    //allTable.Rows.Add(rowOne);
                    //Dt.Find();
                    if(!Dt.Exists(x => x.ProjectID == oneElement.ProjectID))
                    {
                              Dt.Add(oneElement);
                    }
                    if (Dt.Count >= 10)
                     break;

                }

            }
            //List<IdentityUser> SelectedDt = new List<IdentityUser>();
            return Dt;
        }
        public static DataTable GetTop10VideoInDifferentProjects()
        {
            ///////////
            //DataTable projecTable = new DataTable();


            //DbCommand comm = GenericDataAccess.CreateCommand();

            //comm.CommandText = "CatalogDistinctProjectForVideoGallery";

            //projecTable = GenericDataAccess.ExecuteSelectCommand(comm);
            List<ProjectAndDate> projecList = new List<ProjectAndDate>();
            projecList = GetTop10VideoInDifferentProjectsOrderByDate();
            DataTable allTable = new DataTable();
           

            allTable.Columns.Add("VideoID", typeof(int)); 
            allTable.Columns.Add("ProjectID", typeof(int)); 
            allTable.Columns.Add("Title", typeof(string)); 
            allTable.Columns.Add("Details", typeof(string));
            allTable.Columns.Add("VideoUrl", typeof(string));
           


            if (projecList.Count > 0)
            {
                DataTable oneTable = new DataTable();

                foreach (ProjectAndDate row in projecList)
                {

                    oneTable = GetTopFirstVideoByProjectID(row.ProjectID.ToString());



                    if (oneTable.Rows.Count > 0)
                    {
                        DataRow rowOne = allTable.NewRow();
                        rowOne["VideoID"] = oneTable.Rows[0]["VideoID"];
                        rowOne["ProjectID"] = oneTable.Rows[0]["ProjectID"];
                        rowOne["Title"] = oneTable.Rows[0]["Title"];
                        rowOne["Details"] = oneTable.Rows[0]["Details"];
                        rowOne["VideoUrl"] = oneTable.Rows[0]["VideoUrl"];
                        //rowOne=oneTable.Rows[0];
                        allTable.Rows.Add(rowOne);

                    }
                    oneTable.Dispose();
                }

            }


            return allTable;
        }
        public static DataTable GetTopFirstVideoByProjectID(string projectId)
        {
            DataTable table = new DataTable();


            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetTopFirstVideo";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);




            table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }

                }


            }


            return table;
        }
        public static DataTable GetTopNewsInSector(string sectorName)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetTopNewsInSector";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = sectorName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");



            }

          
            return table;
        }

        

        public static DataTable GetTopNewsInAll()
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetTopNewsInAll";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        

        public static DataTable GetAllNewsInSector(string sectorName,string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetAllNewsInSector";
           
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = sectorName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            
             param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);
            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        public static DataTable GetAllNewsInProgram(string programName, string pageNumber, out int howManyPages)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllNewsInProgram";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = programName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);

            table.Columns.Add("NewsImage", typeof(string));

            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetAllNewsInProject(string projectName, string pageNumber, out int howManyPages)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllNewsInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = projectName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.NewsPerPage);

            table.Columns.Add("NewsImage", typeof(string));

            table.Columns.Add("BelongsTo", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }

                table.Columns.Remove("Image");



            }


            return table;
        }
        public static DataTable GetAllImagesInSector(string sectorName, string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetAllImagesInSector";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = sectorName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.ImagePerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.ImagePerPage);
           
            table.Columns.Add("NewsImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                }
               
                table.Columns.Remove("Image");



            }

            
            return table;
        }

        public static DataTable GetAllImagesInProgram(string programName, string pageNumber, out int howManyPages)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllImagesInProgram";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = programName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.ImagePerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.ImagePerPage);

            table.Columns.Add("NewsImage", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetAllImagesInProject(string projectName, string pageNumber, out int howManyPages)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllImagesInProject";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = projectName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.ImagePerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.ImagePerPage);

            table.Columns.Add("NewsImage", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                }

                table.Columns.Remove("Image");



            }


            return table;
        }

        public static DataTable GetImagesByID(string imageId)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetImagesByID";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ImageID";
            param.Value = imageId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            

            table.Columns.Add("NewsImage", typeof(string));

            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                }

                table.Columns.Remove("Image");



            }


            return table;
        }
        public static DataTable GetAllImagesInAll(string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetAllImagesInAll";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.ImagePerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyNews";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
           
            int howManyNews = Int32.Parse(comm.Parameters["@HowManyNews"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyNews / (double)OnderShopConfiguration.ImagePerPage);
             
            table.Columns.Add("NewsImage", typeof(string));
             
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                       // row["NewsImage"] =  Convert.ToBase64String(imgBytes);
                    }


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        
        public static DataTable Search(string searchString, string allWords, string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "SearchCatalog";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@AllWords";
            param.Value = allWords.ToUpper() == "TRUE" ? "1" : "0";
            param.DbType = DbType.Byte;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyResults";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            int howManyWords = 5;
            
            string[] words = Regex.Split(searchString, "[^\u0621-\u064A0-9]+");
            
            int index = 1;
            for (int i = 0; i <= words.GetUpperBound(0) && index <= howManyWords; i++)
                
                if (words[i].Length > 2)
                {
                    
                    param = comm.CreateParameter();
                    param.ParameterName = "@Word" + index.ToString();
                    param.Value = words[i];
                    param.DbType = DbType.String;
                    comm.Parameters.Add(param);
                    index++;
                }
            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyProducts = Int32.Parse(comm.Parameters["@HowManyResults"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)OnderShopConfiguration.NewsPerPage);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            table.Columns.Add("BelongsTo", typeof(string));
           
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
               
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        
        public static DataTable SearchImageGallery(string searchString, string allWords, string pageNumber, out int howManyPages)
        {
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "SearchImageCatalog";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@AllWords";
            param.Value = allWords.ToUpper() == "TRUE" ? "1" : "0";
            param.DbType = DbType.Byte;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.ImagePerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyResults";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            int howManyWords = 5;
           
            string[] words = Regex.Split(searchString, "[^\u0621-\u064A0-9]+");
            
            int index = 1;
            for (int i = 0; i <= words.GetUpperBound(0) && index <= howManyWords; i++)
                
                if (words[i].Length > 2)
                {
                    
                    param = comm.CreateParameter();
                    param.ParameterName = "@Word" + index.ToString();
                    param.Value = words[i];
                    param.DbType = DbType.String;
                    comm.Parameters.Add(param);
                    index++;
                }
            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyProducts = Int32.Parse(comm.Parameters["@HowManyResults"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)OnderShopConfiguration.ImagePerPage);

            
            table.Columns.Add("NewsImage", typeof(string));
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["Title"] == DBNull.Value)
                    {
                        row["Title"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }


                }
                
                table.Columns.Remove("Image");



            }

           
            return table;
        }

        public static DataTable SearchVideoGallery(string searchString, string allWords, string pageNumber, out int howManyPages)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "SearchVideoCatalog";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            param = comm.CreateParameter();
            param.ParameterName = "@AllWords";
            param.Value = allWords.ToUpper() == "TRUE" ? "1" : "0";
            param.DbType = DbType.Byte;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@HowManyResults";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int howManyWords = 5;

            string[] words = Regex.Split(searchString, "[^\u0621-\u064A0-9]+");

            int index = 1;
            for (int i = 0; i <= words.GetUpperBound(0) && index <= howManyWords; i++)

                if (words[i].Length > 2)
                {

                    param = comm.CreateParameter();
                    param.ParameterName = "@Word" + index.ToString();
                    param.Value = words[i];
                    param.DbType = DbType.String;
                    comm.Parameters.Add(param);
                    index++;
                }

            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            int howManyProducts = Int32.Parse(comm.Parameters["@HowManyResults"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)OnderShopConfiguration.NewsPerPage);


            table = GenericDataAccess.ExecuteSelectCommand(comm);
            table.Columns.Add("BelongsTo", typeof(string));

            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["VideoUrl"] == DBNull.Value)
                    {
                        row["VideoUrl"] = string.Empty;
                    }
                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }
                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];

                }


            }


            return table;
        }

        public static DataTable SearchRelated(string searchString, string allWords, string pageNumber, out int howManyPages)
        {                                                                                                      
           
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "SearchRealtedCatalog";
           
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@DescriptionLength";
            param.Value = OnderShopConfiguration.NewsDescriptionLength;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
           
            param = comm.CreateParameter();
            param.ParameterName = "@AllWords";
            param.Value = allWords.ToUpper() == "TRUE" ? "1" : "0";
            param.DbType = DbType.Byte;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@PageNumber";
            param.Value = pageNumber;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@NewsPerPage";
            param.Value = OnderShopConfiguration.NewsPerPage;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            param = comm.CreateParameter();
            param.ParameterName = "@HowManyResults";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            int howManyWords = 5;
            
            string[] words = Regex.Split(searchString, "[^\u0621-\u064A0-9]+");
            
            int index = 1;
            for (int i = 0; i <= words.GetUpperBound(0) && index <= howManyWords; i++)
                
                if (words[i].Length > 2)
                {
                    
                    param = comm.CreateParameter();
                    param.ParameterName = "@Word" + index.ToString();
                    param.Value = words[i];
                    param.DbType = DbType.String;
                    comm.Parameters.Add(param);
                    index++;
                }
           
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);
            
            int howManyProducts = Int32.Parse(comm.Parameters["@HowManyResults"].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)OnderShopConfiguration.NewsPerPage);

             
            table.Columns.Add("NewsImage", typeof(string));
           
            table.Columns.Add("BelongsTo", typeof(string));
            
            byte[] imgBytes;
            if (table.Rows.Count > 0)
            {

               
                foreach (DataRow row in table.Rows)
                {

                    if (row["Details"] == DBNull.Value)
                    {
                        row["Details"] = string.Empty;
                    }

                    if (row["Image"] == DBNull.Value)
                    {
                        row["NewsImage"] = string.Empty;
                    }
                    else
                    {
                        imgBytes = (byte[])row["Image"];
                        row["NewsImage"] = "data:image/jpg;base64," + Convert.ToBase64String(imgBytes);
                    }



                    if (row["Date"] == DBNull.Value)
                    {
                        row["Date"] = "01/01/1900";
                    }

                    row["BelongsTo"] = row["Sector"] + "/" + row["Program"] + "/" + row["Project"];


                }
               
                table.Columns.Remove("Image");



            }

            
            return table;
        }
       
        public static int GetSectorIdByName(string sectorName)
        {
            DataTable table = new DataTable();

            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogGetSectorIdByName";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = sectorName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            

            
            table = GenericDataAccess.ExecuteSelectCommand(comm);
            int SectorID = 0;
            
            if (table.Rows.Count > 0)
            {

                SectorID = Int32.Parse(table.Rows[0]["SectorID"].ToString());

            }

            
            return SectorID;
        }

        
        public static bool CheckInSectors(string sectorId)
        {
            bool Result = false;
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetAllSectors";
            

            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);

            
            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["SectorID"].ToString() == sectorId)
                    {
                        Result = true;
                    }
                    
                }
                
              

            }
            
            return Result;
        }

        

        public static bool CheckInPrograms(string programId)
        {
            bool Result = false;
            
            DbCommand comm = GenericDataAccess.CreateCommand();
            
            comm.CommandText = "CatalogGetAllPrograms";


            
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {

                
                foreach (DataRow row in table.Rows)
                {

                    if (row["ProgramID"].ToString() == programId)
                    {
                        Result = true;
                    }

                }
                


            }
            
            return Result;
        }

        public static bool CheckInProjects(string projectId)
        {
            bool Result = false;

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogGetAllProjects";



            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {


                foreach (DataRow row in table.Rows)
                {

                    if (row["ProjectID"].ToString() == projectId)
                    {
                        Result = true;
                    }

                }



            }

            return Result;
        }

        public static bool CheckInVideo(string videoId)
        {
            bool Result = false;

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogCheckVideoByID";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@VideoID";
            param.Value = videoId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }
        public static bool CheckInUser(string userId)
        {
            bool Result = false;

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogCheckInUser";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@UserID";
            param.Value = userId;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }

        public static bool CheckInRole(string roleId)
        {
            bool Result = false;

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogCheckInRole";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@RoleID";
            param.Value = roleId;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }
        public static bool CheckInNews(string newsId)
        {
            bool Result = false;
            
            DbCommand comm = GenericDataAccess.CreateCommand();
           
            comm.CommandText = "CatalogCheckNewsByID";
            
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@NewsID";
            param.Value = newsId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

           
            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {             
               Result = true;
            }
            else
            {
                Result = false;
            }
            
            return Result;
        }

        public static bool CheckInImage(string imageId)
        {
            bool Result = false;

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "CatalogCheckInImage";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@ImageID";
            param.Value = imageId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            DataTable table = GenericDataAccess.ExecuteSelectCommand(comm);


            if (table.Rows.Count > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }

        public static bool UpdateNews(string newsID, string projectID, string title, string details, DateTime date, string imageID, byte[] image,bool primaryImage)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateNews";
            // 
            DbParameter param = comm.CreateParameter();
            
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@details";
            param.Value = details;
            param.Size = details.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@imageID";
            param.Value = imageID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            //param = comm.CreateParameter();
            //param.ParameterName = "@image";
            //param.Value = image;
            //System.Data.SqlDbType.VarBinary
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName= "@image";
            FileDataUploadParameter.Value = image;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = image.Length;
            //param.DbType = System.Data.SqlDbType.VarBinary;
            //DbType = SqlDbType.VarBinary;
            //param.Size = image.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@primaryImage";
            param.Value = primaryImage;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);
            //
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool UpdateImage(string imageID, string projectID, string title, DateTime date, byte[] image)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateImage";
            // 
            DbParameter param = comm.CreateParameter();

            param.ParameterName = "@ImageID";
            param.Value = imageID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);
            //
           
            //
            //param = comm.CreateParameter();
            //param.ParameterName = "@image";
            //param.Value = image;
            //System.Data.SqlDbType.VarBinary
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@image";
            FileDataUploadParameter.Value = image;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = image.Length;
            //param.DbType = System.Data.SqlDbType.VarBinary;
            //DbType = SqlDbType.VarBinary;
            //param.Size = image.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
           
            //
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool UpdateVideo(string videoID, string projectID, string title, string details, string videoUrl, DateTime date)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateVideo";
            // 
            DbParameter param = comm.CreateParameter();


            param.ParameterName = "@VideoID";
            param.Value = videoID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //

            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@details";
            param.Value = details;
            param.Size = details.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoUrl";
            param.Value = videoUrl;
            param.DbType = DbType.String;
            param.Size = videoUrl.Length;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);

            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
           
            
        }
        public static bool CreateNews(out int newsID, string projectID, string title, string details, DateTime date)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateNews";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@details";
            param.Value = details;
            param.Size = details.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);
            //

            //
            

            //
            // result will represent the number of changed rows
            int result = -1;
            newsID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                newsID = Int32.Parse(comm.Parameters["@newsID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
           
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool CreateProject(out int projectID, string programID, string title, string description, byte[] logo, int benefitNo,string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateProject";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@BenefitNo";
            param.Value = benefitNo;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);

            //
            // result will represent the number of changed rows
            int result = -1;
            projectID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                projectID = Int32.Parse(comm.Parameters["@ProjectID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }

            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool CreateProgram(out int programID, string sectorID, string title, string description, byte[] logo, string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateProgram";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);

            //
            // result will represent the number of changed rows
            int result = -1;
            programID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                programID = Int32.Parse(comm.Parameters["@ProgramID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }

            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool CreateSector(out int sectorID, string title, string description, byte[] skeleton, byte[] logo, string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateSector";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //

            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
            SqlParameter FileDataUploadParameter1 = new SqlParameter();
            FileDataUploadParameter1.ParameterName = "@Skeleton";
            FileDataUploadParameter1.Value = skeleton;
            FileDataUploadParameter1.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter1.Size = skeleton.Length;
            comm.Parameters.Add(FileDataUploadParameter1);
            //
            // result will represent the number of changed rows
            int result = -1;
            sectorID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                sectorID = Int32.Parse(comm.Parameters["@SectorID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }

            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool UpdateProject(string projectID ,string programID, string title, string description, byte[] logo, int benefitNo, string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateProject";
            // 
            DbParameter param = comm.CreateParameter();

            param.ParameterName = "@ProjectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@BenefitNo";
            param.Value = benefitNo;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //

            //
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool UpdateProgram(string programID, string sectorID, string title, string description, byte[] logo, string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateProgram";
            // 
            DbParameter param = comm.CreateParameter();

            param.ParameterName = "@ProgramID";
            param.Value = programID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //

            //
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool UpdateSector(string sectorID, string title, string description, byte[] skeleton, byte[] logo, string notes)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateSector";
            // 
            DbParameter param = comm.CreateParameter();

            param.ParameterName = "@SectorID";
            param.Value = sectorID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@Description";
            param.Value = description;
            param.Size = description.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //

            //
            param = comm.CreateParameter();
            param.ParameterName = "@Notes";
            param.Value = notes;
            param.Size = notes.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@Logo";
            FileDataUploadParameter.Value = logo;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = logo.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
            SqlParameter FileDataUploadParameter1 = new SqlParameter();
            FileDataUploadParameter1.ParameterName = "@Skeleton";
            FileDataUploadParameter1.Value =skeleton;
            FileDataUploadParameter1.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter1.Size = skeleton.Length;
            comm.Parameters.Add(FileDataUploadParameter1);
            //
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool CreateVideo(out int videoID, string projectID, string title, string details, string videoUrl, DateTime date)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateVideo";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@VideoID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            param = comm.CreateParameter();
            param.ParameterName = "@details";
            param.Value = details;
            param.Size = details.Length;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoUrl";
            param.Value = videoUrl;
            param.DbType = DbType.String;
            param.Size = videoUrl.Length;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);
            //

            //


            //
            // result will represent the number of changed rows
            int result = -1;
            videoID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                videoID = Int32.Parse(comm.Parameters["@VideoID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }

            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool CreateImage(out int imageID, string projectID, string title, DateTime date, byte[] image)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogCreateImage";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ImageID";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@projectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            // 
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@date";
            param.Value = date;
            param.DbType = DbType.Date;
            comm.Parameters.Add(param);
            //
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@image";
            FileDataUploadParameter.Value = image;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = image.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //


            //
            // result will represent the number of changed rows
            int result = -1;
            imageID = -3;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
                imageID = Int32.Parse(comm.Parameters["@ImageID"].Value.ToString());

            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }

            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool InsertImageByIDForAdmin(string newsID, byte[] image,bool PrimaryImage,bool Related)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogInsertImageByIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //

            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@image";
            FileDataUploadParameter.Value = image;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = image.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@primaryImage";
            param.Value = PrimaryImage;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);
            //
            ///
            param = comm.CreateParameter();
            param.ParameterName = "@Related";
            param.Value = Related;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);
            ///

            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool UpdateRelatedImageByIDForAdmin(string imageID, byte[] image)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateRelatedImageByIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@imageID";
            param.Value = imageID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            
            SqlParameter FileDataUploadParameter = new SqlParameter();
            FileDataUploadParameter.ParameterName = "@image";
            FileDataUploadParameter.Value = image;
            FileDataUploadParameter.SqlDbType = System.Data.SqlDbType.VarBinary;
            FileDataUploadParameter.Size = image.Length;
            //param.DbType = System.Data.SqlDbType.VarBinary;
            //DbType = SqlDbType.VarBinary;
            //param.Size = image.Length;
            comm.Parameters.Add(FileDataUploadParameter);
            //
            
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool UpdateKeywordByNewsIDForAdmin(string newsID, string word)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateKeywordByNewsIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@word";
            param.Value = word;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            //

            
            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            
            
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool UpdateVideoByNewsIDForAdmin(string newsID, string videoID,string videoUrl,string title)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogUpdateVideoByNewsIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoID";
            param.Value = videoID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoUrl";
            param.Value = videoUrl;
            param.DbType = DbType.String;
            param.Size = videoUrl.Length;
            comm.Parameters.Add(param);

            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool InsertVideoByNewsIDForAdmin(string newsID, string videoUrl, string title)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogInsertVideoByNewsIDForAdmin";
            //                  
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            
            //
            param = comm.CreateParameter();
            param.ParameterName = "@title";
            param.Value = title;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoUrl";
            param.Value = videoUrl;
            param.DbType = DbType.String;
            param.Size = videoUrl.Length;
            comm.Parameters.Add(param);

            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
        public static bool DeleteKeywordByNewsIDForAdmin(string newsID, string keywordId)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteKeywordByNewsIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@keywordID";
            param.Value = keywordId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //


            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteVideoByNewsIDForAdmin(string newsID, string videoId)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteVideoByNewsIDForAdmin";
            // 
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            param = comm.CreateParameter();
            param.ParameterName = "@videoID";
            param.Value = videoId;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //


            // result will represent the number of changed rows
            int result = -1;
            try
            {
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteNewsAndAllRelatedByNewsIDForAdmin(string newsID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteRelatedByNewsIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@newsID";
            param.Value = newsID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //
            
            //


            // result will represent the number of changed rows
            int result = -1;
            try
            {
                
                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteImageByIDForAdmin(string imageID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteImageByIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ImageID";
            param.Value = imageID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //

            //


            // result will represent the number of changed rows
            int result = -1;
            try
            {

                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteVideoByIDForAdmin(string videoID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteVideoByIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@VideoID";
            param.Value = videoID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            //

            //


            // result will represent the number of changed rows
            int result = -1;
            try
            {

                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteProjectByIDForAdmin(string projectID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteRelatedByProjectIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ProjectID";
            param.Value = projectID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);
            
            // result will represent the number of changed rows
            int result = -1;
            try
            {

                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteProgramByIDForAdmin(string programID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteRelatedByProgramIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@ProgramID";
            param.Value = programID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            // result will represent the number of changed rows
            int result = -1;
            try
            {

                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }

        public static bool DeleteSectorByIDForAdmin(string sectorID)
        {
            // 
            DbCommand comm = GenericDataAccess.CreateCommand();
            // 
            comm.CommandText = "CatalogDeleteRelatedBySectorIDForAdmin";
            //                   
            DbParameter param = comm.CreateParameter();

            param = comm.CreateParameter();
            param.ParameterName = "@SectorID";
            param.Value = sectorID;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            // result will represent the number of changed rows
            int result = -1;
            try
            {

                // execute the stored procedure
                result = GenericDataAccess.ExecuteNonQuery(comm);
            }
            catch
            {
                // any errors are logged in GenericDataAccess, we ignore them here
            }
            // result will be 1 in case of success
            return (result != -1);
        }
    }
}