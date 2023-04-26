//Семинар 3.
//Домашнее задание.
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int x1 = ReadInt("Введите X первой точки");
int y1 = ReadInt("Введите Y первой точки");
int z1 = ReadInt("Введите Z первой точки");

int x2 = ReadInt("Введите X второй точки");
int y2 = ReadInt("Введите Y второй точки");
int z2 = ReadInt("Введите Z второй точки");

Console.WriteLine($"Расстояние между точкой 1 и точкой 2 = {GetLine(x1, y1, z1, x2, y2, z2)}");


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");

	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
		Console.WriteLine("It's not a number");
	}

	return i;
}

double GetLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
	double Line = Math.Sqrt((Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)));
    return Line;
}
