using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace POO_Sistema_Gestion_Empleados.Models;
public class Empresa
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public static List<Empleado> ListaEmpleados = new List<Empleado>();

    //Constructor
    public Empresa(
        string nombre,
        string direccion)
    {
        this.Nombre = nombre;
        this.Direccion = direccion;
    }
    //Método para pedir datos al usuario
    public static Empleado PedirDatosEmpleado()
    {
        Console.WriteLine("Ingresa los datos del Empleado");

        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string? apellido = Console.ReadLine();

        Console.Write("Número de Identificación: ");
        string? numeroDeIdentificacion = Console.ReadLine();

        Console.Write("Edad: ");
        byte edad = byte.Parse(Console.ReadLine());

        Console.Write("Posición: ");
        string? posicion = Console.ReadLine();

        Console.Write("Salario: ");
        double salario = double.Parse(Console.ReadLine());

        return new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario);
    }

    //Método para agregar un empleado nuevo
    public static void AgregarEmpleado()
    {
        Empleado empleado = PedirDatosEmpleado();
        ListaEmpleados.Add(empleado);
        Console.WriteLine("Empleado agregado correctamente");
    }

    //Método para elimianr un empleado
    public static void Eliminarempleado()
    {
        Console.WriteLine("Ingresa el número de identificación del empleado que deseas eliminar");
        string? numeroDeIdentificacion = Console.ReadLine().Trim();
        Empleado? empleadoAEliminar = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleadoAEliminar != null)
        {
            ListaEmpleados.Remove(empleadoAEliminar);
            Console.WriteLine("Empleado eliminado correctamente");
        }
        else
        {
            Console.WriteLine("No se encontró un empleado con ese número de identificación");
        }
    }

    //Método para actualizar un empleado
    public static void ActualizarEmpleado()
    {
        Console.WriteLine("Ingresa el número de identificación del empleado que deseas eliminar");
        string? numeroDeIdentificacion = Console.ReadLine().Trim();
        Empleado? empleadoActualizar = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleadoActualizar != null)
        {
            Console.WriteLine("Ingresa los nuevos datos del empleado");

            Console.Write("Nombre (Deja en blanco para no cambiar):");
            var input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.Nombre = input;

            Console.Write("Apellido (Deja en blanco para no cambiar):");
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.Apellido = input;

            Console.Write("Número de Identifiación (Deja en blanco para no cambiar):");
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.NumeroDeIdentificacion = input;

            Console.Write("Edad (Deja en blanco para no cambiar):");
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.Edad = byte.Parse(input);

            Console.Write("Posición (Deja en blanco para no cambiar):");
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.Posicion = input;

            Console.Write("Salario (Deja en blanco para no cambiar):");
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input)) empleadoActualizar.Salario = double.Parse(input);
        }
    }

    //Método para buscar un empleado por cédula
    public static Empleado? BuscarEmpleadoPorCedula(string NumeroDeIdentificacion)
    {
        return ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion);
    }

    //Método para mostrar empleados por cargo
    public static void MostrarEmpleadoPorCargo()
    {
        Console.WriteLine("Ingrese la posición del empleado que deseas buscar:");
        string? posicionABuscar = Console.ReadLine().Trim().ToLower();
        List<Empleado> empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion.ToLower() == posicionABuscar).ToList();
        if (empleadosPorCargo.Any())
        {
            Console.WriteLine($"Los empleados con posición {posicionABuscar} son:");
            foreach (var empleado in empleadosPorCargo)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}, " +
                  $"Identificación: {empleado.NumeroDeIdentificacion}, " +
                  $"Edad: {empleado.Edad}, " +
                  $"Posición: {empleado.Posicion}, " +
                  $"Salario: {empleado.Salario:C}");
            }
        }
        else
        {
            Console.WriteLine($"No se encontraron empleados con la posición {posicionABuscar}.");
        }
    }

    //Método para imprimir un menú
    public static void ImprimirMenu()
    {
        Console.WriteLine("==============================================================================");
        Console.WriteLine("                             Gestión de Empleados                             ");
        Console.WriteLine("==============================================================================");
        Console.WriteLine("                             1. Agregar Empleado                              ");
        Console.WriteLine("                             2. Mostrar Empleado                              ");
        Console.WriteLine("                             3. Editar Empleado                               ");
        Console.WriteLine("                             4. Eliminar Empleado                             ");
        Console.WriteLine("                             0. Salir                                         ");
        Console.WriteLine("==============================================================================");
        Console.Write("Selecciona una opción: ");
    }

    //Método para pausar el menú
    public static void PausarMenu()
    {
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }

}