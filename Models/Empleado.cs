using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Sistema_Gestion_Empleados.Models;
public class Empleado
{
    public Guid Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string? Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(
    string nombre,
    string apellido,
    string numeroDeIdentificacion,
    byte edad,
    string posicion,
    double salario)
    {
        this.Id = Guid.NewGuid();
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.NumeroDeIdentificacion = numeroDeIdentificacion;
        this.Edad = edad;
        this.Posicion = posicion;
        this.Salario = salario;
    }
}