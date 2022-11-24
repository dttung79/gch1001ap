using ProductManagement;

bool running = true;
Shop shopee = new Shop();

while (running)
{
    shopee.PrintMenu();
    int choice = shopee.GetChoice();

    if (choice == 1) shopee.AddNewProduct();
    else if (choice == 2) shopee.SellProduct();
    else System.Console.WriteLine("Program terminted.");
    
    running = choice != 0;
}