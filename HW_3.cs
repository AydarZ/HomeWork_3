// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Знаю, что можно и проще, просто хотелось внедрить массив))

// System.Console.WriteLine("Введите пятизначное число");
// int arrayInOneNumber = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [5];
// if (arrayInOneNumber/10000 == 0 || arrayInOneNumber/10000 > 9)
    // {
    //     Console.WriteLine("Вы ввели число, которое не соответствует условиям");
    // return;
    // }
//   int degree = 4;
//  for (int i = 0; i < array.Length; i++)
    //  {
    //     array [i] = arrayInOneNumber/(int)Math.Pow(10, degree);
    //     arrayInOneNumber=arrayInOneNumber%(int)Math.Pow(10, degree);
    //     degree = degree - 1; 
    //  }
// if (array[0] == array [4] && array[1] == array [3])
    // {
    //     System.Console.WriteLine("да, число является палиндромом");
    // }
// else
    // {
    //     System.Console.WriteLine("нет, число не является палиндромом");
    // }



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Тут тоже намудрил, но работает))

// double X;
// double Y;
// double Z;
// string A = "A";
// string B = "B";
// void DataInput (string DotName)
// {
// Console.WriteLine("Введите координаты точки " + DotName);
// Console.WriteLine(DotName + "x:");
// X = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(DotName + "y:");
// Y = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(DotName + "z:");
// Z = Convert.ToDouble(Console.ReadLine());
// }
// DataInput (A);
// double Ax = X;
// double Ay = Y;
// double Az = Z;
// DataInput (B);
// double Bx = X;
// double By = Y;
// double Bz = Z;
// Console.WriteLine("Расстояние между точками равняется " + Math.Round(Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2)),2));


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string TableCube (int N)
{
    string answer = string.Empty;
    for (int i=1; i<=N; i++)
    {
        answer += Math.Pow(i,3).ToString() + ", ";
    }
    return answer;
}
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(TableCube(n));
