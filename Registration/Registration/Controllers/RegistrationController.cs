using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Registration.Models;
using Registration.DataAccess;
using Newtonsoft.Json;

namespace Registration.Controllers
{
    public class RegistrationController : ApiController
    {
        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] RegistrationRequest value)
        {
            var responseObject = new RegistrationResponse() { status = "s", requMasterList = new Files().GetReg() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\Register.txt", mystr);
            return response;
        }
    }
}
