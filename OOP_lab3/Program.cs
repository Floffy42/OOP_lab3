using System.Text;

namespace OOP_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("1 - Перевертання чисел");
                Console.WriteLine("2 - ");
                Console.WriteLine("3 - ");
                Console.WriteLine("4 - ");

                Console.WriteLine("");
                Console.Write("Вибір - ");
                string? choice = Console.ReadLine();

                if (choice == null) return;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Reverse.Run();
                        break;

                    case "2":
                        Console.WriteLine("");
                        //.Run();
                        break;

                    case "3":
                        Console.WriteLine("");
                        //.Run();
                        break;

                    case "4":
                        Console.WriteLine("");
                        //.Run();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
