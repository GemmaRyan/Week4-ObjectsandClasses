namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Making the euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            CashRegister register1 = new CashRegister();
            CashRegister register2 = new CashRegister();



            Console.WriteLine($"Adding an item worth {register1.AddItem} to Cash Register 1");
            Console.WriteLine($"Adding an item worth {register1.AddItem} to Cash Register 1");
            Console.WriteLine($"Adding an item worth {register1.AddItem} to Cash Register 1");





            //register1.AddItem(10.99m);
            //register1.AddItem(5.49m);
            //register1.AddItem(3.99m);

            
            register2.AddItem(20.00m);
            register2.AddItem(15.75m);


            
            //Console.WriteLine("Register 1:");
            //Console.WriteLine($"Total Price: {register1.Total:C}");
            //Console.WriteLine($"Number of Items: {register1.NumberOfItems:C}");

            //Console.WriteLine("\nRegister 2:");
            //Console.WriteLine($"Total Price: {register2.Total:C}");
            //Console.WriteLine($"Number of Items: {register2.NumberOfItems:C}");

        }
    }
}
