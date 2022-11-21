Console.WriteLine("Zadacha 19");

void Zadacha19()

{
    //Задача 19: Напишите программу, которая принимает на вход пятизначное
    // число и проверяет, является ли оно палиндромом.

    Random rand = new Random();
    int number;
    number = rand.Next(10000, 100000);
    Console.WriteLine(number);
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == (number % 100) / 10))
        Console.WriteLine("число-палиндром");
    else
        Console.WriteLine("число не является палиндромом");
}

Zadacha19();

Console.WriteLine("Zadacha 21");

void Zadacha21()
{   // Напишите программу, которая принимает на вход координаты 
    //двух точек и находит расстояние между ними в 3D пространстве.
    Random rand = new Random();
    int x = rand.Next(-10, 11);
    int y = rand.Next(-10, 11);
    int z = rand.Next(-10, 11);
    Console.WriteLine($"A({x}, {y}, {z})");
    int x1 = rand.Next(-10, 11);
    int y1 = rand.Next(-10, 11);
    int z1 = rand.Next(-10, 11);
    Console.WriteLine($"B({x1}, {y1}, {z1})");
    double resalt = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));

    Console.WriteLine($"Расстояние = {Math.Round(resalt, 2)}");
    
}
Zadacha21();

Console.WriteLine("Zadacha 23");

void Zadacha23()
{
    //Задача 23: Напишите программу, которая принимает на вход 
    //число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("Введите число:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++)
        Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
}

Zadacha23();
    
