namespace AppConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Prueba persona = new Prueba(32,"Rodrigo");

            Console.WriteLine($"Hola mi nombre es {persona.Name} y tengo {persona.edad}");





        }
    }
}
