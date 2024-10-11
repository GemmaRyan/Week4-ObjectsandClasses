namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister register1 = new CashRegister();
            CashRegister register2 = new CashRegister();

            register1.AddItem(19.99m);
            register1.AddItem(5.49m);
            register1.AddItem(3.99m);

            register2.AddItem(15.00m);
            register2.AddItem(8.25m);

            Console.WriteLine("Cash Register 1:");
            Console.WriteLine($"Total: {register1.Total:C}");
            Console.WriteLine($"Number of items: {register1.ItemCount}");

            Console.WriteLine("\nCash Register 2:");
            Console.WriteLine($"Total: {register2.Total:C}");
            Console.WriteLine($"Number of items: {register2.ItemCount}");

            Console.WriteLine("\nTotal for all Cash Registers:");
            Console.WriteLine($"Total Cash: {CashRegister.TotalCash:C}");
            Console.WriteLine($"Total Items: {CashRegister.TotalItems}");






        }
    }
}
