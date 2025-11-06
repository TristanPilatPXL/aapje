namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leeftijd = GeefLeeftijd();
            ToonLeeftijd(leeftijd);
            Console.WriteLine("Druk op een toets om af te sluiten...");


        }

        static int GeefLeeftijd()
        {
            Console.WriteLine("Wat is je leeftijd: ")
            int leeftijd = Console.ReadLine();
        }
    }
}
