using CheckVirtualAddress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckVirtualAddress.DataAccess
{
    public class Files
    {
        public VpaDetails[] GetVpaDetails()
        {
            return new ReadFiles<VpaDetails>().Get(@"\banks.json");
        }
    }
}



        


 