Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

void CheckPalindrom(int nmb)
{
    if(nmb >= 10000 && nmb < 100000)
    {
        int div1 = nmb / 10000;
        int ost1 = nmb % 10;
             if(div1 == ost1)
            {
                nmb = nmb / 10;
                int div2 = (nmb/ 100) % 10;
                int ost2 = nmb % 10;
                if(div2 == ost2)
                    Console.WriteLine("Ваше число является палиндромом");
            }
            else 
            Console.WriteLine("Ваше число не является палиндромом");     
    }
    else
    Console.WriteLine("Ваше число не пятизначное");
}
CheckPalindrom(number);
