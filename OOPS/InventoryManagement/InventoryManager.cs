using Newtonsoft.Json;
using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryManager
    {
        InventoryFactory factory=new InventoryFactory();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        List<InventoryData> pulsesList = new List<InventoryData>();
        public void ReadData(string filepath)
        {
            InventoryDetails details = factory.ReadJson(filepath);
            this.riceList = details.RiceList;
            this.wheatList = details.WheatList;
            this.pulsesList = details.PulsesList;
        }
       //// public void DisplayInventory(string filePath)
       //// public void DisplayInventory(string filePath)
       // {
       //     using (StreamReader reader = new StreamReader(filePath))
       //     {
       //         var json = reader.ReadToEnd();
       //         var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
       //         this.riceList=
       //     }
       // }
        public void AddInventory(InventoryData data, string inventoryName, string filepath)
        {
            if (inventoryName.Equals("Rice"))
            {
                riceList.Add(data);
            }
            if (inventoryName.Equals("Wheat"))
            {
                wheatList.Add(data);
            }
            if (inventoryName.Equals("Pulses"))
            {
                pulsesList.Add(data);
            }
            SaveInventory(filepath);
        }
        public void SaveInventory(string filepath)
        {
            InventoryDetails details = new InventoryDetails();
            details.RiceList = riceList;
            details.WheatList = wheatList;
            details.PulsesList = pulsesList;
            factory.WriteToJson(filepath, details);
        }
        public void EditInventory(string inventoryName,string Grains,string filepath)
        {
            if (inventoryName.Equals("Rice"))
            {
                foreach (var data in riceList)
                {
                    if (data.Equals(Grains))
                    {
                        Console.WriteLine("Edit a item\n1.Name\n2.Weight\n3.PricePerKg");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch(option)
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
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (var data in wheatList)
                {
                    if (data.Equals(Grains))
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
                }
            }
            if (inventoryName.Equals("Pulses"))
            {
                foreach (var data in pulsesList)
                {
                    if (data.Equals(Grains))
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
                }
            }
            SaveInventory(filepath);
        }
    }
}
