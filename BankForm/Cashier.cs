using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Cashier
    {
        static public int PaymentCredit(string fio, string login, int money)
        {
            ClientDB client = ClientsDB.SearchClient(login, fio);
            if (client == null) return -1;

            return client.Credit.TakeMoney(money);
        }
    }
}
