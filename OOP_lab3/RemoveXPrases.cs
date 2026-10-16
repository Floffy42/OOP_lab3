namespace OOP_lab3
{
    internal class RemoveXPrases
    {
        public static void Run()
        {
            while (true)
            {
                Console.Write("Введіть рядок: ");
                string? input = Console.ReadLine();

                if (input == null) continue;

                Console.Write("Введіть кількість яку треба видалити: ");
                string? countString = Console.ReadLine();

                if (countString == null) continue;

                int count = int.Parse(countString);

                string[] phrases = input.Split(' ');

                if (count >= phrases.Length)
                {
                    Console.WriteLine($"Кількість слів менше ніж {count}");
                    Console.WriteLine($"");
                    continue;
                }

                string[] result = new string[phrases.Length - count];
                for (int i = count; i < phrases.Length; i++)
                {
                    result[i - count] = phrases[i];
                }

                Console.WriteLine($"Результат: {string.Join(" ", result)}");
                Console.WriteLine("");
            }
        }
    }
}
