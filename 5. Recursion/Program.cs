void first_sumOfDigitsOfNumber()
{
    Console.Write("Введите число, сумму чьих цифр вы хотите видеть: ");
    int variableOfSum = Convert.ToInt32(Console.ReadLine());

    int lenghtOfNumber = Convert.ToString(variableOfSum).Length;
    int[] massive = new int[lenghtOfNumber];
    
    int i = 0;
    foreach (char a in Convert.ToString(variableOfSum))
    {
        massive[i] =  Convert.ToInt32(a - '0'); //Надо, т.к. это char, который переведёт значение из ASC||, увеличив его на 48
        //Console.WriteLine($"Номер элемента i = {i}, число {massive[i]}");
        i++;
        
    }
    
    int result = 0;
    int realResult; 
    Mathematic(lenghtOfNumber, result, massive, out realResult);
    
    // Вычисления рекурсией
    void Mathematic(int lenght, int result, int[] massiv, out int realResult)
    {
        if (lenght > 0)
        {
            result += massive[lenght - 1];
            lenght -= 1;
            Console.WriteLine($"Номер элемента {lenght}, прибавили число {result}");
            Mathematic(lenght, result, massive,  out realResult);
        }

        realResult = result;
    }
    
    /*
     * Почему считает правильно, а выводит только последний элемент?
     */
    
    Console.WriteLine($"Итог: {realResult}");
    Console.WriteLine();
}

void second_mirrorNumber()
{
    
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
    Console.WriteLine();
    
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
    
}

// Вызов функции
Main();