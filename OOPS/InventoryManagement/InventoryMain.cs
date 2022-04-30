using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryMain
    {
        public void DataManipulation(string filepath)
        {
            const string INVENTORY_LIST_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryManagement\InventoryList.json";
            InventoryManager manager = new InventoryManager();
            Console.WriteLine("1.Read Json\n2.Add Inventory\n3.Edit Inventory\n4.End Of Program");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Choose an option to exicute");
                int option=Convert.ToInt32(Console.ReadLine()); 
                switch(option)
                {
                    case 1:
                        manager.ReadData(filepath);
                        break;
                    case 2:
                        Console.WriteLine("Enter Inventory Details such as Name,Weight,Price");
                        InventoryData data = new InventoryData();
                        data.Name = Console.ReadLine();
                        data.Weight=Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Inventory Name");
                        string inventoryName1=Console.ReadLine();
                        manager.AddInventory(data, inventoryName1, INVENTORY_LIST_PATH);
                        break;
                    case 3:
                        Console.WriteLine("Enter Inventoryname list & grains");
                        string inventoryName=Console.ReadLine();
                        string grains1=Console.ReadLine();
                        manager.EditInventory(inventoryName, grains1, INVENTORY_LIST_PATH);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Proper option to exicute");
                        break;

                }
            }
        }
    }
}
