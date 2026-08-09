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

void second_mirrorNumber() //------------------------------------------------------------------------------------------  Ещё доделываю
{
    string word;      // Изначальное число, сумму чьих цифр ищем
    int lenghtOfWord;     // Длина числа
    string[] massive;          // Массив для записи цифр
    int j = 0;              // Для записи чисел в массив 
    int checkOfMassive = 0; // Для перехода, от записи цифр в массив до сложения их (и всё в рекурсии)
    bool result = true;         // Итог

    Console.Write("Введите слово которое хотите проверить на возможность отзеркалить и также прочесть: ");
    word = Console.ReadLine(); 

    lenghtOfWord = Convert.ToString(word).Length;
    massive = new string[lenghtOfWord];

    Mirroring();
    
    if (result == true)
    {
        Console.WriteLine($"Слово {word } можно отзеркалить");
    }
    else
    {
        Console.WriteLine($"Слово {word } нельзя отзеркалить");
    }
    
    void Mirroring()
    {
        
    }
    
}

void third_generatingAllBinaryStrings()
{
    
}

void Main()
{
    Console.WriteLine("Выбери задачу по рекурсии: ");
    Console.WriteLine("1 - Сумма цифр числа");
    Console.WriteLine("2 - Зеркальное число");
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
                continue;
            }

            if (intInput < 0 || intInput > 4)
            {
                Console.WriteLine("Ошибка. Число вышло за рамки выбора");
                continue;
            }
            break;
        }
        
        return  intInput;
    }
    
    // ------------------------ Пример без рекурсии
    
    // Console.Write($"Введите слово, которое хотите проверить на одинаковую читаемость в обратном порядке: ");
    // string input = Console.ReadLine();
    //
    // int lenght = input.Length;
    // string[] massive = new string[lenght];
    //
    // int i = 1;
    // foreach (char c in input)
    // {
    //     massive[lenght - i] = Convert.ToString(c);
    //     i++;
    // }
    //
    // string result;
    // if (input == string.Join("", massive)) result = "Равны";
    // else result = "Не равны";
    //
    // Console.WriteLine($"Итог: {result}");
}

// Вызов функции
Main();