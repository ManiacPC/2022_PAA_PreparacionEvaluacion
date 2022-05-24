// See https://aka.ms/new-console-template for more information

using LibreriaEvaluacion.DAL;

while (Menu())
{

}


static bool Menu()
{
    return false; // ToDo: Temporal

    bool continuar = true;

    Console.Clear();
    Console.Title = "Preparación de evaluación";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1. Listar prendas");
    Console.WriteLine("2. Añadir prendas");
    Console.WriteLine("3. Actualizar datos de prenda");
    Console.WriteLine("4. Eliminar prenda");
    Console.WriteLine("\n");
    Console.WriteLine("0. Salir");
    

    string opcion = Console.ReadLine().Trim();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de prendas registradas");
            OpcionInsertar();
            break;
        case "2":
            Console.WriteLine("Añadir una nueva prenda");
            OpcionInsertar();
            break;
        case "3":
            Console.WriteLine("Actualizar datos de prenda");
            OpcionActualizar();
            break;
        case "4":
            Console.WriteLine("Eliminar prenda");
            OpcionEliminar();
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Por favor seleccione una opción válida");
            break;
    }

}

static void OpcionInsertar()
{
    PrendaDAL prendaDal = new PrendaDAL();
    
}

static void OpcionActualizar()
{

}

static void OpcionEliminar()
{

}

static void OpcionListar()
{

}