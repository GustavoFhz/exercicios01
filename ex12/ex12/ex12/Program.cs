namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12.Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal,
            // usando a seguinte fórmula: (72.7 * altura) - 58

            Console.WriteLine("Calculo de IMC: ");
            Console.WriteLine("Informe sua altura");
            double altura = double.Parse(Console.ReadLine());

            double imc = (72.7 * altura) - 58;

            Console.WriteLine($"O seu IMC é de: {imc}");
        }
    }
}