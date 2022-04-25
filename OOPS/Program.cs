using OOPS.InventoryDataManagement;
using System;
namespace OOPS
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("---------Welcome To Inventory Management");
            const string INVENTORY_DATA_PATH = @"E:\VisualPractise\OOPSDemo\OOPS\InventoryDataManagement\Inventory.json";
            InventoryManagement inventory = new InventoryManagement();
            Console.WriteLine("Select Number\n1.Display\n");
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
                        check=false;
                        break;
;                }
            }
        }
    }

}