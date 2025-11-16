using Tyuiu.PrilukovDA.Sprint2.Task2.V1.Lib;

DataService ds  = new DataService();

Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.CheckDotInShadedArea(x, y));

