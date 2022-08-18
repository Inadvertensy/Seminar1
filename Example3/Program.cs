Console.Clear();
Console.WriteLine("Please enter numer");
int number=Convert.ToInt32(Console.ReadLine());
// if (number==3)
// {
// Console.WriteLine("Wednesday");
// }
// else if (number==5) 
// {
//    Console.WriteLine("Friday");
// }
// else
// {
//     Console.WriteLine("Neither");
// }

if (number>=1 && number <=7)
{
switch(number)
{
case 1:
System.Console.WriteLine("Monday"); break;
case 2: System.Console.WriteLine("Tuesday"); break;
case 3: System.Console.WriteLine("Wednesday"); break;
case 4: System.Console.WriteLine("Thursday"); break;
case 5: System.Console.WriteLine("Friday"); break;
case 6: System.Console.WriteLine("Saturday"); break;
case 7: System.Console.WriteLine("Sunday"); break;
default: System.Console.WriteLine("Bad number"); break;
}

}