using OOPS.InventoryDataManagement;
using OOPS.InventoryManagement;
using OOPS.StockManagement;
using System;
namespace OOPS
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Welcome To Inventory Management-----------");
            const string INVENTORY_DATA_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryDataManagement\Inventory.json";
            const string STOCK_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\StockManagement\Stock.json";
            InventoryManagementFile inventory = new InventoryManagementFile();
            InventoryManager manager = new InventoryManager();
            StockAccountManagement stockManagement = new StockAccountManagement();
            Console.WriteLine("Select Number\n1.DisplayInventory\n2.Manipulation data\n3.StockDisplay\n7.End Of Program");
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter The Option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventory.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        const string INVENTORY_LIST_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryManagement\InventoryList.json";
                        InventoryMain main = new InventoryMain();
                        main.DataManipulation(INVENTORY_LIST_PATH);
                        break;
                    case 3:
                        stockManagement.DisplayStock(STOCK_PATH);
                        break;
                    case 4:
                        check = false;
                        Console.WriteLine("Program is Ended");
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option To Execute");
                        break;
                }
            }
        }
    }

}