namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("Ford" , "Focus" , 1.6 , 0);
            ford.ToString();

            Car opel = new Car("Opel" , "Astra" , 1.2 , 0);
            opel.ToString();

            Console.WriteLine(ford);
            Console.WriteLine(opel);

        }

    }
}
