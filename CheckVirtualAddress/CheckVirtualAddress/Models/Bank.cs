using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace CheckVirtualAddress.Models
{
    public class Bank
    {

    }
    public class CheckvirtualAddressResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public PayeeType PayeetypeRes { get; set; }

        public VpaDetails[] VpaDetailsMasterList { get; set; }

    }

    public class CheckVirtualAddressRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
        public PayeeType Payeetype { get; set; }
        public RequestInfo RequestInfo { get; set; }
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
        public String wifiMac { get; set; }

    }
    public class AddInfo
    {

        public String addInfo { get; set; }
        public String addInfo9 { get; set; }

    }
    public class PayeeType
    {
        public String virtualAddress { get; set; }

    }
    public class RequestInfo
    {

        public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public String profileId { get; set; }
        public String vAReqType { get; set; }

    }

    //response classes

    public class requestInfo
    {
        public String pspid { get; set; }
        public String pspRefNo { get; set; }
    }

    public class PayeeTypeRes
    {
        public String defVPAStatus { get; set; }
        public String isVerified { get; set; }
        public String name { get; set; }
        public String spamRefNo { get; set; }
        public String virtualAddress { get; set; }

       
    }
    public class VpaDetails
    {
        public String fVaddr { get; set; }
        public String fName { get; set; }
        public String defVPAStatus { get; set; }
    }


}

