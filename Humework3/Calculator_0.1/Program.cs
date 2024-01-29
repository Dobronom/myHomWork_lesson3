
using System;
using System.ComponentModel.Design;
using static System.Collections.Specialized.BitVector32;
Console.WriteLine("Добро пожаловать. Ознакомтесь с органами управления калькулятора");
Console.WriteLine("Сложение + , вычитание -, деление /, умножение *,\n" +
    "проценты от числа %, квадратный корень числа √(Для ввода символа зажать alt + 251 на NumPad)\n" +
    "Для вывода результата =");
double check = 0;

while (check == 0)
{


    Console.WriteLine("Введите первое значение");
    try
    {


        double FirstValue = Convert.ToDouble(Console.ReadLine());
        double ResultMemory = FirstValue;
        Console.WriteLine("укажите тип операции");
        string action = Console.ReadLine();

        while (action != "=")
        {


            switch (action)
            {
                case "+":
                    {
                        Console.WriteLine("Следующее значение");
                        double value2 = Convert.ToInt32(Console.ReadLine());
                        ResultMemory += value2;
                        Console.WriteLine("укажите тип операции");
                        action = Console.ReadLine();
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Следующее значение");
                        double value2 = Convert.ToInt32(Console.ReadLine());
                        ResultMemory -= value2;
                        Console.WriteLine("укажите тип операции");
                        action = Console.ReadLine();
                        break;
                    }

                case "/":
                    {
                        Console.WriteLine("Следующее значение");
                        double value2 = Convert.ToInt32(Console.ReadLine());
                        if (value2 != 0)
                        {
                            ResultMemory /= value2;
                            Console.WriteLine("укажите тип операции");
                            action = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            Console.WriteLine("Введите другое значение");
                            double value3 = Convert.ToDouble(Console.ReadLine());
                            ResultMemory /= value3;
                            Console.WriteLine("укажите тип операции");
                            action = Console.ReadLine();
                            break;
                        }
                    }
                case "*":
                    {
                        Console.WriteLine("Следующее значение");
                        double value2 = Convert.ToInt32(Console.ReadLine());
                        ResultMemory *= value2;
                        Console.WriteLine("укажите тип операции");
                        action = Console.ReadLine();
                        break;
                    }
                case "%":
                    {
                        Console.WriteLine("Следующее значение");
                        double value2 = Convert.ToInt32(Console.ReadLine());

                        ResultMemory = (ResultMemory / 100) * value2;
                        Console.WriteLine("укажите тип операции");
                        action = Console.ReadLine();
                        break;
                    }
                case "√":
                    {
                        if (ResultMemory > 0) 
                        {
                            ResultMemory = Math.Sqrt(ResultMemory);
                            Console.WriteLine("укажите тип операции");
                            action = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя посчитать квадратный корень отрецательного числа.");
                            Console.WriteLine("Если желаете продолжить нажмите \"0\"");
                            check = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Некоректный ввод");
                        Console.WriteLine("Вывожу результат предыдущих операций!");
                        action = "=";

                        break;
                    }

            }


        }
        Console.Write("Результат:\t" + ResultMemory);
    }
    catch
    {
        Console.WriteLine("Неверный ввод данных!");




    }
    finally
    {
        Console.ReadLine();
    }
    Console.WriteLine("Если желаете продолжить нажмите \"0\"");
    check = Convert.ToDouble(Console.ReadLine());

}
