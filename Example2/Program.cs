Console.Clear();

Console.WriteLine("Please enter value 1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter value 2");
int number2=Convert.ToInt32(Console.ReadLine());


int squareNumber2=number2*number2;
//Console.WriteLine(squareNumber2);


if (number1==squareNumber2)
{
    Console.WriteLine("yes");
}
else {
    
    Console.WriteLine("no");
}