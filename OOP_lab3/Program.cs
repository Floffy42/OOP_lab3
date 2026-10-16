namespace Basics {
    internal class Program {
        static void Main(string[] args) {

            #region DATA TYPES
            // bool have values: false or true
            bool isStudent = false;
            bool isTeacher = true;


            // byte is 8 bits (also called int8). Can have values from 256 (2 ^ 8) values. From 0 to 255
            byte asciiCharacter = 0;
            byte asciiCharacter2 = 255;
            byte hex90 = 0x90; // Hexadeciam view,  16 * 9 = 144 
            byte binary90 = 0b1010101; // Binary view, 64 + 16 + 4 + 1 = 85


            // char is 8 bits (also called int8). Can have values from 256 (2 ^ 8) values. From 0 to 255
            // https://www.asciitable.com/
            char letterA = 'a';
            char asciiLetterA = (char)97;

            // short is 16 bits or 2 bytes (also called int16). Can have values 65,536 (2^16). From -32,768 to 32,765
            short fileSize = 12345;
            short damage = -23450;
            short hexFileSize = 0x7BCC;
            short binFileSize = 0b101_01111101;
            Int16 sameShort = fileSize;


            // ushort is 16 bits or 2 bytes (also called int16). Can have values 65,536 (2^16). From 0 to 65,5536
            ushort unsignedFileSize = 65535;
            ushort hexUnsignedFileSize = 0xFFFF;
            ushort binaryUnsignedFileSize = 0b11111111_11111111;
            UInt16 sameUnsignedShort = unsignedFileSize;


            // int is 32 bits or 4 bytes (also called int32). Can have values 4,294,967,296 (2^32). From -2,147,483,648 to 2,147,483,647.
            int gameSize = 123_4324;
            Int32 sameGameSize = gameSize;
            int maxValueInHex = 0x7FFF_FFFF; // 2,147,483,647.
            int minValueInHex = -0x8000_0000; // -2,147,483,648.


            // uint is 32 bits or 4 bytes (also called int32). Can have values 4,294,967,296 (2^32). From 0 to 4,294,967,296,145.
            uint unsignedBigGameSize = 3_444_123_324;
            UInt32 sameBigGameSize = unsignedBigGameSize;
            uint unsignedMaxValueInHex = 0xFFFF_FFFF; // 2,147,483,647.
            uint unsignedMinValueInHex = 0x00;

            // long is 64 bits or 8 bytes (also called int64). Can have values 18,446,744,073,709,551,615. From -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            long bigInteger = 43_444_123_323;
            Int64 bigInteger2 = bigInteger;
            long maxHexBigInteger = 0x7FFF_FFFF_FFFF_FFFF;
            long minHexBigInteger = -0x8000_0000_0000_0000;

            // ulong is 64 bits or 8 bytes (also called int64). Can have values 18,446,744,073,709,551,615. From 0 to 18,446,744,073,709,551,615.
            ulong unsignedBigInteger = 43_444_123_323;
            Int64 unsignedBigInteger2 = bigInteger;
            ulong unsignedMaxHexBigInteger = 0xFFFF_FFFF_FFFF_FFFF;
            ulong unsignedMinHexBigInteger = 0x00;


            // float is 32 bits or 4 bytes. 
            float pi = 3.14f;
            float radius = 25.23f;
            float acceleration = -13.23f;

            // double is 64 bits or 8 bytes. 
            double precisionFloatingPoint = 2.434324234234;

            // string is array of characters
            string name = "Volodymir";
            char[] nameInCharacters = name.ToCharArray();


            // For variable creation use next format:
            // "type" "name";
            // OR
            // "type" "name" = "value"
            // example:
            int age;
            int height = 180;
            bool isActivePlayer = true;
            char classLetter = 'B';
            float correctEquationAnswer = 3.454f;
            string text = "Hello";

            #endregion

            #region BASIC OPERATORS

            int variableX = 0;
            int newVariableY = variableX + 1; // 0 + 1 = 1;
            int newVariableZ = newVariableY - 15; // 1 - 15 = -15

            newVariableZ = newVariableZ * 10; // -15 * 10 = -150
            newVariableZ = newVariableZ / 5; // -150 / 5 = -30


            int points = 10;
            points++; // 11
            ++points; // 12

            points--; // 11
            --points; // 10

            int score = 15;
            score += 5; // 20
            score -= 2; // 18
            score *= 2; // 36
            score /= 3; // 12

            // Division

            int a = 10 / 3; // 3
            a = 2 / 3; // 0
            a = 1 / 3; // 0
            a = 3 / 3; // 1
            a = 4 / 3; // 1


            int b = 5 % 3; // 2
            b = 4 % 3; // 1
            b = 3 % 3; // 0
            b = 2 % 3; // 2
            b = 1 % 3; // 1
            b = 0 % 3; // 0

            // When u need to find Every Nth element
            // Example u need to do some operation every 5th element
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.WriteLine("Action for every 5th element");
                }
            }





            #endregion

            #region Boolean operations
            // There are 4 key operations:
            // AND in C# - &&
            // OR  in C# - ||
            // NOT in C# - !
            // XOR in C# - ^

            bool logicAnd = true && true; // true
            logicAnd = true && false; // false
            logicAnd = false && true; // false
            logicAnd = false && false; // false

            bool logicOr = true && true; // true
            logicOr = true && false; // true
            logicOr = false && true; // true
            logicOr = false && false; // false

            bool logicNot = !true; // false
            logicNot = !false; // true

            bool logicXOR = true && true; // false
            logicXOR = false && true; // true
            logicXOR = true && false; // true
            logicXOR = false && false; // false

            bool exampleA = true;
            bool exampleB = true;
            bool exampleC = false;
            bool exampleD = true;

            bool result = exampleA && exampleB;
            bool result2 = !(!exampleA || !exampleB);

            if (result == result2) {
                Console.WriteLine("The same value for result & result2");
            }

            bool result3 = !exampleA || exampleB;
            bool result4 = !(exampleA && !exampleB);

            if (result3 == result4) {
                Console.WriteLine("The same value for result3 & result4");
            }

            bool result5 = (exampleA || exampleB) && !(exampleC || !exampleD);
            bool result6 = exampleA && !exampleC && exampleD || exampleB && !exampleC && exampleD;

            if (result5 == result6) {
                Console.WriteLine("Result 5 == result 6");
            }
            Console.WriteLine("-------------------");
            #endregion

            #region Comparisons/Checks
            // Comparisons operators
            // == - equals
            // != - not equals
            // > - more than
            // < - less than
            // >= - more than or equal
            // <= - less than or equal

            bool compareResult = 16 > 5;
            compareResult = 5 == 5;

            int number = 16;
            compareResult = 120 >= number;
            compareResult = 12 < number || 120 > number;

            compareResult = compareResult && !(20 < number);

            bool compareResult2 = !compareResult || false || 2 > 3 || number >= 15;

            #endregion

            #region Flow control

            // For if/else statements

            int moveCount = 12;
            bool isEvenMove = moveCount % 2 == 0; // even move
            bool isOddMove = moveCount % 2 == 1; // odd move


            // inside () has to be "bool" variable or result of bool operator/function
            if (isEvenMove) {
                Console.WriteLine("Even move");
            } else {
                Console.WriteLine("Odd Move");
            }

            Console.WriteLine("-------------------");

            moveCount++;
            isEvenMove = moveCount % 2 == 0; // even move
            isOddMove = moveCount % 2 == 1; // odd move


            // inside () has to be "bool" variable or result of bool operator/function
            if (isEvenMove) {
                Console.WriteLine("Even move");
            } else {
                Console.WriteLine("Odd Move");
            }

            Console.WriteLine("-------------------");
            moveCount = 12;

            // Multiple if/else
            if (moveCount % 5 == 0) {
                Console.WriteLine("5th move");
            } else if (moveCount % 4 == 0) {
                Console.WriteLine("4th move");
            } else if (moveCount % 3 == 0) {
                Console.WriteLine("3th move");
            } else if (moveCount % 2 == 0) {
                Console.WriteLine("2th move");
            } else {
                Console.WriteLine("1th move");
            }

            Console.WriteLine("-------------------");
            string color = "green";

            if (color == "green") {
                Console.WriteLine("Green");
            } else if (color == "red") {
                Console.WriteLine("Red");
            } else {
                Console.WriteLine("Yellow");
            }

            Console.WriteLine("-------------------");
            // When u compare the same variable for equals with many if/else. Use switch.
            // it's the same as:
            switch (color) {
                case "green": {
                        Console.WriteLine("Green");
                        break;
                    }
                case "red": {
                        Console.WriteLine("Red");
                        break;
                    }
                default: {
                        Console.WriteLine("Yellow");
                        break;
                    }
            }
            Console.WriteLine("-------------------");
            #endregion


            #region LOOPS

            // For look syntax:
            // for( initialization for variables ;  condition to continue ; action in the end of iteration );
            // Examples:
            // U need to execute some operation 10 times
            for (int i = 0; i < 10; i = i + 1) {
                Console.WriteLine("Print the same line 10 times");
            }
            Console.WriteLine("-------------------");

            // U need to execute some operation 10 times
            for (int i = 10; i > 0; i = i - 1) {
                Console.WriteLine("Print the same line 10 times");
            }
            Console.WriteLine("-------------------");

            // if u need to change some variable and know its value
            for(int i = 0; i < 5; i++) {
                Console.WriteLine("I = " + i);
            }
            Console.WriteLine("-------------------");

            // The same but to change order in reverse
            for(int i = 5; i > 0; i--) {
                Console.WriteLine("I = " + i);
            }
            Console.WriteLine("-------------------");

            int row = 0;
            for(; row < 6; row = row + 2 ) {
                Console.WriteLine("Use variable outside loop and change values by 2, row = " + row);
            }
            Console.WriteLine("-------------------");

            int column = 0;
            for(; column < 8; ) {
                Console.WriteLine("Use variable outside loop and change value inside loop, column = " + column);
                column = column + column + 1;
            }
            Console.WriteLine("-------------------");

            int playerNumber = 0;
            for(; ;) {
                Console.WriteLine("nothing inside loop, playerNumber = " + playerNumber);
                playerNumber = (playerNumber + 1) * 2;
                if(playerNumber >= 20) {
                    break;// exit loop condition
                }
            }
            Console.WriteLine("-------------------");


            // one more loop 
            // while ( bool variable or expression) - continue to do until its true or "break"
            int whileCounter = 0;
            bool continueWhile = true;
            while (continueWhile) {
                Console.WriteLine("Inside while lookp, counter = " + whileCounter);
                whileCounter = whileCounter + 1;
                if(whileCounter > 5) {
                    continueWhile = false;
                }
            }
            Console.WriteLine("-------------------");

            whileCounter = 0;
            while (true) {
                Console.WriteLine("Inside while lookp, counter = " + whileCounter);

                whileCounter = whileCounter + 1;
                if(whileCounter > 5) {
                    break;
                }
            }
            Console.WriteLine("-------------------");


            int reverseToZero = 17;
            while(reverseToZero >= 0) {
                Console.WriteLine("Count down to zero:" + reverseToZero);
                reverseToZero--;
            }
            Console.WriteLine("-------------------");

            // one more loop: do {} while(bool variable or expression) // continues until expression = true

            string letters = "abc";
            int asciiLetter = 100;
            do {
                letters += (char)asciiLetter;
                asciiLetter++;
                Console.WriteLine("Letters:" + letters);
            } while (asciiLetter < 112);

            Console.WriteLine("-------------------");
            #endregion


            #region Multi loops 

            for(int x = 0; x < 10; x = x + 1) {
                for(int y = x+1; y < 5; y = y + 1) {
                    Console.WriteLine("X:" + x + " Y:" + y);
                }
            }
            Console.WriteLine("-------------------");

            for(int x = 0; x < 10; x = x + 1) {
                for(int y = x+1; y < 5; y = y + 1) {
                    for (int z = x + 2; z < 10; z = z + 2) {
                        Console.WriteLine("X:" + x + " Y:" + y + " Z:" + z);
                    }
                }
            }
            Console.WriteLine("-------------------");
            #endregion

            #region String output

            int putInsideText = 12;
            float putInsideText2 = 95.49f;
            string nameInText = "David";
            Console.WriteLine($" Number1 ={putInsideText} and float number={putInsideText2} - said by {nameInText}");
            Console.WriteLine("-------------------");

            Console.WriteLine("Formatted output {0}, {1} , {2}", putInsideText, putInsideText2,nameInText);
            Console.WriteLine("-------------------");


            string fullname = "Serhii Fedotov";
            string firstname = fullname.Split(' ')[0];
            string lastname = fullname.Split(' ')[1];
            Console.WriteLine($"Fullname: {fullname}, firstname:{firstname}, lastname:{lastname}");
            Console.WriteLine("-------------------");

            string bigText = "lorem ipsum  great staff game good nice car";
            string great = bigText.Substring(13, 5);
            Console.WriteLine($"Great word only: {great}");
            Console.WriteLine("-------------------");


            string bigTextToSearch = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting. Find this text. remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            string findText = "Find this text";

            int indexForFindText = bigTextToSearch.IndexOf(findText);

            string textAfterFindText = bigTextToSearch.Substring(indexForFindText + findText.Length);
            Console.Write(textAfterFindText);
            Console.WriteLine("-------------------");

            #endregion


            #region Input from Console && Converting values
            // string userInput = Console.ReadLine();
            string userInput = "123";
            // Converting to integer
            int userInputNumber = int.Parse(userInput); 

            string userInputFloat = "123.12";
            // Converting to integer
            float valueForX = float.Parse(userInputFloat);

            // Convert to string
            int someNumber = 4354;
            string numberInString = someNumber.ToString();

            #endregion

            #region Arrays
            // When u have a lot of variables with similar context
            string[] students = {"Oleg", "Volodymyr", "Elena", "Maria"}; // initialization inline
            int[] studentAges = new int[4]; // 4 size of array
            studentAges[0] = 21;
            studentAges[1] = 23;
            studentAges[2] = 25;
            studentAges[3] = 19;

            // Arrays work good with loops
            // Example we want to print all students names

            // arrays have property Length, example students.Length // 4
            for(int studentNumber = 0; studentNumber < students.Length; studentNumber++) {
                Console.WriteLine($"Name={students[studentNumber]} with age: {studentAges[studentNumber]}");
                Console.WriteLine("-------------------");
            }


            /*
             *  R _ B Q K B N R
             *  P P P P _ P P P
             *  _ _ N _ _ _ _ _
             *  _ _ _ _ P _ _ _
             *  - - - - p - - -
             *  - - - - - n - -
             *  p p p p - p p p
             *  r n b q k b - r
             */
            char[,] chessBoard = new char[8, 8];
            chessBoard[0, 0] = 'R';
            chessBoard[0, 1] = '_';
            chessBoard[0, 2] = 'B';
            chessBoard[0, 3] = 'Q';
            chessBoard[0, 4] = 'K';
            chessBoard[0, 5] = 'B';
            chessBoard[0, 6] = 'N';
            chessBoard[0, 7] = 'R';

            chessBoard[1, 0] = 'P';
            chessBoard[1, 1] = 'P';
            chessBoard[1, 2] = 'P';
            chessBoard[1, 3] = 'P';
            chessBoard[1, 4] = '_';
            chessBoard[1, 5] = 'P';
            chessBoard[1, 6] = 'P';
            chessBoard[1, 7] = 'P';


            chessBoard[2, 0] = '_';
            chessBoard[2, 1] = '_';
            chessBoard[2, 2] = 'N';
            chessBoard[2, 3] = '_';
            chessBoard[2, 4] = '_';
            chessBoard[2, 5] = '_';
            chessBoard[2, 6] = '_';
            chessBoard[2, 7] = '_';

            chessBoard[3, 0] = '_';
            chessBoard[3, 1] = '_';
            chessBoard[3, 2] = '_';
            chessBoard[3, 3] = '_';
            chessBoard[3, 4] = 'P';
            chessBoard[3, 5] = '_';
            chessBoard[3, 6] = '_';
            chessBoard[3, 7] = '_';

            chessBoard[4, 0] = '_';
            chessBoard[4, 1] = '_';
            chessBoard[4, 2] = '_';
            chessBoard[4, 3] = '_';
            chessBoard[4, 4] = 'p';
            chessBoard[4, 5] = '_';
            chessBoard[4, 6] = '_';
            chessBoard[4, 7] = '_';

            chessBoard[5, 0] = '_';
            chessBoard[5, 1] = '_';
            chessBoard[5, 2] = '_';
            chessBoard[5, 3] = '_';
            chessBoard[5, 4] = '_';
            chessBoard[5, 5] = 'n';
            chessBoard[5, 6] = '_';
            chessBoard[5, 7] = '_';


            chessBoard[6, 0] = 'p';
            chessBoard[6, 1] = 'p';
            chessBoard[6, 2] = 'p';
            chessBoard[6, 3] = 'p';
            chessBoard[6, 4] = '_';
            chessBoard[6, 5] = 'p';
            chessBoard[6, 6] = 'p';
            chessBoard[6, 7] = 'p';

            chessBoard[7, 0] = 'r';
            chessBoard[7, 1] = 'n';
            chessBoard[7, 2] = 'b';
            chessBoard[7, 3] = 'q';
            chessBoard[7, 4] = 'k';
            chessBoard[7, 5] = 'b';
            chessBoard[7, 6] = '_';
            chessBoard[7, 7] = 'r';


            for(int i = 0; i < 8; i++) {
                for(int j = 0; j < 8; j++) {
                    Console.Write($"{chessBoard[i, j]}  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }



            #endregion

        }
    }
}