using Tyuiu.PrilukovDA.Sprint2.Task0.V30.Lib;

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
Console.WriteLine(ds.GetCompareOperations(x, y));