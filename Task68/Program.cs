Console.Write("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(acher(m,n));

int acher(int n,int m)
{
    if (n==0) return m+1;
    if ((n!=0)&&(m==0))
    return acher(n-1,1);
    return acher(n-1,acher(n,m-1));
}
