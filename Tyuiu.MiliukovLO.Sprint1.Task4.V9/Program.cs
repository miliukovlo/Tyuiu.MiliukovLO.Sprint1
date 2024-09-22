using Tyuiu.MilyukovLO.Sprint1.Task4.V9.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #4                                                               ");
        Console.WriteLine("* Вариант #4                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные   ");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                 ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        double x, y;
        int count;
        Console.WriteLine("* Введите значение x:                                                      ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите значение y:                                                      ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Ответ - " + ds.Calculate(x, y));
        Console.ReadKey();
    }
}