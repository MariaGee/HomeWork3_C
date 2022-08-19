//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27     5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());
double count = 1;

for(int i = 1; i <= number; i++)
{
    count = Math.Pow(i, 3);
    Console.Write(count + "  ");
}
