using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Client
    {
        private string fio;
        private string login;

        public Client(string fio, string login)
        {
            this.fio = fio;
            this.login = login;
        }

        public void AddRequest(string typeRequest)
        {
            Request request = new Request(fio, login, typeRequest);
        }

        private void GetInfo()
        {

        }

    }
}
