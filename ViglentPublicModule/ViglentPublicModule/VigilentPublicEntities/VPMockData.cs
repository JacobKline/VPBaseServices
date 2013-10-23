using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace ViglentPublicModule
{
    public class VPMockData
    {
        private List<VPMsg> msgList;

        public List<VPMsg> GetMessages()
        {
            if (msgList == null)
                QueueData();

            return msgList;
        }

        private void QueueData()
        {
            msgList =
                new List<VPMsg>{
                    new VPMsg{MessageID=1,MsgLocation=GeoCoordinate.Unknown,Message="Shop Smart.  Shop S-Mart You got that?!",PhoneNumber="2069095342"},
                    new VPMsg{MessageID=2,MsgLocation=GeoCoordinate.Unknown,Message="That's no moon!",PhoneNumber="3056665555"},
                    new VPMsg{MessageID=3,MsgLocation=GeoCoordinate.Unknown,Message="I've fallen and I can't get up!",PhoneNumber="1235559876"},
                    new VPMsg{MessageID=4,MsgLocation=GeoCoordinate.Unknown,Message="Where's the beef?",PhoneNumber="0986665543"},
                    new VPMsg{MessageID=5,MsgLocation=GeoCoordinate.Unknown,Message="Que Sera, sera!",PhoneNumber="2123335684"},
                    new VPMsg{MessageID=6,MsgLocation=GeoCoordinate.Unknown,Message="Once upon a midnight dreary",PhoneNumber="7632324498"},
                    new VPMsg{MessageID=7,MsgLocation=GeoCoordinate.Unknown,Message="You are standing in an open field west of a white house",PhoneNumber="1006643433"},
                    new VPMsg{MessageID=8,MsgLocation=GeoCoordinate.Unknown,Message="When she gets there she knows",PhoneNumber="9996643258"},
                    new VPMsg{MessageID=9,MsgLocation=GeoCoordinate.Unknown,Message="Have I told you about my condition?",PhoneNumber="4444444444"},
                    new VPMsg{MessageID=10,MsgLocation=GeoCoordinate.Unknown,Message="Shop Smart.  Shop S-Mart You got that?!",PhoneNumber="5376409999"}
                };
        
        }
    }
}