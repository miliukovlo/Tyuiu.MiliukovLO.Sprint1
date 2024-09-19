using Tyuiu.MiliukovLO.Sprint1.Task3.V4.Lib;

public class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #3                                                               ");
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
        double x,y;
        int count;
        Console.WriteLine("* Введите цену за тетрадь:                                                 ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите цену за обложку:                                                 ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите количество комплектов:                                           ");
        count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Цена за комплекты ровна - " + ds.PurchaseAmount(x,y,count));
        Console.ReadKey();
    }
}