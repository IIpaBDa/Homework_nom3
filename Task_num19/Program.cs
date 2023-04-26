//Семинар 3.
//Домашнее задание.
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int x = ReadInt("Введите число - ");

if (IsPalindrome(M(x)))
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не Палиндром");
}

int ReadInt(string argument)
{
	Console.Write(argument);

	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
        Console.WriteLine("Вы ввели не числовое значение!");
        Console.Write(argument);
        
	}

	return i;
}

int [] M(int x)
{
    string str = x.ToString();
    int [] S = new int [str.Length];
    for (int i = 0; i < str.Length; i++)
    {
       S[i] = int.Parse(str[i].ToString()); 
    }
    return S;
}

bool IsPalindrome(int [] S)
{  
    int i = 0;
    int j = S.Length - 1;
    while (i < j)
    {
        if (S[i] == S[j])
        {
            i++;
            j--;
        }
        else
        {
            return false;
        }
    }
return true;
}
