int i = 0;
while (i == 0)
{

    try
    {
        Console.Write("Введите температуру на улице: \t");
        int degree = Convert.ToInt32(Console.ReadLine());
        if (degree > -5)
            Console.WriteLine("Тепло");
        else if (degree < -5 && degree > -20)
            Console.WriteLine("Нормально");
        else Console.WriteLine("Холодно");
        i++;
    }
    catch
    {
        Console.Write("Неверные данные. \nВведите температуру по примеру \"-5,5,-10:\t");
    }
    finally
    {
        Console.ReadLine();
    }
}


