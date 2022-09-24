string number = "";
string GetNmb()
{
Console.WriteLine("Введите пятизначное число ");
int A = Convert.ToInt32(Console.ReadLine());
number = Convert.ToString(A);
return number;
}
void CheckingNumber(string number)
{
  if (number.Length > 5)
  {
    Console.WriteLine("Вы ввели не пятизначное число");
  }
  else if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("Ваше число палиндром.");
  }
  else Console.WriteLine("Ваше число не палиндром.");
}
GetNmb();
CheckingNumber(number);