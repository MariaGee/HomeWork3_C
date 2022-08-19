//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84       A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int[3];
int[] B = new int[3];
double result = 0;

for (int i = 0; i < A.Length; i++)
{
    Console.WriteLine("Введите, пожалуйста, " + (i + 1) + " координату точки A");
    A[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < B.Length; i++)
{
    Console.WriteLine("Введите, пожалуйста, " + (i + 1) + " координату точки B");
    B[i] = Convert.ToInt32(Console.ReadLine());
}

double Decision(int[] arr1, int[] arr2)
{
    double res = 0;
    double square = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        square = Math.Pow((arr2[i] - arr1[i]), 2);
        Console.WriteLine(square);
        res = res + square;
    }
    res = Math.Sqrt(res);
    return res;
}

result = Decision(A, B);
Console.WriteLine("Расстояние между двумя заданными точками = " + result);