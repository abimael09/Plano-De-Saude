using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanoDeSaude
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando Classe Diamante e criando objeto ps1
            Diamante ps1 = new Diamante();
            ps1.SetNomeSegurado("Abimael");
            ps1.matricula = "2123213";
            ps1.numDependentes = 2;
            ps1.SetValor(500);
            ps1.ano = "2017";
            ps1.SetAdicional(2);
            ps1.idade = 23;
            double result = ps1.CalculaPagamento();
            ps1.MostraDados();

            Console.WriteLine("-----------------------------final do ps1-----------------------------");

            Diamante ps2 = new Diamante();
            ps2.InserirDados("Carla", 2, 400, 2, 40);
            ps2.ano = "2016";
            ps2.matricula = "231";
            double calculo = ps2.CalculaPagamento();
            ps2.MostraDados();
            Console.WriteLine("Nome = " + ps2.GetNomeSegurado());
            Console.WriteLine("Valor do plano = " + ps2.GetValor());

            Console.ReadKey();
        }
    }
}
