// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

    
Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    

    static int GetThirdDigit(int number)
    {
        int digitCount = (int)Math.Floor(Math.Log10(number) + 1);

        if (digitCount >= 3)
        {
            int thirdDigit = (number / (int)Math.Pow(10, digitCount - 3)) % 10;
            return thirdDigit;
        }

        return -1;
    }


    
