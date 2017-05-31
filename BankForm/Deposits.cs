using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    static class Deposits
    {
        static private string depositsTxt = "deposits.txt";

        static private List<Deposit> deposits = new List<Deposit>();

        static public void AddToBaseRequests(Deposit deposit)
        {
            deposits.Add(deposit);
            SaveFile();
        }

        static private void SaveFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(deposits);
                File.WriteAllText(depositsTxt, json);
            }
            catch { }
        }

        static public void LoadFile()
        {
            try
            {
                string json = File.ReadAllText(depositsTxt);
                deposits.Clear();
                deposits = JsonConvert.DeserializeObject<List<Deposit>>(json);
            }
            catch { }
        }
    }
}
