double GetNmb(string name)
{
  Console.WriteLine("Введите координату " + name);
return Convert.ToDouble(Console.ReadLine());
}


double x1 = GetNmb("x1");
double y1 = GetNmb("y1");
double x2 = GetNmb("x2");
double y2 = GetNmb("y2");

double GetDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + (Math.Pow((y2 - y1),2)));
    return distance;
}

// double GetLenght(double x1, double y1, double x2, double y2)
// {
//     if (x > 0 && y > 0 )
//     return 1;
//     else
//     if (x < 0 && y > 0 )
//     return 2;
//     else
//     if (x < 0 && y < 0 )
//     return 3;
//     else return 4;

// }

// double x1 = GetNmb("x1");
// double y1 = GetNmb("y1");
// double x2 = GetNmb("x2");
// double y2 = GetNmb("y2");
// double a = (x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1);
// float f = (float)distance;
// Console.WriteLine("Расстояния между точками в пространстве равно " + MathF.Sqrt(f));
Console.WriteLine("Расстояние между точками равно " + GetDistance(x1, x2, y1, y2));