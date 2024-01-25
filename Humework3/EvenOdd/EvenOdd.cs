using System.Diagnostics.Tracing;
int i = 0;
while (i == 0)
{
    try
    {
        Console.Write("Введите число чтоб определить его чётность:\t");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number % 2;
        if (result == 0)
            Console.WriteLine("Число чётное.");
        else
            Console.WriteLine("Число нечётное.");
        i++;

    }
    catch
    {
        Console.WriteLine("Неверные данные. \nВведите число:");
    }
    finally
    {


        Console.ReadKey();

    }

}

