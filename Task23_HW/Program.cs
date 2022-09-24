int GetNmb()
{
Console.WriteLine("Введите число ");
return Convert.ToInt32(Console.ReadLine());
}
void PrintRaw(int number)
{
    int count = 1;
    Console.WriteLine("Талица кубов чисел от 1 до" + number + ": ");
    while(count <= number)
    {
        Console.Write(Math.Pow((count),3) + " ");
        count ++;
    }
}
PrintRaw(GetNmb());