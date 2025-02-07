int n = int.Parse(Console.ReadLine());

int sum = 0;
int temp = n;

while (n > 0)
{
    int r = n % 10;
    sum = (sum * 10) + r;
    n = n / 10;
}
if (temp == sum)
{
    Console.WriteLine("so");
}
else
    Console.WriteLine("so khong doi xung");
