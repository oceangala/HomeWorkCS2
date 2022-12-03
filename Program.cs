// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// void Second(int num)
// {
//     int sec = (num % 100) / 10;
//     Console.WriteLine("Вторая цифра вашего числа " + sec);
// }

// Console.WriteLine("Введите трёхзначное число ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (100 > a || a > 999) { Console.WriteLine("Число не является трёхзначным"); }
// else     Second(a);





//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// void Third(int num)
// {
//     int res = num;
    
//     while (res > 999)
//         {
//         res = res / 10;
//          }

//     int third = res%10;
//     Console.WriteLine("Третья цифра вашего числа " + third);
// }

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a < 100) Console.WriteLine("Третьей цифры нет");
// else Third(a);




//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Day(int day)
{
    if(day<6) Console.WriteLine("Придется поработать");
    else Console.WriteLine("Выходной!");
}

Console.WriteLine("Введите цифру, обозначающую день недели ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7) Console.WriteLine("Только цифры от 1 до 7! Пробуй еще раз ");
else Day(a);
