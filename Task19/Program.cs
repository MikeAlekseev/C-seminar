// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

// int Palindrome(int num)
// {
//     int num1 = (num / 10000) % 10;
//     int num2 = (num / 1000) % 10;
//     int num4 = (num / 10) % 10;
//     int num5 = num % 10;
//     if (num > 9999 && num < 100000)
//     {
//         if (num1 == num5 && num2 == num4)
//         {
//             Console.WriteLine($"Это он");
//         }
//         else
//         {
//             Console.WriteLine($"Это не он");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Некорректное число");
//     }
//      return num;
// }
//  Palindrome(number);
// Это мой охренительный код, жаль что не подошел

if (number > 9999 && number < 100000) 
{ 
  if (Palindrome(number)) 
  { 
    Console.WriteLine($"Это он"); 
  } 
  else 
  { 
    Console.WriteLine($"Это не он"); 
  } 
} 
else if(number < 0)
{
    Console.WriteLine($"Отрицательное число");
}
else 
{ 
  Console.WriteLine($"Некорректное число"); 
}

bool Palindrome(int num) 
{ 
    int num1 = (num / 10000) % 10; 
    int num2 = (num / 1000) % 10; 
    int num4 = (num / 10) % 10; 
    int num5 = num % 10; 
  if (num1 == num5 && num2 == num4) 
  { 
    return true;
  } 
  else 
  { 
    return false;
  } 
} 
