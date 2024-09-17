using Tyuiu.MiliukovLO.Sprint1.Task0.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         ");
        Console.WriteLine("* Задание #0                                                               ");
        Console.WriteLine("* Вариант #4                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*(5-2)        ");
        Console.WriteLine("* и печатает результат на экране.                                          ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 4/2*5/(3+2)*(5-2)                                                        ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        dataService.Calculate();
        Console.ReadKey();
    }
}