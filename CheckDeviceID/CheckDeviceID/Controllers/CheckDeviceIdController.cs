using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CheckDeviceID.Models;
using CheckDeviceID.DataAccess;
using Newtonsoft.Json;

namespace CheckDeviceID.Controllers
{
    public class CheckDeviceIdController : ApiController
    {

        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] checkdeviceidRequest value)
        {
            var responseObject = new checkdeviceidResponse() { status = "s", deviceMasterList = new Files().getDevice() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\cheackdeviceid.txt", mystr);
            return response;
        }

    }
}
