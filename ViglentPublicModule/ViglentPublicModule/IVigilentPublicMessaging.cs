using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Device.Location;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ViglentPublicModule
{
    
    [ServiceContract]
    public interface IVigilentPublicMessaging
    {
        [OperationContract]
        [WebGet(UriTemplate = "VPUser/{UserID}")]
        VigilentPublicContracts.VigilentPublicUsers GetUser(string UserID);

        [OperationContract]
        [WebGet(UriTemplate = "TextMessages/{MessageID}")]
        VPMsg GetATextMessage(string MessageID);

        [OperationContract]
        [WebGet(UriTemplate = "Incidents/{IncidentID}")]
        VigilentPublicIncident GetVigilentPublicIncident(string IncidentID);

        [OperationContract]
        [WebInvoke(Method = "put", UriTemplate = "TextMessages/{MessageID}")]
        void SendMessageToVP(string MessageID, VPMsg msg);
        
    }

    //I took this right from the data details document. Assumes table or view or table_valued function is named dbo.VP_Users, dbo.VP_message, etc etc



}
