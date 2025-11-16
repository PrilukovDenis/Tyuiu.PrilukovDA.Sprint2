int x;

x = Convert.ToInt32(Console.ReadLine());

double y = 0;

if (x <= 0) y = x * x;

else if ((x > 0) && (x < 10)) y = 1.0 / x;

else y = 3.0 * x / 5;

Console.WriteLine(y);