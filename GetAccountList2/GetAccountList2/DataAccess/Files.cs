using GetAccountList2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAccountList2.DataAccess
{
    public class Files
    {
        public AccountList[] req()
        {
            return new ReadFiles<AccountList>().Get(@"\Bank.Json");
        }
    }
}