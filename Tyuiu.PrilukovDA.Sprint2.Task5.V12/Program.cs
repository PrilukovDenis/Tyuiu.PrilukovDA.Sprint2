using Tyuiu.PrilukovDA.Sprint2.Task5.V12.Lib;

DataService ds =  new DataService();

Console.Write("Введите год: ");
int g = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите месяц (1-12): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.FindDateOfPreviousDay(g, m, n));