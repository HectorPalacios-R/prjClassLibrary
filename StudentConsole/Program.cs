using StudentClass;

namespace StudentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Hector", 50);
            Console.WriteLine(student.ToString());
        }
    }
}
