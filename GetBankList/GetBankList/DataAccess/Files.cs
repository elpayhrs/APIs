using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetBankList.Models;

namespace GetBankList.Models
{
    public class Files
    {
        public Bank[] GetBanks()
        {
            //return new ReadFile<Bank>().Get(@"\banks.json");
            return new ReadFiles<Bank>().Get(@"\banks.json");
        }

    }
}