using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CheckVirtualAddress.DataAccess;
using Newtonsoft.Json;
using CheckVirtualAddress.Models;

namespace CheckVirtualAddress.Controllers
{
    public class ValuesController : ApiController
    {


        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] CheckVirtualAddressRequest value)
        {
            var responseObject = new CheckvirtualAddressResponse() { status = "s", VpaDetailsMasterList = new Files().GetVpaDetails() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\ CheckVirtualAddress.txt", mystr);
            return response;
        }


    }
}

