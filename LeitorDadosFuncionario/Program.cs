using System;
using System.Globalization;
namespace LeitorDadosFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();
            Console.Write("Nome:");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "  + func.Nome + ", $" + func.SalarioLiq().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário:" );
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.Aumento(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
