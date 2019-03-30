using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class Registration
    {
    }


    public class RegistrationResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public string registrationDate { get; set; }
        public RequstinfoRes[] requMasterList { get; set; }


    }
    public class RegistrationRequest
    {
        public DeviceInfo Deviceinfo { get; set; }      
        public RequestInfo RequestInfo { get; set; }
        public UserInfo userInfo { get; set; }
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

    public class RequestInfo
    {

        public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public string pspRespRefNo { get; set; }
        public String profileId { get; set; }

    }

    public class UserInfo
    {
        public string altMobNo { get; set; }
        public string accountId { get; set; }
        public string email { get; set; }
        public string mobileNo { get; set; }
        public secretDetails secretDetails { get; set; }
        public string name { get; set; }
        public string virtualAddress { get; set; }
    }
    public class secretDetails
    {
        public string secretAnswer { get; set; }
        public string quesId { get; set; }
    }

    public class RequstinfoRes
    {
        public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public string pspRespRefNo { get; set; }       
    }



}