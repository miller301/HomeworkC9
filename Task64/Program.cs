Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0)
{
    int all(int n)
    {
        Console.Write($"{(n)} ");
        if (n==1) return n;
        return all(n-1);
    }
    all(n);

}
else
{
Console.WriteLine("Введите положительное число");
}