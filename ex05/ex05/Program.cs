namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Faça um Programa que converta metros para centímetros

            Console.WriteLine("Informe o valor em metros");
            double metro = double.Parse(Console.ReadLine());

            double conversao = metro * 100;

            Console.WriteLine($"O valor de {metro}m para centimetros é igual a {conversao}c");

        }
    }
}