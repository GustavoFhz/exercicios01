namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do arquivo em MB");
            double arquivoMB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade do link de internet em Mbps");
            double velocidadeLink = double.Parse(Console.ReadLine());

            double calculo = arquivoMB / velocidadeLink;
            

            Console.WriteLine($"A velocidade de download é de {calculo} minutos");
        }
    }
}