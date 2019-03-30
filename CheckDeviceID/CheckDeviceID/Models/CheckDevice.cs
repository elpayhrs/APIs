using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDeviceID.Models
{
    public class CheckDevice
    {

    }



    public class DeviceInfo
    {

        public String androidid { get; set; }
        public String appName { get; set; }
        public String appVersionCode { get; set; }
        public String AppVersionName { get; set; }
        public String bluetoothMac { get; set; }
        public String capability { get; set; }
        public String deviceId { get; set; }
        public String deviceType { get; set; }
        public String geoCode { get; set; }
        public String ip { get; set; }
        public String location { get; set; }
        public String mobileNo { get; set; }
        public String os { get; set; }
        public String regId { get; set; }
        public String selectedSimSlot { get; set; }
        public String simId { get; set; }
        public String WifiMac { get; set; }

    }

    public class AddInfo
    {

        public String addInfo { get; set; }
        public String addInfo9 { get; set; }

    }

    public class RequestInfo
    {

        public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public String profileId { get; set; }

    }

    //Request
    public class checkdeviceidRequest
    {
        public DeviceInfo DeviceInfo { get; set; }
        public AddInfo AddInfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
    }

    //Response
    public class checkdeviceidResponse
    {

        public string status { get; set; }
        public string statusDesc { get; set; }
        public DeviceInfores[] deviceMasterList { get; set; }

    }


    public class AddInfores
    {
        public String addInfo10 { get; set; }
        public String addInfo9 { get; set; }
    }

    //main returb class 
    public class DeviceInfores
    {
        public String deviceId { get; set; }
        public String oldMobileNo { get; set; }
        public String selectedSimSlot { get; set; }
        public String simId { get; set; }
    }

    public class RequestInfores
    {
        public String pspId { get; set; }
        public String pspRefNo { get; set; }
    }

    public class UserInfores
    {
        public string userMsg { get; set; }
        public secretDetails SecretDetails { get; set; }

    }
    public class secretDetails
    {
        public string quesId { get; set; }
        public string quesName { get; set; }
    }


}