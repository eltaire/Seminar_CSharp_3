double GetNmb(string name)
{
Console.WriteLine("Введите координату " + name);
return Convert.ToDouble(Console.ReadLine());
}
int CheckQuarter(double x, double y)
{
    if (x > 0 && y > 0 )
    return 1;
    else
    if (x < 0 && y > 0 )
    return 2;
    else
    if (x < 0 && y < 0 )
    return 3;
    else return 4;

}

double x = GetNmb("x");
double y = GetNmb("y");
Console.WriteLine("Четверть: " + CheckQuarter(x, y));