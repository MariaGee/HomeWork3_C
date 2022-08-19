//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет      12821 -> да     23432 -> да

Console.WriteLine("Введите, пожалуйста, пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
while (number.Length != 5) 
{
    Console.WriteLine("Вы ввели не пятизначное число. Введите пятизначное число: ");
    number = Convert.ToString(Console.ReadLine());
}

if ((number[0] == number[4]) & (number[1] == number[3])) Console.WriteLine("Данное число является палиндромом");
else Console.WriteLine("Данное число не является палиндромом");
