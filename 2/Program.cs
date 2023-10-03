string result (string count)
    {
        if (count.Length <= 2)
            {
                return("третьего числа нет");
            }
        else 
            {
                return($"третье число -> {count[2]}");
            }
    }
Console.WriteLine("Напишите любое число");
Console.WriteLine(result(Console.ReadLine()));
