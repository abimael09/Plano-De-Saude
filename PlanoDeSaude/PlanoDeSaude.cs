using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanoDeSaude
{
    class PlanoDeSaude
    {
        // Atributos
        private string nomeSegurado;
        public string matricula;
        public int numDependentes;
        public string ano;
        private double valor;

        // Construtores: vazio e cheio
        public PlanoDeSaude()
        {
        }
        public PlanoDeSaude(string nomeSegurado, string matricula, int numDependentes, string ano, double valor)
        {
            this.nomeSegurado = nomeSegurado;
            this.matricula = matricula;
            this.numDependentes = numDependentes;
            this.ano = ano;
            this.valor = valor;
        }
        
        // Métodos Sets e Gets
        public void SetNomeSegurado(string nomeSegurado)
        {
            this.nomeSegurado = nomeSegurado;
        }
        public string GetNomeSegurado()
        {
            return nomeSegurado;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return valor;
        }

    }
}
