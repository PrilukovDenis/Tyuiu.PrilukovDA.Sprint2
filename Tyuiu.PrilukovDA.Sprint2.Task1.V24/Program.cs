using Tyuiu.PrilukovDA.Sprint2.Task1.V24.Lib;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
Console.WriteLine(ds.GetLogicOperations(a, b, c, d));