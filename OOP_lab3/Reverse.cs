namespace OOP_lab3
{
    internal class Reverse
    {
        public static void Run()
        {
            while(true)
            {
                Console.Write("Введіть число: ");
                string? input = Console.ReadLine();

                if (input == null) continue;

                char[] charArray = input.ToCharArray();

                if (HasOperators(charArray) && CheckOperatorsError(charArray))
                {
                    Console.WriteLine($"Неправильне використання операторів");
                    Console.WriteLine($"");
                    continue;
                }

                char[] reversedArray = ReverseCharacters(charArray);

                Console.WriteLine($"Перевернуте число: {new string(reversedArray)}");
                Console.WriteLine($"");
            }
        }
        private static char[] ReverseCharacters(char[] array)
        {
            char[] reversedArray = new char[array.Length];

            if (HasOperators(array))
            {
                reversedArray[0] = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    reversedArray[i] = array[array.Length - i];
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    reversedArray[i] = array[array.Length - 1 - i];
                }
            }

            reversedArray = RemoveZeros(reversedArray);

            return reversedArray;
        }
        private static bool CheckOperatorsError(char[] array)
        {
            if(array.ContainsAny(['*', '/'])) return true;

            if (array.ContainsAny(['+', '-']))
            {
                if(array.IndexOfAny(['+', '-']) != 0) return true;
                else return false;
            }
            else return false;
        }
        private static bool HasOperators(char[] array)
        {
            return array.ContainsAny(['+', '-', '*', '/']);
        }
        private static char[] RemoveZeros(char[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == '0')
                {
                    array[i] = '\0';
                }
                else if (array[i] == '+' || array[i] == '-') continue;
                else break;
            }
            return array;
        }
    }
}
