void Zadacha19()
{
    //Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    //является ли оно палиндромом.

    Console.WriteLine("Введите 5 значное число: ");
    string? number = Console.ReadLine();

    void Jesnumber(string number)
    {
        if (number[0] == number[4] || number[1] == number[3])
        {
            Console.WriteLine($"Ваше число: {number} - палиндром.");
        }
        else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }

    if (number!.Length == 5)
    {
        Jesnumber(number);
    }
    else Console.WriteLine($"Введи правильное число");
}

void Zadacha21()
{
    //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
    //находит расстояние между ними в 3D пространстве.

    Random random = new Random();
    int x1 = random.Next(-10, 11);
    int y1 = random.Next(-10, 11);
    int z1 = random.Next(-10, 11);
    int x2 = random.Next(-10, 11);
    int y2 = random.Next(-10, 11);
    int z2 = random.Next(-10, 11);
    Console.WriteLine($"Первая точка с координатами ({x1}, {y1}, {z1})\nВторая точка с координатами ({x2}, {y2}, {z2})");

    int result = (int)Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), +Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние между точками {result}");
}

void Zadacha23()
{
    //Задача 23. Напишите программу, которая принимает на вход число (N) и 
    //выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("Введите чисдо: ");
    int numberC = Convert.ToInt32(Console.ReadLine());

    int num = 0;
    while (numberC != num)
    {
        num += 1;
        Console.WriteLine(Math.Pow(num, 3));
    }
}

Zadacha19();
//Zadacha21();
//Zadacha23();