int result (int count)
    {
        int a = (count % 100) / 10; 
        return a;
    }

Console.WriteLine("напишите любое трёхзначное число");
int count;
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"вторая цифра в вашем трхзначном числе = {result(count)}");
