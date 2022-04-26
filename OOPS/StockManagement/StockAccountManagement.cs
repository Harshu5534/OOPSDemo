using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.StockManagement
{
    public class StockAccountManagement
    {
        public void DisplayStock(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<StockData>>(json);
                Console.WriteLine("StockName" + "\t" + "NumOfShare" + "\t" + "SharePrice" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.StockName + "\t" + data.NumOfShares + "\t\t" + data.SharePrice + "\t\t" + (data.NumOfShares* data.SharePrice));
                }
            }
        }
    }
}
