using System;
using Aula03.Models;

namespace Aula03
{
    public class Program
    {
        static void Main(string [] args)
        {
            Funcionario funcionary = new Funcionario();
            funcionary.Id = 10;
            funcionary.Name = "Messi";
            funcionary.Cpf = "12345678901";
            funcionary.AdmissionDate = DateTime.Parse("16/03/2023");
            funcionary.Salary = 2600.00M;
            funcionary.EmployeeType = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = funcionary.DisplayProbationPeriod();
            Console.WriteLine(mensagem);
        }
    }
}