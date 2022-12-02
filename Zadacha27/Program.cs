// Напишите программу, которая принимает на вход число и вылает суимму чисел в числе

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetNumb(int num)
{
    int result = 0;
    while(num>10)
    {   
        num%=10;
        result+=num;
    }
return result;
}


int result=0;
while(num>0)
{
    if(num<10)
    {
        result+=num;
        break;
    }
    else
    {
        result+=GetNumb(num);
        num/=10;
    }

}
Console.WriteLine(result);
    


 
