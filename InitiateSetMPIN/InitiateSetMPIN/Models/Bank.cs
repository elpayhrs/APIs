using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitiateSetMPIN.Models
{
    public class Bank
    {
    }
    public class InitiateSetMPINResponse
    {
        public string status { get; set; }
        public Cred[] CredMasterList { get; set; }
    }
    public class AddInfo
    {

        public String addInfo10 { get; set; }
        public String addInfo9 { get; set; }
        public String cardType { get; set; }

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
        public String expiryDate { get; set; }
        public String lastSixDigitDebitCardno{ get; set; }

    }
    public class RequestInfo
    {
       public String pspId { get; set; }
        public String pspRefNo { get; set; }
        public String profileId { get; set; }
        public String virtualAddress { get; set; }

    }
    public class InitiateSetMPINRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
         public RequestInfo RequestInfo { get; set; }
    }


    //Response classes

    public class libResp
    {

    }
    public class RequestInfoRes
    {
        public String pspId { get; set; }
        public String pspRefno { get; set; }
        public String upitranRefNo { get; set; }
        public String npciTranId { get; set; }
        public String otpNpciTranId { get; set; }

    }

    public class DeviceInfoRes
    {
        public String deviceId { get; set; }
        public String mobileNo { get; set; }
    }
    public class PayerType
    {
        public String virtualAddress { get; set; }
        public String name { get; set; }
        public String payerBankName { get; set; }
        public String tranactionNote { get; set; }
    }
    public class Cred
    {
        public String credentialDataType { get; set; }
        public int credentialDataLength { get; set; }
        public int atmCrdLength { get; set; }
        public int otpCrdLength { get; set; }
        public String otpCrdType { get; set; }
    }
}

