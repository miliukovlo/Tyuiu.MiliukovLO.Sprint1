﻿using Tyuiu.MiliukovLO.Sprint1.Task5.V6.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #5                                                               ");
        Console.WriteLine("* Вариант #6                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                     ");
        Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение       ");
        Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели                    ");
        Console.WriteLine("* (понедельник, вторник,..., воскресенье) приходится k-й день              ");
        Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                    ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int x;
        Console.WriteLine("* Введите день:                                                 ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Ответ - " + ds.Calculate(x));
        Console.ReadKey();
    }
}