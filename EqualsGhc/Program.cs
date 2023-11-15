using EqualsGhc.Classes;
internal class Program
 
{
    private static void Main(string[] args)
    {

        Cliente a = new Cliente {Nome = "Maria", Email = "alex@gmail.com" };

        Cliente b = new Cliente { Nome = "Maria", Email = "alex@gmail.com" };


        Console.WriteLine(a.Equals(b));
        
        Console.WriteLine(a.GetHashCode());

        Console.WriteLine(b.GetHashCode());
    }
}