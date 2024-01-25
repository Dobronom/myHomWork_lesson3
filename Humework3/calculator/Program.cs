//Visual studio - Console Application
//Создать приложение калькулятор, выполняющая основные арифметические операции:

//-Сложение
//- Вычитание
//- Деление
//- Умножение
//- Процент от числа
//- Квадратный корень числа
//- Отображение результата

//По окончанию вычисления, диалог с пользователем с предложением о продолжении/окончании работы с программной
//Сделать приложение максимально устойчивым




using System;

Console.WriteLine("Добро пожаловать. Ознакомтесь с органами управления калькулятора");
Console.WriteLine("Сложение + , вычитание -, деление /, умножение *,\nпроценты от числа %, квадратный корень числа √(Для ввода символа зажать alt + 251 на NumPad)");

int i = 0;
while (i == 0)
{
    try
    {

        Console.WriteLine("Первое значение");
        double value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("укажите тип операции");
        string action = Console.ReadLine();

        if (action == "+")
        {
            Console.WriteLine("Второе значение");
            double value2 = Convert.ToInt32(Console.ReadLine());
            double result = value1 + value2;
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());

        }
        else if (action == "-")
        {
            Console.WriteLine("Второе значение");
            double value2 = Convert.ToInt32(Console.ReadLine());
            double result = value1 - value2;
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (action == "/")
        {
            Console.WriteLine("Второе значение");
            double value2 = Convert.ToInt32(Console.ReadLine());
            double result = value1 / value2;
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (action == "*")
        {
            Console.WriteLine("Второе значение");
            double value2 = Convert.ToInt32(Console.ReadLine());
            double result = value1 * value2;
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (action == "%")
        {
            Console.WriteLine("Второе значение");
            double value2 = Convert.ToInt32(Console.ReadLine());
            double result = (value2 / 100) * value1;
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (action == "√")
        {
            double result = Math.Sqrt(value1);
            Console.WriteLine("Ответ:\t" + result);
            Console.WriteLine("если вы желаете закончить рабоу введите любое число кроме 0");
            i = Convert.ToInt32(Console.ReadLine());
        }




    }
    catch
    {
        Console.WriteLine("Сбой. Возврат к началу программы.\nНажмите Enter");
    }
    finally
    {



        Console.ReadLine();

    }
}