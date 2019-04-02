using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfirmSetMPIN.Models
{
    public class Bank
    {

    }
    public class ConfirmSetMPINResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public string apiResp { get; set; }

        public RequestInfo[] RequestInfoList { get; set; }

        public string npciTransId { get; set; }
    }

    public class ConfirmSetMPINRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public OtpCred Otpcred { get; set; }
        public AddInfo Addinfo { get; set; }
        public AddInfo AccountId { get; set; }


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

    public class OtpCred
    {

        public string atmCrdLength { get; set; }
        public string credentialDataCode { get; set; }
        public string credentialDataKi { get; set; }
        public string credentialDataLength { get; set; }
        public string credentialDataValue { get; set; }
        public string credentialSubType { get; set; }
        public string credentialType { get; set; }
      
    }

    public class AddInfo
    {

        public string addInfo9 { get; set; }
        public string addInfo10 { get; set; }

    }


    public class RequestInfo
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
    }

}


