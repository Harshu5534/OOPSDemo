using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryDataManagement
{
    public class InventoryManagementFile
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "PricePerKg" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.PricePerKg + "\t\t" + (data.Weight * data.PricePerKg));
                }
            }
        }
        public void EditInventory(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            var name = JsonConvert.DeserializeObject<List<InventoryData>>(json);
            Console.WriteLine("Enter Item Name To Edit Data");
            string Name1 = Console.ReadLine();
            foreach (var data in name)
            {
                if (data.Name.Equals(Name1))
                {
                    Console.WriteLine("Edit a item\n1.Name\n2.Weight\n3.PricePerKg");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string Name = Console.ReadLine();
                            data.Name = Name;
                            break;
                        case 2:
                            int weight = Convert.ToInt32(Console.ReadLine());
                            data.Weight = weight;
                            break;
                        case 3:
                            int PricePerKg = Convert.ToInt32(Console.ReadLine());
                            data.PricePerKg = PricePerKg;
                            break;
                        default:
                            Console.WriteLine("Enter Correct Option");
                            break;
                    }

                }
                string output = JsonConvert.SerializeObject(data);
                File.WriteAllText(filePath, output);
            }
        }
    }
}
