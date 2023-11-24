using POO;
using System;

class Program
{
    static void Main()
    {
        // Pedir datos para Empleado
        Console.Write("Ingrese el nombre del empleado: ");
        string nombreEmpleado = Console.ReadLine();

        Console.Write("Ingrese el salario del empleado: ");
        double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

        // Crear objeto Empleado
        Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

        // Pedir datos adicionales para Gerente
        Console.Write("Ingrese el nombre del gerente: ");
        string nombreGerente = Console.ReadLine();

        Console.Write("Ingrese el salario del gerente: ");
        double salarioGerente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el departamento del gerente: ");
        string departamentoGerente = Console.ReadLine();

        // Crear objeto Gerente
        Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);

        // Mostrar resultados
        Console.WriteLine("\nDatos del Empleado:");
        Console.WriteLine($"Nombre: {empleado.nombre}");
        Console.WriteLine($"Salario Anual: {empleado.CalcularSalarioAnual()}");

        Console.WriteLine("\nDatos del Gerente:");
        Console.WriteLine($"Nombre: {gerente.nombre}");
        Console.WriteLine($"Salario Anual: {gerente.CalcularSalarioAnual()}");
        Console.WriteLine($"Departamento: {gerente.departamento}");
    }
}
