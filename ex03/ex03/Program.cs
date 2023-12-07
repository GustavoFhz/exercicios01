namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Faça um Programa que peça dois números e imprima a soma

            Console.WriteLine("Informe o valor 1");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma do valor 1 e valor 2 é {valor1+valor2}");

        }
    }
}