using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryFactory
    {
        public InventoryDetails ReadJson(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
                return inventory;
            }
        }
        public void WriteToJson(string filepath,InventoryDetails details)
        {
            var json = JsonConvert.SerializeObject(details);
            File.WriteAllText(filepath, json);
        }
    }
}
