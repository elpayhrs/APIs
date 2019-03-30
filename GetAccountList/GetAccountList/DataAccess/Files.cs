using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetAccountList.Models;

namespace GetAccountList.DataAccess
{
    public class Files
    {
        public AccountList[] GetAccounts()
        {
            //return new ReadFile<Bank>().Get(@"\banks.json");
            return new ReadFiles<AccountList>().Get(@"\Account.Json");
        }
    }
}