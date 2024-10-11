namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Bank_Account account1 = new Bank_Account(45682012, "Tom Smith",  1000);
            Console.WriteLine(account1.ToString());

            Bank_Account account2 = new Bank_Account(75587891, "Mary Mills", 2500.00);
            Console.WriteLine(account2.ToString());

            account2.Withdraw();
            account1.Deposit();

        }
    }
}
