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
    int realResult = Mathematic(lenghtOfNumber, result, massive);
    
    // Вычисления рекурсией
    int Mathematic(int lenght, int result, int[] massiv)
    {
        if (lenght > 0)
        {
            result += massive[lenght - 1];
            lenght -= 1;
            return Mathematic(lenght, result, massive); // Обязательный return функции
            /* Пишу для себя, как напоминание
             * Если ввести 1234, то функция 4 раза вызовет себя, которые будут наслаиваться друг на друга, 
             * и когда в последнем вызове не выполнится условие if, то на этом программа не закончится -
             * она ещё 3 раза выполнит return, то есть если было в вызове в result 9, то вернёт 9
             * Таким образом вернулись в самое начало и получили 4, а возвращая
             * саму функцию, то не допускаем это
             */
        }
        return result;
    }
    
    Console.WriteLine($"Итог: {realResult}");
    Console.WriteLine();
}

void second_mirrorNumber()
{
    Console.Write("Введите слово, которое хотите проверить, на возможность одинаково прочесть справа налево: ");
    string word = Console.ReadLine();
    int lenghtOfWord = word.Length;
    
    string mirrorWord;
    string[] massiveOfWord = new string[lenghtOfWord];

    int i = 0;
    foreach (char a in word)
    {
        massiveOfWord[i] =  Convert.ToString(a);
        i++;
    }
    
    int j = 0;
    string[] Mirrowing(int lenghtOfWord, int j, string[] massiveOfWord)
    {
        if (lenghtOfWord > j)
        {
            massiveOfWord[lenghtOfWord - 1] = massiveOfWord[j];
            j++;
            lenghtOfWord--;
            /* Продолжи с этого
             * Проверь, что массив правильно отзеркалился
             */
            // ------------------- Проверка 
            int i = 0;
            foreach (char a in word)
            {
                massiveOfWord[i] =  Convert.ToString(a);
                i++;
            }
            // ------------------- Проверка
            return Mirrowing(lenghtOfWord, j, massiveOfWord);
        }
        return massiveOfWord;
    }
    
    string[] massiveOfMirrorWord = Mirrowing(lenghtOfWord, j, massiveOfWord);

    bool result;
    if (massiveOfMirrorWord == massiveOfWord)
    {
        result = false;
    }
    else
    {
        result = true;
    }
    
    
    Console.WriteLine(result);
    Console.WriteLine();
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