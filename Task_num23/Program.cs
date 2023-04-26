//Семинар 3.
//Домашнее задание.
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int x = ReadInt("Введите число X ");

System.Console.WriteLine(string.Join("  ", Cube(x)));

int ReadInt(string argument)
{
	Console.Write(argument);

	int i;
    int j;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
		Console.WriteLine("Это не число! ");
        Console.Write(argument);
	}
    return i;
}

int [] Cube(int x)
{   if (x < 0)
    {   
        x = -x; 
        int [] T = new int [x + 2];
        for (int i = 0; i < x + 2; i++)
        {
            T[i] = (int)Math.Pow(1-i, 3); 
        }
        return T;
    }
    else if (x == 0)
    {    
        int [] T = new int [x + 2];
        for (int i = 0; i < x + 2; i++)
        {
            T[i] = (int)Math.Pow(1-i, 3);  
        }
        return T;
    }

    int [] S = new int [x];
    for (int i = 0; i < x; i++)
    {
       S[i] = (int)Math.Pow(i+1, 3); 
    }
    return S;
}
