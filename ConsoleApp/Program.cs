// See https://aka.ms/new-console-template for more information
using Length;
Console.WriteLine("Hello, World!");


    Console.Write("Enter a string : ");
    string str = Console.ReadLine();
    LengthHelper lp = new LengthHelper();
    Console.WriteLine("Length of the string is : " + lp.findLength(str));
    Console.ReadKey();
