namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9.Faça um Programa que peça a temperatura em graus Farenheit,
            // transforme e mostre a temperatura em graus Celsius. o C = (5 * (F - 32) / 9).

            Console.WriteLine("Informe a temperatura em Farenheit");
            double f = double.Parse(Console.ReadLine());

            double convercao = (5 * (f - 32) / 9);

            Console.WriteLine($"A temperatura em Celcius é de {convercao}C");
        }
    }
}