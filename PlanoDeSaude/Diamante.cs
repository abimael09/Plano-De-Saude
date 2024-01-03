using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanoDeSaude
{
    class Diamante : PlanoDeSaude
    {
        // Atributos
        private double adicional;
        public int idade;
        // Construtores: vazio e cheio
        
        // Sets e Gets
        public void SetAdicional(double adicional)
        {
            this.adicional = adicional;
        }
        public double GetAdicional()
        {
            return adicional;
        }
        // Métodos
        public void InserirDados(string nomeSegurado, int numDependentes, double valor, double adiconal, int idade)
        {
            SetNomeSegurado(nomeSegurado);
            this.numDependentes = numDependentes;
            SetValor(valor);
            SetAdicional(adicional);
            this.idade = idade;
        }
        public double CalculaPagamento()
        {
            double calcula;
            calcula = GetValor() * adicional / 100 + GetValor();
            if (idade > 50)
            {
                calcula = calcula * 3 / 100 + calcula;
            }
            return calcula;
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome segurado = " + GetNomeSegurado());
            Console.WriteLine("Adicional diamante = " + adicional);
            Console.WriteLine("Idade do segurado = " + idade);
        }
    }
}
