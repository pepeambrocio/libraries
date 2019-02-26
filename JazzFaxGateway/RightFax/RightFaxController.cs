
using System.Data;

namespace JazzFaxGateway.RightFax
{
    /// <summary>
    /// // Phase 3 - 23 Apr 2015 - JAD - RightFax Conversion
    /// </summary>
    public class RightFaxController
    {
        public void UpdateFaxStatus_Gateway(int faxGatewayRecordId, int rfHandleId, int rfStatusId, int rfErrorStatusId)
        {
            DataProvider.Instance().UpdateFaxStatus_Gateway(faxGatewayRecordId, rfHandleId, rfStatusId, rfErrorStatusId);
        }

        // implement faxgateway
        public DataTable Fax_NeedStatus()
        {
            DataTable retDataTable = new DataTable();

            retDataTable = DataProvider.Instance().Fax_NeedStatus();
           
            return retDataTable;
        }
  
    }
}