using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAccountList.Models
{
    public class Accounts
    {
        //public RequestInfo requestInfo { get; set; }
        //public UserInfo UserInfo { get; set; }
        //public AddInfo AddInfo { get; set; }
        //public string status { get; set; }
        //public string statusDesc { get; set; }
        //public AccountList AccountList { get; set; }
    }

    public class GetAccountListResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public AccountList[] AccountMasterLists { get; set; }
    }

    public class GetAccountListRequest
    {
        public Deviceinfo Deviceinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
        public UserInfo UserInfo { get; set; }      
        
    }

    public class Deviceinfo
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

        public string pspRefNo { get; set; }
        public string profileId { get; set; }

    }

    public class AddInfo
    {

        public string addInfo9 { get; set; }
        public string addInfo10 { get; set; }

    }


    public class UserInfo
    {
        public string virtualAddress { get; set; }
        public string name { get; set; }
    }

    public class AccountList
    {
        public int accld { get; set; }
        public string maskedAccountNumber { get; set; }
        public string mpinFlag { get; set; }
        public string ifscCode { get; set; }
        public int uPinLength { get; set; }
        public int bankId { get; set; }
        public string accountName { get; set; }
        public string bankCode { get; set; }
    }

}