using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LeitorDadosFuncionario {
    class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiq() {
            return Salario - Imposto;
        }
        public void Aumento(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100); 
        }
        public override string ToString() {
            return Nome + ", R$ " + SalarioLiq().ToString("F2", CultureInfo.InvariantCulture);
               ;
        }
    }
}
