// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Lecture11_2;


try
{
    Person p = new Person("f", "l", new DateTime(1995, 1, 12));

    Console.WriteLine(p.FirstName);

    //int age = p.Age;
    p.FirstName = "jaaaaaaa";

    Console.WriteLine(p.FirstName);
}
catch (InvalidLengthException e)
{
    Console.WriteLine(e.Info);
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Finally Block");
}

