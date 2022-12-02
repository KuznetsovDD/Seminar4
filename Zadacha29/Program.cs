// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

int []array = new int[8];

void FillArray(int [] arry)
{
    for(int i=0; i<arry.Length; i++)
    {
        arry[i]= new Random().Next(0,100);
    }
}
void PrintArry(int [] arr)
{
    for(int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
FillArray(array);
PrintArry(array);

