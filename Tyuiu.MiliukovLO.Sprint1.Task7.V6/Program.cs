using Tyuiu.MiliukovLO.Sprint1.Task7.V6.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #7                                                               ");
        Console.WriteLine("* Вариант #6                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по        ");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                       ");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        double x,y;
        Console.WriteLine("* Введите значение x:                                                 ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите значение y:                                                 ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Результат - " + ds.Calculate(x,y));
        Console.ReadKey();
    }
}