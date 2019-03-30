using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetBankList.Models
{
    public class Banks
    {
    }

    public class GetBankListResponse
    {
        public string status { get; set; }
        public Bank[] bankMasterList { get; set; }


    }

    public class Bank
    {
        public int accId { get; set; }
        public string bankCode { get; set; }
        public int bankId { get; set; }
        public string bankName { get; set; }
        public bool canShowBalance { get; set; }
        public bool checkedAccount { get; set; }
        public int uPinLength { get; set; }

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
    public class GetBankListRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
    }


}