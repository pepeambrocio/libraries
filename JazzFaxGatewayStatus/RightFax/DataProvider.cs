using System.Configuration.Provider;
using System.Data;

namespace JazzFaxGatewayStatus.RightFax
{

    /// <summary>
    /// // Phase 3 - 23 Apr 2015 - JAD - RightFax Conversion
    /// </summary>
    public abstract class DataProvider : ProviderBase
    {
        public static SqlDataProvider Instance()
        {
            return SqlDataProvider.Instance;
        }

        // implement faxgateway
        public abstract DataTable Fax_NeedStatus();

        // implement faxgateway
        public abstract void UpdateFaxStatus_Gateway(int faxGatewayRecordId, int rfHandleId, int rfStatusId, int rfErrorStatusId);

    }
}
