using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tiping_test
{
    static class TableRec
    {
        /*public static List<User> users = new List<User>();*/
        public static void Getter(User user)
        {
            List<User> users = new List<User>();
            string sod = File.ReadAllText("SAVE");
            if (sod.Length > 0)
            {
                users = JsonConvert.DeserializeObject<List<User>>(sod);
            }
            else
            {
                users = new List<User>();
            }

            users.Add(user);
            string json = JsonConvert.SerializeObject(users);
            
            File.WriteAllText("SAVE", json);
            foreach (var i in users)
            {
                Console.WriteLine("-------------------");
                i.getter();
            }
        }
    }
}
