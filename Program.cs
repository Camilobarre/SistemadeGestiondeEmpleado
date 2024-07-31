using POO_Sistema_Gestion_Empleados.Models;

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
            Empresa.PedirDatosEmpleado();
            Empresa.AgregarEmpleado();
            Empresa.PausarMenu();
            break;
        case 2:
            // Mostrar Empleado
            Empresa.MostrarEmpleadoPorCargo();
            Empresa.PausarMenu();
            break;
        case 3:
            // Actualizar Empleado
            Empresa.ActualizarEmpleado();
            Empresa.PausarMenu();
            break;
        case 4:
            // Eliminar Empleado
            Empresa.Eliminarempleado();
            Empresa.PausarMenu();
            break;
        default:
            Console.WriteLine("Opción inválida, intente nuevamente.");
            break;
    }
}