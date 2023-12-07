namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8.Faça um Programa que pergunte quanto você ganha por hora e o
            // número de horas trabalhadas no mês.Calcule e mostre o total do seu salário no referido mês.

            Console.WriteLine("Quanto vc ganha por hora?");
            double saldoHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas vc trabalha por mês?");
            double horasTrabalhadas = double.Parse(Console.ReadLine());

            double salario = saldoHora * horasTrabalhadas;

            Console.WriteLine($"O seu salário no referido mês foi de: {salario} reais");
            
        }
    }
}