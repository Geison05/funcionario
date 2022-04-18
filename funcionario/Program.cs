using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


           double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário Médio = "+ media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}