using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Gerente : Empleado
    {
        public string departamento { get; set; }
        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            this.departamento = departamento;
        }

    }
}
