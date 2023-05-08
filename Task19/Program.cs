// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число:");
// double num = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine(num % 10);

// if ((Math.Floor(num / 10000) == num % 10) && (Math.Floor(num / 1000) % 10) == Math.Floor(num % 100 / 10))
// {
//     Console.WriteLine("Введенное число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Введенное число не является палиндромом");
// } 


Console.Write("Введите число для проверки палиндрома: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0, result = 0;

// if(num < 100000 && num > 10000)
// {
result = num % 100;
while(num > 100)
{
    num = num / 10;
}
temp = num / 10;
num = num % 10;
temp = num * 10 + temp;
if(temp == result){
    Console.WriteLine("Палиндром");
}
else Console.WriteLine("Не палиндром");
// }
// else Console.WriteLine("Введите пятизначное число");