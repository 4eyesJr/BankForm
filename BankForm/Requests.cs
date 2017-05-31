using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BankForm
{
    static class Requests
    {
        static private string requestTxt = "requests.txt";

        static private List<Request> requests = new List<Request>();

        static public void AddToBaseRequests(Request request)
        {
            if (requests == null)
            {
                requests = new List<Request>();
            }

            requests.Add(request);
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
                string json = JsonConvert.SerializeObject(requests, Formatting.Indented);
                File.Delete(requestTxt);
                File.WriteAllText(requestTxt, json);
            }
            catch { }
        }

        static private void LoadFile()
        {
            try
            {
                string json = File.ReadAllText(requestTxt);
                requests.Clear();
                requests = JsonConvert.DeserializeObject<List<Request>>(json);
            }
            catch { }
        }

        static public Dictionary<int, Request> SearchRequest(string type)
        {
            Dictionary<int ,Request> searchRequest = new Dictionary<int, Request>();
            int i = 0;
            foreach (var item in requests)
            {
                if(item.TypeRequest.Equals(type))
                {
                    searchRequest.Add(i ,item);
                }
                i++;
            }
            return searchRequest;
        }

        static public void DeleteFromBaseRequest(int index)
        {
            requests.RemoveAt(index);
            SaveFile();
        }
    }
}
