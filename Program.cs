using System;
using System.Globalization;
using EmployeeSalary;

namespace SalaryWorkersIncrease
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeData workerInfo = new EmployeeData();

            Console.Write("Nome: ");
            workerInfo.Name = Console.ReadLine()!;

            Console.Write("Salário Bruto: ");
            workerInfo.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            workerInfo.Tax = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {workerInfo}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double increaseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            // Aplica o Aumento
            workerInfo.ApplyIncrease(increaseSalary);

            // Dados Atualizado
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {workerInfo}");

        }
    }
}