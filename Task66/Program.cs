Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int n = Convert.ToInt32(Console.ReadLine());
if (m>n)
{(m,n)=(n,m);}
int sum(int m, int n)
{
    if (m==n) return n;
    return m+ sum((m+1),n);
}
sum (m,n);
Console.WriteLine(sum (m,n));