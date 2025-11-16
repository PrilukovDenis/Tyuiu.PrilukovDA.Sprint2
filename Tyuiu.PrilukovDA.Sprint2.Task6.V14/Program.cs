using Tyuiu.PrilukovDA.Sprint2.Task6.V14.Lib;

DataService ds  = new DataService();

Console.Write("Введите номер дня года ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день недели ");
int d = Convert.ToInt32(Console.ReadLine());

string result = ds.FindDayName(k, d);
Console.WriteLine(result);
