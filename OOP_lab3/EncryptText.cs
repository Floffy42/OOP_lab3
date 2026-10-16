namespace OOP_lab3
{
    internal class EncryptText
    {
        public static void Run()
        {
            while (true)
            {
                Console.Write("Введіть рядок: ");
                string? input = Console.ReadLine();

                if (input == null) continue;

                input = EncriptWith(3, 'X', input.ToCharArray());
                input = EncriptWith(5, '9', input.ToCharArray());
                input = EncriptWith(15, '?', input.ToCharArray());

                Console.WriteLine($"Результат: {input}");
                Console.WriteLine("");
            }
        }
        private static string EncriptWith(int symbol, char character, char[] input)
        {
            for(int i = symbol-1; i < input.Length; i += symbol)
            {
                input[i] = character;
            }

            return new string(input);
        }
    }
}
