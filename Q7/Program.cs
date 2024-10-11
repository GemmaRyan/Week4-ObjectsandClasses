namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"name of school #{i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"number of students enrolled in {name}: ");
                int numberOfStudents;
                while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents < 0)
                {
                    Console.Write("enter number of students: ");
                }

                schools.Add(new School(name, numberOfStudents));
            }

            schools.Sort();

            Console.WriteLine("\nsorted by enrollment:");
            foreach (var school in schools)
            {
                Console.WriteLine(school);
            }
        }
    }
}
