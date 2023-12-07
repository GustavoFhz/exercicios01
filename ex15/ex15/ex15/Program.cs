namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
              5.Faça um Programa que pergunte quanto você ganha por hora e o
               número de horas trabalhadas no mês. Calcule e mostre o total do seu
               salário no referido mês, sabendo-se que são descontados 11% para o
               Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um
               programa que nos dê:
               . salário bruto.
               a. quanto pagou ao INSS.
               b. quanto pagou ao sindicato.
               c. o salário líquido.
               d. calcule os descontos e o salário líquido, conforme a tabela
               abaixo:
               + Salário Bruto : R$ - IR (11%) : R$ - INSS
               (8%) : R$ - Sindicato ( 5%) : R$ = Salário
               Liquido : R$
               Obs.: Salário Bruto - Descontos = Salário Líquido.
             
             */

            Console.WriteLine("Quanto vc ganha por hora");
            double salarioHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas vc trabalha no mês?");
            double horasTrabalhada = double.Parse(Console.ReadLine());

            double salario = salarioHora * horasTrabalhada;
            double ir = salario * 0.11;
            double inss = salario * 0.08;
            double sindicato = salario * 0.05;

            double salarioBruto = salarioHora * horasTrabalhada;
            double desconto = ir + inss + sindicato;          
            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"Salário Bruto: {salarioBruto}");
            Console.WriteLine($"IR: {ir}");
            Console.WriteLine($"Inss: {inss}");
            Console.WriteLine($"Sindicato: {sindicato}");
            Console.WriteLine($"Salário Liquido: {salarioLiquido}");




        }
    }
}