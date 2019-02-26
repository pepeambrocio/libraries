using InterFAX.Api;
using JazzFaxGateway.RightFax;
using RFCOMAPILib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzFaxGateway
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientKey = ConfigurationManager.AppSettings["FaxServiceClientId"];
            Console.WriteLine("Starting program with clientkey = " + clientKey.ToString());

            RightFaxController RFC = new RightFaxController();

            // get faxes that need statuses updated
            DataTable dt = new DataTable();
            dt = RFC.Fax_NeedStatus();

            int recCount = dt.Rows.Count;

            Console.WriteLine("Found records = " + recCount.ToString());

            if (recCount == 0)
                return;

            int[] y = new int[recCount];
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                y[i] = Convert.ToInt32(row.ItemArray[1]);
                i = i + 1;
            }

            // | Initialize using parameters
            var interfax = new FaxClient(apiRoot: FaxClient.ApiRoot.InterFAX_PCI);            

            int valor = GetFaxStatusP(clientKey, y); // Method to call Rigth Fax, Ivan Caballero
        }

        private static int GetFaxStatusP(string clientKey, int[] x)
        {
            RightFaxController RFC = new RightFaxController();

            try
            {
                FaxServer faxserver = new FaxServer();
                faxserver.ServerName = "rightfax.express-scripts.com";
                faxserver.AuthorizationUserID = "CMM_User";
                faxserver.Protocol = CommunicationProtocolType.cpTCPIP;
                faxserver.UseNTAuthentication = BoolType.False;

                faxserver.OpenServer();

                var faxes = (Faxes)faxserver.get_Faxes("CMM_User");
                var linq = faxes.Cast<Fax>();
                // Filter linq with array x
                var linqHandle = linq.Where(n => x.Contains(n.Handle));

                int RFStatusId = 0;
                int RFErrorStatusId = 0;


                foreach (var w in linqHandle)
                {
                    string StatusId = w.FaxStatus.ToString();
                    string ErrorId = w.FaxErrorCode.ToString();
                    int datoHandId = w.Handle;

                    // convert status words to int
                    switch (StatusId)
                    {
                        case "fsUnborn":
                            RFStatusId = 0;
                            break;
                        case "fsNeedsFCS":
                            RFStatusId = 1;
                            break;
                        case "fsNeedsConversion":
                            RFStatusId = 2;
                            break;
                        case "fsNeedsToBeSent":
                            RFStatusId = 3;
                            break;
                        case "fsInConversion":
                            RFStatusId = 4;
                            break;
                        case "fsInSend":
                            RFStatusId = 5;
                            break;
                        case "Successful":
                            RFStatusId = 6;
                            break;
                        case "fsManualFCS":
                            RFStatusId = 7;
                            break;
                        case "fsInSchedule":
                            RFStatusId = 8;
                            break;
                        case "Failed":
                            RFStatusId = 9;
                            break;
                        case "fsDuplicate":
                            RFStatusId = 10;
                            break;
                        case "Error":
                            RFStatusId = 11;
                            break;
                        case "fsNeedsAttention":
                            RFStatusId = 12;
                            break;
                        case "fsNeedsAttachment":
                            RFStatusId = 13;
                            break;
                        case "fsHeldForPreview":
                            RFStatusId = 14;
                            break;
                        case "fsInOCR":
                            RFStatusId = 15;
                            break;
                        case "fsInPrint":
                            RFStatusId = 16;
                            break;
                        case "fsQueuedForPrinting":
                            RFStatusId = 17;
                            break;
                        case "fsQueuedForOCR":
                            RFStatusId = 18;
                            break;
                        case "fsInValidation":
                            RFStatusId = 19;
                            break;
                        case "fsInApproval":
                            RFStatusId = 20;
                            break;
                        default:
                            RFStatusId = 0;
                            break;
                    }

                    // convert ErrorStatus words to int
                    switch (ErrorId)
                    {
                        case "fecNone":
                            RFErrorStatusId = 0;
                            break;
                        case "fecBusy":
                            RFErrorStatusId = 1;
                            break;
                        case "fecTransmissionError":
                            RFErrorStatusId = 2;
                            break;
                        case "fecPoorQuality":
                            RFErrorStatusId = 3;
                            break;
                        case "fecNoAnswer":
                            RFErrorStatusId = 4;
                            break;
                        case "fecBadFCS":
                            RFErrorStatusId = 5;
                            break;
                        case "fecBadConvert":
                            RFErrorStatusId = 6;
                            break;
                        case "fecMakeFCS":
                            RFErrorStatusId = 7;
                            break;
                        case "fecCantSchedule":
                            RFErrorStatusId = 8;
                            break;
                        case "fecUnknown":
                            RFErrorStatusId = 9;
                            break;
                        case "fecHuman":
                            RFErrorStatusId = 10;
                            break;
                        case "fecGroup2":
                            RFErrorStatusId = 11;
                            break;
                        case "fecLocalInUse":
                            RFErrorStatusId = 12;
                            break;
                        case "fecLineProblem":
                            RFErrorStatusId = 13;
                            break;
                        case "fecBadPaper":
                            RFErrorStatusId = 14;
                            break;
                        case "fecBadSignature":
                            RFErrorStatusId = 15;
                            break;
                        case "fecNoSignatureAuthorization":
                            RFErrorStatusId = 16;
                            break;
                        case "fecDiscarded":
                            RFErrorStatusId = 18;
                            break;
                        case "fecBadPhone":
                            RFErrorStatusId = 19;
                            break;
                        case "fecInvalidCode":
                            RFErrorStatusId = 21;
                            break;
                        case "fecBadCode":
                            RFErrorStatusId = 22;
                            break;
                        case "fecBadOCR":
                            RFErrorStatusId = 23;
                            break;
                        case "fecBadPrint":
                            RFErrorStatusId = 24;
                            break;
                        case "fecNoLibraryDocumentAuthorization":
                            RFErrorStatusId = 25;
                            break;
                        case "fecViewStar1":
                            RFErrorStatusId = 26;
                            break;
                        case "fecDisapproved":
                            RFErrorStatusId = 27;
                            break;
                        case "fecEmailDeliveryError":
                            RFErrorStatusId = 28;
                            break;
                        default:
                            RFErrorStatusId = 0;
                            break;
                    }


                    Console.WriteLine("Updating record - right fax handle id = " + datoHandId.ToString() + " with status of " + RFStatusId.ToString() + " gateway id = " + datoHandId);
                    // update faxes that need statuses updated
                    RFC.UpdateFaxStatus_Gateway(datoHandId, datoHandId, RFStatusId, RFErrorStatusId);

                }


                return 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(@"An error occurred sendng a fax to the fax server. Message: '{0}'.", ex);
            }
        }
    }
}
