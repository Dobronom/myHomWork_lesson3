try
{
    Console.Write("Введите число от 1 до 7 чтоб узнать его цвет в радуге:\t");
    int number = Convert.ToInt32(Console.ReadLine());
    switch (number)
    {
        case 1:
            Console.WriteLine("Красный");
            break;
        case 2:
            Console.WriteLine("Оранжевый");
            break;
        case 3:
            Console.WriteLine("Жёлтый");
            break;
        case 4:
            Console.WriteLine("Зелёный");
            break;
        case 5:
            Console.WriteLine("Голубой");
            break;
        case 6:
            Console.WriteLine("Синий");
            break;
        case 7:
            Console.WriteLine("Фиолетовый");
            break;
        default:
            Console.WriteLine("Ведены неверные данные");
            break;
    }
}
catch
{
    Console.WriteLine("Ведены неверные данные");
}
finally
{
    Console.ReadLine();
}