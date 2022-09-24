double GetNmb(string name)
{
  Console.WriteLine("Введите координату " + name);
return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetNmb("x1");
double y1 = GetNmb("y1");
double z1 = GetNmb("z1");
double x2 = GetNmb("x2");
double y2 = GetNmb("y2");
double z2 = GetNmb("z2");

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    return distance;
}

Console.WriteLine("Расстояние между точками равно " + GetDistance(x1, y1, z1, x2, y2, z2));