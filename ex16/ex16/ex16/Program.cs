namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados
            // da área a ser pintada.Considere que a
            // cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a
            // tinta é vendida em latas de 18 litros, que custam R$ 80,00.Informe ao
            // usuário a quantidades de latas de tinta a serem compradas e o preço total.

            Console.WriteLine("Informe o tamanho em metros quadrados da área a ser pintada");
            double tamanhoArea = double.Parse(Console.ReadLine());



            double litrosDeTinta = tamanhoArea / 3;
            int latasDeTinta = (int)Math.Ceiling(litrosDeTinta) / 18;
            double precoTotal = latasDeTinta * 80;

            

            Console.WriteLine($"Você precisará comprar {latasDeTinta}");
            Console.WriteLine($"O preço total das latas é de {precoTotal}");

        }
    }
}