namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("Ford", "Focus", 1.6, 0);
            ford.DisplayCarInfo();

            ford.Accelerate();

            Car opel = new Car("Opel", "Astra", 1.2, 100);
            opel.DisplayCarInfo();

            //Console.WriteLine(ford);
            //Console.WriteLine(opel);


        }
    }
}
