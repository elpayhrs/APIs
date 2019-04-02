using GetBankList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace GetBankList.Controllers
{
    public class GetBankListController : ApiController
    {

        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GetBankListRequest value)
        {
            var responseObject = new GetBankListResponse() { status = "s", bankMasterList = new Files().GetBanks() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            //System.IO.File.WriteAllText(@"E:\jsonfiles\GetBankList.txt", mystr);

            getbanklist data = new getbanklist();

            data.addInfo10 = value.Addinfo.addInfo;
            data.addInfo9 = value.Addinfo.addInfo9;

            data.datestamp = DateTime.Now;

            data.androidId = value.Deviceinfo.androidid;
            data.appName = value.Deviceinfo.appName;
            data.appVersionCode = value.Deviceinfo.appVersionCode;
            data.appVersionName = value.Deviceinfo.AppVersionName;
            data.bluetoothMac = value.Deviceinfo.bluetoothMac;
            data.capability = value.Deviceinfo.capability;
            data.deviceId = value.Deviceinfo.deviceId;
            data.deviceType = value.Deviceinfo.deviceType;
            data.geoCode = value.Deviceinfo.geoCode;
            data.ip = value.Deviceinfo.ip;
            data.location = value.Deviceinfo.location;
            data.mobileNo = value.Deviceinfo.mobileNo;
            data.os = value.Deviceinfo.os;
            data.regId = value.Deviceinfo.regId;
            data.selectedSimSlot = value.Deviceinfo.selectedSimSlot;
            data.simId = value.Deviceinfo.simId;
            data.wifiMac = value.Deviceinfo.WifiMac;


            data.pspId = value.RequestInfo.pspId;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;
            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();
            

            using (WEBAPIEntities3 ent = new WEBAPIEntities3())
            {

                ent.getbanklists.Add(data);
                ent.SaveChanges();


            }

            return response;

        }




    }
}
