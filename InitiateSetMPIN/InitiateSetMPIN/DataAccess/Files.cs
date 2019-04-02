using InitiateSetMPIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitiateSetMPIN.DataAccess
{
    public class Files
    {
        public Cred[] Getcred()
        {
            return new ReadFiles<Cred>().Get(@"\Banks.json");
        }
    }
}
   