using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAccountList2.Models
{
    public class Bank
    {
    }


    public class GetAccountList2Response
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public RequestInfoRes RequestInfoRes { get; set; }
        public UserInfoRes UserInfoRes { get; set; }      
        public AccountList[] AccountMasterList { get; set; }
    }


    public class UserInfo
    {

        public String defVPAStatus { get; set; }
        public String name { get; set; }
        public String accountId { get; set; }
        public String virtualAddress { get; set; }

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
        public String recoveryOptionFlag { get; set; }
        

    }

    public class RequestInfo
    {
        public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public String profileId { get; set; }
        public String requestType { get; set; }
        public String updateFlag { get; set; }

    }

    public class GetAccountList2Request
    {
        public DeviceInfo Deviceinfo { get; set; }
        public UserInfo Userinfo { get; set; }
        public RequestInfo Requestinfo { get; set; }
        public string appVersionCode { get; set; }
        public string bankCode { get; set; }


    }



    //response classes
    public class RequestInfoRes//this is for response class
    {
        public String pspId { get; set; }
        public String pspRefNo { get; set; }
    }

    public class UserInfoRes
    {
        public String name { get; set; }
      
        public String virtualAddress { get; set; }

    }

    public class AccountList
    {
        public String accId { get; set; }
        public String maskedAccountNumber { get; set; }
        public String mpinFlag { get; set; }
        public String ifscCode { get; set; }
        public String uPinLength { get; set; }
        public String bankId { get; set; }
        public String accountName { get; set; }
        public String bankCode { get; set; }
    }
    

}