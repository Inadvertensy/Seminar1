Console.WriteLine("Enter Number");
int number=Convert.ToInt32(Console.ReadLine());
int number2=-number;
while(number2<=number){
    //Console.WriteLine($"{number2},")
    Console.WriteLine(number2+",");
    ++number2;
}

