namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Farenheit.

            Console.WriteLine("Informe a temperatura em Celcius");
            double c = double.Parse(Console.ReadLine());

            double conversao = (c * 1.8) + 32;

            Console.WriteLine($"A temperatura em Farenheit é de {conversao}");


        }
    }
}