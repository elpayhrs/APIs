using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetAccountList.Models;
using GetAccountList.DataAccess;
using System.Web.Hosting;
using Newtonsoft.Json;

namespace GetAccountList.Controllers
{
    public class GetAccountListController : ApiController
    {

        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GetAccountListRequest value)
        {
            var responseObject = new GetAccountListResponse() { status = "s", AccountMasterLists = new Files().GetAccounts() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\getaccountlist.txt", mystr);
            return response;
        }

    }
}
