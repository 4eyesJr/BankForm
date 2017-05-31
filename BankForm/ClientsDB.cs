using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    [Serializable]
    static class ClientsDB
    {
        static private string clientsDBTxt = "clientsDB.txt";

        static private List<ClientDB> clientsDB = new List<ClientDB>();

        static public List<ClientDB> GetClientsDB()
        {
            return clientsDB;
        }

        static public void AddToBaseClientsDB(ClientDB clientDB)
        {
            if (clientsDB == null)
            {
                clientsDB = new List<ClientDB>();
            }
            clientsDB.Add(clientDB);
            SaveFile();
        }

        static public void UpdateFile(bool save, bool load)
        {
            if (save) SaveFile();
            if (load) LoadFile();
        }

        static private void SaveFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(clientsDB, Formatting.Indented);
                File.Delete(clientsDBTxt);
                File.WriteAllText(clientsDBTxt, json);
            }
            catch { }
        }

        static private void LoadFile()
        {
            try
            {
                string json = File.ReadAllText(clientsDBTxt);
                clientsDB.Clear();
                clientsDB = JsonConvert.DeserializeObject<List<ClientDB>>(json);
            }
            catch { }
        }

        static public ClientDB CheckClient(string fio, string login)
        {
            foreach (var item in clientsDB)
            {
                if (item.Fio.Equals(fio) && item.Login.Equals(login))
                {
                    return item;
                }
            }
            return null;
        
        }


        static public ClientDB DeleteClient(string fio, string login)
        {
            foreach (var item in clientsDB)
            {
                if(item.Fio.Equals(fio) && item.Login.Equals(login))
                {
                    return item; 
                }
            }
            return null;
        }

        static public ClientDB SearchClient(string login, string FIO)
        {
            foreach (var clientForSearch in clientsDB)
            {
                if (clientForSearch.Login.Equals(login) && clientForSearch.Fio.Equals(FIO))
                {
                    Console.WriteLine(clientForSearch);
                    return clientForSearch;
                }

            }
            return null;
        }

        static public List<Credit> GetCredits()
        {
            List<Credit> credits = new List<Credit>();
            foreach (var item in clientsDB)
            {
                if (item.Credit != null)
                {
                    credits.Add(item.Credit);
                }

            }
            return credits;
        }

    }
}
