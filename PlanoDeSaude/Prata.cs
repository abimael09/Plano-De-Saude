using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanoDeSaude
{
    class Prata : PlanoDeSaude
    {
        // Atributos
        private double descontos;
        // Constrututores: vazio e cheio

        // Sets e Gets
        public void SetDescontos(double descontos)
        {
            this.descontos = descontos;
        }
        public double GetDescontos()
        {
            return descontos;
        }
        // Métodos
        public void AdicionaDados(string nomeSegurado, string matricula, int numDependentes, string ano, double valor)
        {
            this.SetNomeSegurado(nomeSegurado);
            this.matricula = matricula;
            this.numDependentes = numDependentes;
            this.ano = ano;
            this.SetValor(valor);
            this.SetDescontos(descontos);
        }
    }
}
