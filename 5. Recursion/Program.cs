void first_sumOfDigitsOfNumber()
{
    int variableOfSum;      // Изначальное число, сумму чьих цифр ищем
    int lenghtOfNumber;     // Длина числа
    int[] massive;          // Массив для записи цифр
    int j = 0;              // Для записи чисел в массив 
    int checkOfMassive = 0; // Для перехода, от записи цифр в массив до сложения их (и всё в рекурсии)
    int result = 0;         // Итог

    Console.Write("Введите число, сумму чьих цифр вы хотите видеть: ");
    variableOfSum = Convert.ToInt32(Console.ReadLine()); 

    lenghtOfNumber = Convert.ToString(variableOfSum).Length;
    massive = new int[lenghtOfNumber];

    Console.WriteLine($"Итог: {Mathematic(variableOfSum, lenghtOfNumber, result, checkOfMassive, j, massive)}");
    Console.WriteLine();

    // Вычисления рекурсией
    int Mathematic(int variableOfSum, int lenght, int result, int checkOfMassive, int j, int[] massive)
    {
        // Запись цифр в массив
        if (checkOfMassive == 0)
        {
            if (lenght > 0)
            {
                massive[j] = Convert.ToString(variableOfSum)[j] - '0';
                j++;
                lenght--;
                return Mathematic(variableOfSum, lenght, result, checkOfMassive, j, massive);
            }
            else
            {
                checkOfMassive = 1;
                lenght = Convert.ToString(variableOfSum).Length;
            }
        }
        // Сложение цифр из массива
        if (checkOfMassive == 1)
        {
            if (lenght > 0)
            {
                result += massive[lenght - 1];
                lenght--;
                return Mathematic(variableOfSum, lenght, result, checkOfMassive, j, massive);
            }
        }
        return result;
    }
}

void second_mirrorNumber() 
{
    string word;      // Изначальное число, сумму чьих цифр ищем
    int lenghtOfWord;     // Длина числа
    string[] massive;          // Массив для записи цифр
    string[] mirrorMassive;     // Отзеркаленный массив
    int j = 0;              // Для записи чисел в массив 
    int checkOfMassive = 0; // Для перехода, от записи цифр в массив до сложения их (и всё в рекурсии)
    bool check = true; // Можно ли отзеркалить, или нет

    Console.Write("Введите слово которое хотите проверить на возможность отзеркалить и также прочесть: ");
    word = Console.ReadLine(); 

    lenghtOfWord = Convert.ToString(word).Length;
    massive = new string[lenghtOfWord];
    mirrorMassive = new string[lenghtOfWord];
    
    Console.WriteLine(Mirroring(word, lenghtOfWord, check, checkOfMassive, j, massive, mirrorMassive));
    Console.WriteLine();
    
    string Mirroring(string word, int lenght, bool check, int checkOfMassive, int j, string[] massive, string[] mirrorMassive)
    {
        // Запись букв в обычный массив + отзеркаленный
        if (checkOfMassive == 0)
        {
            if (lenght > 0)
            {
                massive[j] = word[j].ToString();
                mirrorMassive[j] = word[lenght - 1].ToString();
                j++;
                lenght--;
                return Mirroring(word, lenght, check, checkOfMassive, j, massive, mirrorMassive);
            }
            else
            {
                checkOfMassive = 1;
                lenght = Convert.ToString(word).Length;
            }
        }
        // Проверка
        if (checkOfMassive == 1)
        {
            if (massive[lenght - 1] == mirrorMassive[lenght - 1])
            {
                if (lenght == 1) 
                    // Потому что в условии выше 1 - 1 = 0, и получается,
                    // что у нас в этой строчке последним числом будет 1, а не 0
                {
                    check = true;
                    checkOfMassive = 2;
                    
                }
                --lenght;
                return Mirroring(word, lenght, check, checkOfMassive, j, massive, mirrorMassive);
            }
            else
            {
                checkOfMassive = 2;
                check = false;
            }
        }
        // Вывод
        string result = "";
        if (checkOfMassive == 2)
        {
            if (check == true)
            {
                result = $"Слово '{word}' можно отзеркалить";
            }
            else
            {
                result = $"Слово '{word}' нельзя отзеркалить";
            }
        }
        
        return result;
    }
}

void third_generatingAllBinaryStrings() //------------------------------------------------------------------------------ Остановился на этом
{
    
}

void Main()
{
    Console.WriteLine("Выбери задачу по рекурсии: ");
    Console.WriteLine("1 - Сумма цифр числа");
    Console.WriteLine("2 - Зеркальное слово");
    Console.WriteLine("3 - Генерация всех двоичных строк");
    Console.WriteLine("4 - Выход");
    
    // Выбор задачи
    bool cycle = true;
    while (true)
    {
        int intInput = fuctionOfInput();
        
        switch (intInput)
        {
            case 1:
                first_sumOfDigitsOfNumber();
                break;
            case 2:
                second_mirrorNumber();
                break;
            case 3:
                third_generatingAllBinaryStrings();
                break;
            case 4:
                cycle = false;
                break;
        }
        if (cycle == false)
        {
            Console.WriteLine("Выход");
            return;
        }
    }
    
    // Проверка ввода
    int fuctionOfInput()
    {
        string input;
        int intInput;
        while (true)
        {
            Console.Write("Ваш выбор: ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out intInput))
            {
                Console.WriteLine("Ошибка. Введите число");
                Console.WriteLine();
                continue;
            }

            if (intInput < 0 || intInput > 4)
            {
                Console.WriteLine("Ошибка. Число вышло за рамки выбора");
                Console.WriteLine();
                continue;
            }
            break;
        }
        
        return  intInput;
    }
}

// Вызов функции
Main();