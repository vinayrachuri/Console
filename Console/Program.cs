// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello c#");

Console.WriteLine("enter your age");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("you are too young ");
}
 else if(age>65)
 {
    Console.WriteLine("sorry your not eligible");
   }
else
{
  Console.WriteLine("Greate you can start your application");
}






//Console.WriteLine("Enter a first number:");
//string stringValue1 = Console.ReadLine();
//Console.WriteLine("Enter a second number:");
//string stringValue2 = Console.ReadLine();

//int intValue1 = int.Parse(stringValue1);
//int intValue2 = int.Parse(stringValue2);

//if (intValue1 == intValue2)
//{
//    Console.WriteLine("The values are equal!");
//}
//else if (intValue1 < intValue2)
//{
//    Console.WriteLine("The first value is smaller!");
//}
//else
//{
//    Console.WriteLine("The second value is smaller!");
//}



switch (age)
{
    case < 18:
        Console.WriteLine("you are too young ");
        break;
    case > 65:
        Console.WriteLine("sorry your not eligible");
        break;
    default: Console.WriteLine("You can apply for this job");
        break;
}