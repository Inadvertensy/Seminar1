Console.Write("Enter number ");
int number1=Convert.ToInt32(Console.ReadLine());

for (int i=2; i<=number1; i+=2)
{
    System.Console.Write(i+" ");
}

Console.WriteLine ("new cycle");

for (int i=1;i<=number1; ++i)
{
    if (i%2==0) System.Console.Write(i+" ");
}

System.Console.WriteLine($"number1{number1++}");
