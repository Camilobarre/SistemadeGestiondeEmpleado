using POO_Sistema_Gestion_Empleados.Models;

Console.Clear();
var bandera = true;

while (bandera)
{
    Empresa.ImprimirMenu();
    var opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 0:
            // Salir del programa
            Console.WriteLine("Hasta luego, vuelva pronto!");
            bandera = false;
            break;
        case 1:
            // Agregar Empleado
            Empresa.AgregarEmpleado();
            Empresa.PausarMenu();
            break;
        case 2:
            // Mostrar Empleado
            Empresa.MostrarEmpleado();
            Empresa.PausarMenu();
            break;
        case 3:
            // Mostrar Empleado por cargo
            Empresa.MostrarEmpleadoPorCargo();
            Empresa.PausarMenu();
            break;
        case 4:
            // Actualizar Empleado
            Empresa.ActualizarEmpleado();
            Empresa.PausarMenu();
            break;
        case 5:
            // Eliminar Empleado
            Empresa.Eliminarempleado();
            Empresa.PausarMenu();
            break;
        default:
            // Opción no válidas
            Console.WriteLine("Opción inválida, intente nuevamente.");
            break;
    }
}