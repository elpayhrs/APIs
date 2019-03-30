
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetAccountList2.Models;
using GetAccountList2.DataAccess;
using Newtonsoft.Json;


namespace GetAccountList2.Controllers
{
    public class GetaccountList2Controller : ApiController
    {
        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GetAccountList2Request value)
        {
            var responseObject = new GetAccountList2Response() { status = "s", AccountMasterList = new Files().req() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\GetAccountList2.txt", mystr);
            return response;
        }
    }
}
