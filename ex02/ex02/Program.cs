namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Faça um Programa que peça um número e então mostre a mensagem O número informado foi[número].

            Console.WriteLine("Informe um número");

            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"O número informado foi: {numero}");

        }
    }
}