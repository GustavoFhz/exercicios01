using System.Net.Http.Headers;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.

            Console.WriteLine("Informe a nota 1 do aluno");
            double n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 2 do aluno");
            double n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 3 do aluno");
            double n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 4 do aluno");
            double n4 = int.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"A média do aluno foi: {media}");
        }
    }
}