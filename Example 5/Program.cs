Console.WriteLine("Enter number");

int number=Convert.ToInt32(Console.ReadLine());

if (((number/100)>0) && ((number/1000)<1) ){
int lastNumber=number%10;
Console.WriteLine("Last number:   " + lastNumber);
}
else {
    Console.WriteLine("Bad Number");

}