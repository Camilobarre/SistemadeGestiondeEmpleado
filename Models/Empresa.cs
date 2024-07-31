using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Sistema_Gestion_Empleados.Models;
public class Empresa
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public static List<Empleado> ListaEmpleados = new List<Empleado>();

    public Empresa(string nombre, string direccion)
    {
        this.Nombre = nombre;
        this.Direccion = direccion;
    }
    public static Empleado PedirDatosEmpleado()
    {
        Console.WriteLine("Ingresa los datos del Empleado");

        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.Write("Apellido:");
        string? apellido = Console.ReadLine();

        Console.Write("Número de Identificación:");
        string? numeroDeIdentificacion = Console.ReadLine();

        Console.Write("Edad");
        byte edad = byte.Parse(Console.ReadLine());

        Console.Write("Posición:");
        string? posicion = Console.ReadLine();

        Console.Write("Salario");
        double salario = double.Parse(Console.ReadLine());

        return new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario);
    }

    public static void AgregarEmpleado()
    {
        Empleado empleado = PedirDatosEmpleado();
        ListaEmpleados.Add(empleado);
        Console.WriteLine("Empleado agregado correctamente");
    }
}