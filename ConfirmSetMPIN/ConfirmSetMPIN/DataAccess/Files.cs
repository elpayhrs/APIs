using ConfirmSetMPIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfirmSetMPIN.DataAccess
{
    public class Files
    {
        public RequestInfo[] req()
        {
            return new ReadFiles<RequestInfo>().Get(@"\Banks.Json");
        }

    }
}