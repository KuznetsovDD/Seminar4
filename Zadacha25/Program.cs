//Напишите  цикл, который принимает на вход 2 числа (А и В ) и возводит число А внатуральную степень В. 

int Exponentiate(int num1, int num2)
{
    int result=1;
    for (int i=1; i<=num2; i++)
    {
        result*=num1;
    }
    return result;
}
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int tgm= Exponentiate(num1, num2);
Console.WriteLine(tgm);



