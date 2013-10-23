using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Device.Location;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ViglentPublicModule
{
    public class VigilentPublicContracts
    {
        //these are our entities.
        //I took this right from the data details document. Assumes table or view or table_valued function is named dbo.VP_Users, dbo.VP_message, etc etc
        [Table(Name = "VP_Users")]
        [DataContract]
        public class VigilentPublicUsers
        {
            [Column]
            [DataMember]
            public int UserID { get; set; }

            [Column]
            [DataMember]
            public string First_Name { get; set; }

            [Column]
            [DataMember]
            public string Last_Name { get; set; }

            [Column]
            [DataMember]
            public string Phone_Number { get; set; }

            [Column]
            [DataMember]
            public string Address_1 { get; set; }

            [Column]
            [DataMember]
            public string Address_2 { get; set; }

            [Column]
            [DataMember]
            public string City { get; set; }

            [Column]
            [DataMember]
            public string State { get; set; }

            [Column]
            [DataMember]
            public string Zip { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Registered { get; set; }

            [Column]
            [DataMember]
            public bool Terms_Agreement_ACK { get; set; }

        }

        [Table(Name = "VP_Message")]
        [DataContract]
        public class VigilentPublicMessage
        {

            [Column]
            [DataMember]
            public string First_Name { get; set; }

            [Column]
            [DataMember]
            public string Last_Name { get; set; }

            [Column]
            [DataMember]
            public string Phone_Number { get; set; }

            [Column]
            [DataMember]
            public string Type_of_incident { get; set; }

            [Column]
            [DataMember]
            public GeoCoordinate GPS_Info { get; set; }

            [Column]
            [DataMember]
            public Object Video_Pic { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Sent { get; set; }


        }

        [Table(Name = "VP_Incident")]
        [DataContract]
        public class VigilentPublicIncident
        {
            [Column]
            [DataMember]
            public string First_Name { get; set; }

            [Column]
            [DataMember]
            public string Last_Name { get; set; }

            [Column]
            [DataMember]
            public string Phone_Number { get; set; }

            [Column]
            [DataMember]
            public string Address_1 { get; set; }

            [Column]
            [DataMember]
            public string Address_2 { get; set; }

            [Column]
            [DataMember]
            public string City { get; set; }

            [Column]
            [DataMember]
            public string State { get; set; }

            [Column]
            [DataMember]
            public string Zip { get; set; }

            [Column]
            [DataMember]
            public string Type_of_incident { get; set; }

            [Column]
            [DataMember]
            public GeoCoordinate GPS_Info { get; set; }

            [Column]
            [DataMember]
            public string Video_Pic { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Sent { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Recieved { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Submitted { get; set; }

            [Column]
            [DataMember]
            public DateTime TimeDate_Replied { get; set; }


        }
    }
}