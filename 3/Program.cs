string HolyDay (int dayCount)
    {
        if (dayCount == 6 || dayCount == 7)
            {
                return($"{dayCount} -> да");
            }
        else
            {
                return($"{dayCount} -> нет");
            }
    }
Console.WriteLine("Напишите номер дня недели");
System.Console.WriteLine(HolyDay(Convert.ToInt32(Console.ReadLine())));