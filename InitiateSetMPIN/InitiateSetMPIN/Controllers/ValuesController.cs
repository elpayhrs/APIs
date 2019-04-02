using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InitiateSetMPIN.DataAccess;
using Newtonsoft.Json;
using InitiateSetMPIN.Models;

namespace InitiateSetMPIN.Controllers
{
    public class ValuesController : ApiController
    {


        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] InitiateSetMPINRequest value)
        {
            var responseObject = new InitiateSetMPINResponse() { status = "s", CredMasterList = new Files().Getcred() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\ InitiateSetMPIN.txt", mystr);
            return response;
        }


    }
}


