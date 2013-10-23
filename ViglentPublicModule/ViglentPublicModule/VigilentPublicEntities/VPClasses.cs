using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace ViglentPublicModule
{
    public class VPMsg
    {
        public int MessageID { get; set; }
        public GeoCoordinate MsgLocation { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        
    }

    public class VPUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

    }

    public class VigilentPublicIncident
    {
        public int VPIncidentID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string IncidentType { get; set; }
        public GeoCoordinate IncidentLocation { get; set; }
        public DateTime MessageReceivedVP { get; set; }
        public DateTime MessageSentPSAP { get; set; }

    
    }
 
}