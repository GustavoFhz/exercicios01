namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11.Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
            // a.o produto do dobro do primeiro com metade do segundo.
            // b.a soma do triplo do primeiro com o terceiro.
            // c.o terceiro elevado ao cubo.

            Console.WriteLine("Informe 2 números inteiros");
            int inteiro1 = int.Parse(Console.ReadLine());
            int inteiro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe 1 número real");
            double real = double.Parse(Console.ReadLine());

            var a = (inteiro1 * 2) + (inteiro2 / 2);
            var b = (inteiro1 * 3) + real;
            var c = Math.Pow(real, 3);

            Console.WriteLine($"A. o produto do dobro do primeiro com metade do segundo é igual a {a}");
            Console.WriteLine($"B.a soma do triplo do primeiro com o terceiro é igual a {b}");
            Console.WriteLine($"C.o terceiro elevado ao cubo é igual a {c}");


        }
    }
}