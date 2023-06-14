// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7):");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        bool isWeekend = IsWeekend(dayOfWeek);

        if (isWeekend)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }

        Console.ReadLine();
    

    static bool IsWeekend(int dayOfWeek)
    {
        return dayOfWeek == 6 || dayOfWeek == 7;
    }
