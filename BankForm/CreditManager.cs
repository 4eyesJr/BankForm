using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class CreditManager
    {
        static private Dictionary<int, Request> request = new Dictionary<int, Request>();
        const string type = "Кредит";

        static public Dictionary<int, Request> CheckRequest()
        {
            Requests.UpdateFile(false, true);
            request = Requests.SearchRequest(type);
            if (request.Count == 0)
                return null;
            else return request;
        }

        static public void DeleteRequest(int index)
        {
            Requests.DeleteFromBaseRequest(index);
        }

        static public void EnterData()
        {

        }

        static public void TakeRequest(string fio, string login)
        {
            ClientDB clientDB;
            if ((clientDB = ClientsDB.CheckClient(fio, login)) == null)
            {
                clientDB = new ClientDB(fio, login);
                ClientsDB.AddToBaseClientsDB(clientDB);
            }

            clientDB.Credit = new Credit(fio, login);
            ClientsDB.UpdateFile(true, true);
        }
        
        static public void DeleteData(string fio, string login)
        {
            ClientDB clientDB;
            if ((clientDB = ClientsDB.CheckClient(fio, login)) == null)
            {
                return;
            }

            clientDB.Credit = null;
        }


    }
}
