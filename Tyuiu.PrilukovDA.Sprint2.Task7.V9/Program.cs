using Tyuiu.PrilukovDA.Sprint2.Task7.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Прилуков Д.А. | НТм-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Прилуков Денис Алексеевич | НТм-24-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать консольную программу на C#                                      *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool result = ds.CheckDotInShadedArea(x, y);
Console.WriteLine($"Точка с координатами ({x}; {y}) {(result ? "находится" : "не находится")} в заштрихованной области");

Console.ReadKey();