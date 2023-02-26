Console.Clear();
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());
Console.Write($"Сумма чисел {x} = {GetSum(x)}");

int GetSum(int x)
{
   
        int sum = 0;
        while (x > 0)
        {
            sum += x%10;
            x = x/10;
        }
        return sum;
}