using System.ComponentModel.Design;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.Tendo como dados de entrada a altura e o sexo de uma pessoa,
            // construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
            // .Para homens: (72.7 * h) - 58
            // a.Para mulheres: (62.1 * h) - 44.7(h = altura)
            // b.Peça o peso da pessoa e informe se ela está dentro, acima ou abaixo do peso.

            Console.WriteLine("Informe sua altura");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo");
            string sexo = Console.ReadLine();

            if (sexo == "masculino")
            {
                var pesoIdealHomem = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é de: {pesoIdealHomem}");

            } else if (sexo == "femenino")
            {
                var pesoIdealMulher = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é de: {pesoIdealMulher}");
            }

            Console.WriteLine("Informe seu peso");
            double peso = double.Parse(Console.ReadLine());

        if(peso)
            



        }
    }
}