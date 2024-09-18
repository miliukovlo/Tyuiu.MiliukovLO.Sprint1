using Tyuiu.MiliukovLO.Sprint1.Task2.V4.Lib;

public class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #2                                                               ");
        Console.WriteLine("* Вариант #4                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные   ");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int x;
        Console.WriteLine("* Введите длину стороны квадрата:                                          ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь квадрата равна - " + ds.CalculateSquare(x));
        Console.ReadKey();
    }
}