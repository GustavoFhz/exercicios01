namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14.João Papo-de-Pescador, homem de bem, comprou um
             microcomputador para controlar o rendimento diário de seu trabalho.
             Toda vez que ele traz um peso de peixes maior que o estabelecido
             pelo regulamento de pesca do estado de São Paulo (50 quilos) deve
             pagar uma multa de R$ 4,00 por quilo excedente. João precisa que
             você faça um programa que leia a variável peso (peso de peixes) e
             verifique se há excesso. Se houver, gravar na variável excesso e na
             variável multa o valor da multa que João deverá pagar. Caso contrário
             mostrar tais variáveis com o conteúdo ZERO.
            */

            Console.WriteLine("Informe o peso do peixe");
            double pesoPeixe = double.Parse(Console.ReadLine());

            double excesso = pesoPeixe - 50;

            double multa = excesso * 4;

            if(excesso >= 1)
            {
                Console.WriteLine($"Esse peixe teve um excesso de {excesso}KG e terá que pagar uma multa de ${multa}");
            } else
            {
                Console.WriteLine("Esse peixe não teve excesso de peso e não precisará pagar multa");
            }

        }
    }
}