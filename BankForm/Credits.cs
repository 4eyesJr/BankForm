using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    static class Credits
    {
        static private List<Credit> credits = new List<Credit>();

        static public void SetCredits()
        {
            if (credits == null)
            {
                credits = new List<Credit>();
            }
            credits.Clear();
            credits = ClientsDB.GetCredits();
            foreach (var item in credits)
            {
                Console.WriteLine(item.FIO);
            }
        }

        static public List<Credit> GetCredits()
        {
            return credits;
        }
    }
}
