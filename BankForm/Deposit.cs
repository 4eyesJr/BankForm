using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Deposit
    {
        private ClientDB clientDB;
        private int money;

        public Deposit(ClientDB clientDB, int money)
        {
            this.clientDB = clientDB;
            this.money = money;
            Deposits.AddToBaseRequests(this);
        }

        public int GetMoney()
        {
            return money;
        }

        public void SetMoney(int money)
        {
            this.money += money;
        }

        public int TakeMoney(int money)
        {
            if (this.money < money)
                return 0;
            if (this.money > money)
            {
                this.money -= money;
                return 1;
            }
    
            clientDB.Deposit = null;
            return 1;
            
            
        }

    }
}
