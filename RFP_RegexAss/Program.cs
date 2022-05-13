// See https://aka.ms/new-console-template for more information
using RFP_RegexAss;

Console.WriteLine("User Registration");
Console.WriteLine( );

Pattern patterns = new Pattern();
Console.WriteLine(patterns.validateFirstName("Komal"));
Console.WriteLine(patterns.validateLastName("Vairagade"));
Console.WriteLine( );

Console.WriteLine(patterns.validateEmail("abc@yahoo.com"));
Console.WriteLine(patterns.validateEmail("abc-100@yahoo.com"));
Console.WriteLine(patterns.validateEmail("abc.100@yahoo.com"));
Console.WriteLine(patterns.validateEmail("abc111@abc.com"));
Console.WriteLine(patterns.validateEmail("abc-100@abc.net"));
Console.WriteLine(patterns.validateEmail("abc.100@abc.com.au"));
Console.WriteLine(patterns.validateEmail("abc@gmail.com.com"));
Console.WriteLine(patterns.validateEmail("abc+100@yahoo.com"));
Console.WriteLine( );

Console.WriteLine(patterns.validatePhonNo("91 8788254798"));
Console.WriteLine(patterns.validatePassword("Bridge001labz@"));