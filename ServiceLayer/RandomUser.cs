using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class RandomUser
    {
       public Root GetRandomUser()
        {
            Root root = new Root();
            using (var webClient = new WebClient())
            {
                    string rawJson = webClient.DownloadString("https://randomuser.me/apI");
                    root = JsonConvert.DeserializeObject<Root>(rawJson);
            }
            return root;
        }
    }
}
