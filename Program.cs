

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 15;
            string Frase = "Este é o resultado da equação";
            Console.WriteLine(Frase + " : " + (Number + 15));
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
        }
    }
}