//try
//{
//    Console.WriteLine("Для определения поры года введите № месяца!");
//    int month = Convert.ToInt32(Console.ReadLine());

//    switch (month)
//    {
//        case 1:
//            Console.WriteLine("Сейчас зима");
//            break;
//        case 2:
//            Console.WriteLine("Сейчас зима");
//            break;
//        case 3:
//            Console.WriteLine("Сейчас весна");
//            break;
//        case 4:
//            Console.WriteLine("Сейчас весна");
//            break;
//        case 5:
//            Console.WriteLine("Сейчас весна");
//            break;
//        case 6:
//            Console.WriteLine("Сейчас лето");
//            break;
//        case 7:
//            Console.WriteLine("Сейчас лето");
//            break;
//        case 8:
//            Console.WriteLine("Сейчас лето");
//            break;
//        case 9:
//            Console.WriteLine("Сейчас осень");
//            break;
//        case 10:
//            Console.WriteLine("Сейчас осень");
//            break;
//        case 11:
//            Console.WriteLine("Сейчас осень");
//            break;
//        case 12:
//            Console.WriteLine("Сейчас зима");
//            break;


//        default:
//            Console.WriteLine("Вы ввели некоректные данные");
//            break;
//    }
//}
//catch
//{
//    Console.WriteLine("Вы ввели некоректные данные");
//}
//finally
//{
//    Console.ReadKey();
//}

try
{
    Console.WriteLine("Для определения поры года введите № месяца!");
    int month = Convert.ToInt32(Console.ReadLine());

    if (month == 1 || month == 2 || month == 12)
        Console.WriteLine("сейчас зима");
    else if (month == 3 || month == 4 || month == 5)
        Console.WriteLine("сейчас весна");
    else if (month == 6 || month == 7 || month == 8)
        Console.WriteLine("сейчас лето");
    else if (month == 9 || month == 10 || month == 11)
        Console.WriteLine("сейчас осень");
    else Console.WriteLine("веедены некоректные данные");
}
catch
{
    Console.WriteLine("Вы ввели некоректные данные");
}
finally
{
    Console.ReadKey();

}