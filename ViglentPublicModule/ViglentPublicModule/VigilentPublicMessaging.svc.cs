using System;
using System.Device;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;



namespace ViglentPublicModule
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class VigilentPublicMessaging : IVigilentPublicMessaging
    {
        //method to retrieve a user from our database by userid
        public VigilentPublicContracts.VigilentPublicUsers GetUser(string UserID)
        {
            int userID = Int32.Parse(UserID);
            DataContext vigilentPublicData = new DataContext(DataConnectionString);
            VigilentPublicContracts.VigilentPublicUsers vpUser = (from users in vigilentPublicData.GetTable<VigilentPublicContracts.VigilentPublicUsers>() where users.UserID == userID select users).First();            
            return vpUser;
        }

       

        public VPMsg GetATextMessage(string msgID)
        {
            int MessageID = Int32.Parse(msgID);
            VPMsg myReturnMsg = new VPMsg();
            VPMockData getdata = new VPMockData();            
            List<VPMsg> DemoMessages = getdata.GetMessages();
            var returnMessage = (from m in DemoMessages where m.MessageID == MessageID select m).SingleOrDefault();
            myReturnMsg.Message = returnMessage.Message;
            myReturnMsg.MessageID = returnMessage.MessageID;
            myReturnMsg.MsgLocation = returnMessage.MsgLocation;
            myReturnMsg.PhoneNumber = returnMessage.PhoneNumber;

            return myReturnMsg;
        
        }

        public VigilentPublicIncident GetVigilentPublicIncident(string IncidentID)
        {
            DataContext incidentData = new DataContext(DataConnectionString);
            VigilentPublicIncident incident = new VigilentPublicIncident();

            return incident;
        
        }

        private String DataConnectionString
        {
            get
            {
                SqlConnectionStringBuilder dbConnection = new SqlConnectionStringBuilder();
                dbConnection.DataSource = "winhost.vigilentpublicdata";
                dbConnection.InitialCatalog = "VPPrototypeDB";
                dbConnection.UserID = "VPAdmin";
                dbConnection.Password = "pass@word1";
                return dbConnection.ConnectionString;
            }
            
        
        
        }

        public void SendMessageToVP(string MessgeID, VPMsg msg)
        {
            DataContext writeMsgHere = new DataContext(DataConnectionString);

            writeMsgHere.Msgs.Add(msg);

            writeMsgHere.SubmitChanges();
        
        
        
        }

        //public Boolean SendVigilentPublicIncidentToPSAP(DateTime LastPolled)
        //{
        //    int i = 0;
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //    builder.DataSource = "VigilantPublicDataServer";
        //    builder.InitialCatalog = "VPDatabase";
        //    builder.IntegratedSecurity = true;
        //    DataContext vigilentPublicIncidents = new DataContext(builder.ConnectionString);
        //    Table<VigilentPublicContracts.VigilentPublicIncident> AllMessages = vigilentPublicIncidents.GetTable<VigilentPublicContracts.VigilentPublicIncident>();
        //    var toSend = from m in AllMessages where m.TimeDate_Sent < LastPolled select m;
        //    foreach (VigilentPublicContracts.VigilentPublicIncident inc in toSend)
        //    {
        //        //serialize as CAD message
        //        //some msg logic on success
        //        if (true)
        //        {
        //            ++i;
        //        }
        //        //send to CAD system


        //    }

        //    //some logic for success or faliure
        //    if (i == toSend.Count())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}

        //method to send a message to our database
        //public Boolean SendMsgToUs(VigilentPublicContracts.VigilentPublicMessage msg)
        //{
        //    bool msgResponse = false;

        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //    builder.DataSource = "VigilantPublicDataServer";
        //    builder.InitialCatalog = "VPDatabase";
        //    builder.IntegratedSecurity = true;
        //    DataContext vigilentPublicData = new DataContext(builder.ConnectionString);
        //    vigilentPublicData.GetTable<VigilentPublicContracts.VigilentPublicMessage>().Attach(msg);

        //    try
        //    {
        //        vigilentPublicData.SubmitChanges(ConflictMode.FailOnFirstConflict);
        //        msgResponse = true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        msgResponse = false;


        //    }

        //    return msgResponse;
        //}


    }
}
