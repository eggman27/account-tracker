using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountTraker.Models;
using System.Web.Script.Serialization;
using System.IO;

namespace AccountTraker.Data
{
    public class AccountDataService
    {
        public AccountsJsonModel GetAccountData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            AccountsJsonModel accounts = new JavaScriptSerializer().Deserialize<AccountsJsonModel>(fileData);

            return accounts;
        }
    }
}
