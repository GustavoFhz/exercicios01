namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7.Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.

            Console.WriteLine("Informe a altura ou a base do quadrado:");
            double alturaOuBase = double.Parse(Console.ReadLine());

            double areaQuadrado = Math.Pow(alturaOuBase, 2);

            Console.WriteLine($"A área de um quadrado é {areaQuadrado}cm2 e o dobro de sua area é {areaQuadrado * 2}cm2");
        }
    }
}