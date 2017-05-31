using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Request
    {
        private string fio;
        private string login;
        private string typeRequest;

        public Request(string fio, string login, string typeRequest)
        {
            this.fio = fio;
            this.login = login;
            this.typeRequest = typeRequest;
            Requests.AddToBaseRequests(this);
        }

        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        public string TypeRequest
        {
            get { return typeRequest; }
            set { typeRequest = value; }
        }

    }
}
