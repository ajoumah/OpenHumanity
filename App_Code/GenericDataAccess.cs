using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;


namespace Onder1
{
    public static class GenericDataAccess
    {
        // static constructor 
        static GenericDataAccess()
        {
            
        }

       
        public static DataTable ExecuteSelectCommand(DbCommand command)
        {
           
            DataTable table;
            
            try
            {
               
                command.Connection.Open();
               
                DbDataReader reader = command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);

                
                reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.LogError(ex);
                throw;
            }
            finally
            {
               
                command.Connection.Close();
            }
            return table;
        }

        
        public static DbCommand CreateCommand()
        {
           
            string dataProviderName = OnderShopConfiguration.DbProviderName;
            
            string connectionString = OnderShopConfiguration.DbConnectionString;
           
            DbProviderFactory factory = DbProviderFactories.
            GetFactory(dataProviderName);
           
            DbConnection conn = factory.CreateConnection();
            
            conn.ConnectionString = connectionString;
            
            DbCommand comm = conn.CreateCommand();
           
            comm.CommandType = CommandType.StoredProcedure;
            
            return comm;
        }
        // execute an update, delete, or insert command
        // and return the number of affected rows
        public static int ExecuteNonQuery(DbCommand command)
        {
           
            int affectedRows = -1;
            
            try
            {
                
                command.Connection.Open();
                
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
                Utilities.LogError(ex);
                throw;
            }
            finally
            {
                
                command.Connection.Close();
            }
           
            return affectedRows;
        }
        
        public static string ExecuteScalar(DbCommand command)
        {
           
            string value = "";
            
            try
            {
                
                command.Connection.Open();
                
                value = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                
                Utilities.LogError(ex);
                throw;
            }
            finally
            {
                
                command.Connection.Close();
            }
            
            return value;
        }
    }

}