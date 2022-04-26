using OOPS.InventoryDataManagement;
using OOPS.InventoryManagement;
using OOPS.StockManagement;
using System;
namespace OOPS
{
    public class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("---------Welcome To Inventory Management-----------");
            const string INVENTORY_DATA_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryDataManagement\Inventory.json";
            const string INVENTORY_LIST_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryManagement\InventoryList.json";
            const string STOCK_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\StockManagement\Stock.json";
            InventoryManagementFile inventory = new InventoryManagementFile();
            InventoryManager manager = new InventoryManager();
            StockAccountManagement stockManagement = new StockAccountManagement();
            Console.WriteLine("Select Number\n1.DisplayInventory\n2.EditInventory\n3.DisplayInventoryList\n4.SaveInventory\n5.EditInventory\n6.StockDisplay\n7.End Of Program");
            bool check = true;
            while(check)
            {
                Console.WriteLine("Enter The Option");
                int option=Convert.ToInt32(Console.ReadLine()); 
                switch(option)
                {
                    case 1:
                        inventory.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        inventory.EditInventory(INVENTORY_DATA_PATH);
                        break;
                    case 3:
                        manager.DisplayInventory(INVENTORY_LIST_PATH);
                        break;
                   // case 4:
                     //   manager.AddInventory("riceList", "Rice",INVENTORY_LIST_PATH);
                       // break;
                    case 4:
                        manager.SaveInventory(INVENTORY_LIST_PATH);
                        break;
                    case 5:
                        manager.EditInventory("Rice","Rice",INVENTORY_LIST_PATH);
                        break;
                    case 6:
                        stockManagement.DisplayStock(STOCK_PATH);
                        break;
                    case 7:
                        check=false;
                        Console.WriteLine("Program is Ended");
                        break;
;                }
            }
        }
    }

}