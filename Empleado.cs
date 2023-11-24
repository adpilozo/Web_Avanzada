using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public double salario { get; set; }

        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public double CalcularSalarioAnual()
        {
            return salario * 12;
        }
    }
}
