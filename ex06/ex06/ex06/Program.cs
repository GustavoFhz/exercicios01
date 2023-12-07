namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

            Console.WriteLine("Informe o raio de um círculo:");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"A area é igual a {area}");
        }
    }
}