using System.Drawing;

namespace OOP_lab3
{
    internal class VolumeCalculator
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("1 - Квадрат");
                Console.WriteLine("2 - Круг");
                Console.WriteLine("3 - Прямокутник");
                Console.WriteLine("4 - Трикутник");
                Console.WriteLine("");
                Console.Write("Оберіть фігуру: ");

                string? choice = Console.ReadLine();
                if(choice == null) continue;

                switch(choice)
                {
                    case "1":
                        Square();
                        Console.WriteLine("");
                        break;

                    case "2":
                        Circle();
                        Console.WriteLine("");
                        break;

                    case "3":
                        RectangleCalc();
                        Console.WriteLine("");
                        break;

                    case "4":
                        Triangle();
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Помилка");
                        Console.WriteLine("");
                        break;
                }
            }
        }
        private static void Square()
        {
            Console.Write("Розмір сторони: ");
            string? text = Console.ReadLine();
            if (text == null) return;

            float size = float.Parse(text);

            Console.WriteLine($"Площа квадрата = {size * size}");
        }
        private static void Circle()
        {
            Console.Write("Радіус: ");
            string? text = Console.ReadLine();
            if (text == null) return;

            float r = float.Parse(text);

            Console.WriteLine($"Площа круга = {3.14 * (r*r)}");
        }
        private static void RectangleCalc()
        {
            Console.Write("Розмір першої сторони: ");
            string? text = Console.ReadLine();
            if (text == null) return;

            float firstSide = float.Parse(text);

            Console.Write("Розмір другої сторони: ");
            text = Console.ReadLine();
            if (text == null) return;

            float secondSide = float.Parse(text);

            Console.WriteLine($"Площа прямокутника = {firstSide * secondSide}");
        }
        private static void Triangle()
        {
            Console.Write("Розмір основи трикутника: ");
            string? text = Console.ReadLine();
            if (text == null) return;

            float baseSize = float.Parse(text);

            Console.Write("Розмір висоти трикутника: ");
            text = Console.ReadLine();
            if (text == null) return;

            float height = float.Parse(text);

            Console.WriteLine($"Площа трикутника = {baseSize * height / 2}");
        }
    }
}
