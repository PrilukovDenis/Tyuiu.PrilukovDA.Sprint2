using Tyuiu.PrilukovDA.Sprint2.Task4.V6.Lib;

DataService ds = new DataService();

Console.WriteLine("Введите x ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ds.Calculate(x, y));