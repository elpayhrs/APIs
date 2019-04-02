using ConfirmSetMPIN.DataAccess;
using ConfirmSetMPIN.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConfirmSetMPIN.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    { 
        // POST api/values
         [HttpPost]
         public HttpResponseMessage Post([FromBody] ConfirmSetMPINRequest value)
            {
            var responseObject = new ConfirmSetMPINResponse() { status = "s", RequestInfoList = new Files().req() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\ ConfirmSetMPIN.txt", mystr);
            return response;
        }

        }
    }

