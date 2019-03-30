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
            System.IO.File.WriteAllText(@"E:\jsonfiles\GetBankList.txt", mystr);
            return response;
        }

    }
}
