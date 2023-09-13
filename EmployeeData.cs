using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class EmployeeData
    {
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public double Tax { get; set; }

        // Salário Líquido
        public double NetSalary()
        {
            return Salary - Tax;
        }

        // Aplicar Aumento Conforme a Porcentagem Indicada por Parâmetro
        public void ApplyIncrease(double applyIncreaseSalary)
        {
            double increase = Salary * (applyIncreaseSalary / 100);
            Salary += increase;
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
