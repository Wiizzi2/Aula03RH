using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.Models.Enuns;

namespace Aula03.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public DateTime AdmissionDate { get; set; }

        public decimal Salary { get; set; }

        public TipoFuncionarioEnum EmployeeType { get; set; }

        public void AdjustSalary()
        {
            Salary = Salary + (Salary * 10 / 100);
        }

        public string DisplayProbationPeriod()
        {
            string ProbationPeriod =
            String.Format("Periodos de Experiencia: {0} até {1}", AdmissionDate, AdmissionDate.AddMonths(3));
            return ProbationPeriod;   
        }

        public decimal CalculateVTDiscount(decimal percentual)
        {
            decimal descont = Salary * percentual/100;
            return descont;
        }

    }
}