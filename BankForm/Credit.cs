using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    [Serializable]
    class Credit
    {
        public string FIO { get; set; }
        public string Login { get; set; }
        public int CurrentMoney { get; set; }
        public int MaxMoney { get; }

        public Credit(string fio, string login)
        {
            FIO = fio;
            Login = login;
            CurrentMoney = 0;
            MaxMoney = 50000;
        }


        public int TakeMoney(int money)
        {
            CurrentMoney += money;
            if (CurrentMoney >= MaxMoney)
            {
                money = CurrentMoney - MaxMoney;
                CurrentMoney = MaxMoney;
                return money;
            }
            return 0;
        }
    }
}
