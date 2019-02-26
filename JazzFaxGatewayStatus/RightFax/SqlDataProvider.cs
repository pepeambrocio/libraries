using System;
using System.Data;
using System.Data.SqlClient;

namespace JazzFaxGatewayStatus.RightFax
{
 
    /// <summary>
    /// // Phase 3 - 23 Apr 2015 - JAD - RightFax Conversion
    /// </summary>
    public sealed class SqlDataProvider : DataProvider
    {
        private static string _connectionstring;

        private SqlConnection conn = new SqlConnection(_connectionstring);

        private static volatile SqlDataProvider _objProvider;
        private static readonly object Padlock = new Object();

        private SqlDataProvider()
        {
            _connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString;
        }

        public static new SqlDataProvider Instance
        {
            get
            {
                if (_objProvider == null)
                {
                    lock (Padlock)
                    {
                        if (_objProvider == null)
                        {
                            _objProvider = new SqlDataProvider();
                        }
                    }
                }
                return _objProvider;
            }
        }


        public override void UpdateFaxStatus_Gateway(int faxGatewayRecordId, int rfHandleId, int rfStatusId, int rfErrorStatusId)
        {
            try
            {
                string StoredProc = "ubc_UpdateFaxStatus_Gateway";

                conn.ConnectionString = _connectionstring;

                if ((conn.State == ConnectionState.Closed))
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand(StoredProc, conn);
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.Add("@FaxGatewayRecordId", SqlDbType.Int);
                command.Parameters["@FaxGatewayRecordId"].Value = faxGatewayRecordId;
                command.Parameters.Add("@RightFaxHandleID", SqlDbType.Int);
                command.Parameters["@RightFaxHandleID"].Value = rfHandleId;
                command.Parameters.Add("@RightFaxStatusID", SqlDbType.Int);
                command.Parameters["@RightFaxStatusID"].Value = rfStatusId;
                command.Parameters.Add("@RightFaxErrorID", SqlDbType.Int);
                command.Parameters["@RightFaxErrorID"].Value = rfErrorStatusId;
            
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                // nothing
            }
            finally
            {
                conn.Close();
            }
        }

        // implement faxgateway
        public override DataTable Fax_NeedStatus()
        {
            DataTable retDataTable = new DataTable();

            try
            {
                string StoredProc = "ubc_Fax_NeedStatus";

                conn.ConnectionString = _connectionstring;

                if ((conn.State == ConnectionState.Closed))
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand(StoredProc, conn);
                command.CommandType = CommandType.StoredProcedure;
                
                using (IDataReader aReader = command.ExecuteReader())
                {
                    retDataTable.Load(aReader);
                }
                
            }
            catch (Exception e)
            {
                // nothing
            }
            finally
            {
                conn.Close();
            }

            return retDataTable;
        }


    }   
}
