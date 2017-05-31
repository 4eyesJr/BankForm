using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    [Serializable]
    class ClientDB
    {
        public string Fio
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public Credit Credit
        {
            get;
            set;
        }

        public Deposit Deposit
        {
            get;
            set;
        }

        public ClientDB(string fio, string login)
        {
            Fio = fio;
            Login = login;
            Credit = null;
            Deposit = null;
        }

        static public List<string> SearchServices(ClientDB clientDB)
        {
            List<string> list = new List<string>();
            if (clientDB.Credit == null)
            {
                list.Add("Кредит");
            }
            if (clientDB.Deposit == null)
            {
                list.Add("Депозит");
            }
            //if (clientDB. == null)
            //{
            //    AddRequestBox.Items.Add("Кредит");
            //}
            //if (clientDB.Credit == null)
            //{
            //    AddRequestBox.Items.Add("Кредит");
            //}
            return list;

        }

        public string GetInfo()
        {
            string info = "";
            if (Credit != null)
            {
                info += "Кредит:" +
                        "\nТекущее состояние: " + Credit.CurrentMoney.ToString() +
                        "\nОбщая сумма: " + Credit.MaxMoney.ToString();
            }
            if (Deposit != null)
            {
                info += "Депозит:" +
                        "\nОбщая сумма: " + Deposit.GetMoney().ToString();
            }
            return info;

        }
    }
}
