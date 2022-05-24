// See https://aka.ms/new-console-template for more information

using LibreriaEvaluacion.DAL;
using LibreriaEvaluacion.DTO;

while (Menu())
{

}


static bool Menu()
{
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
            OpcionListar();
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

    return continuar;
}

static void OpcionInsertar()
{
    PrendaDAL prendaDal = new PrendaDAL(); // Se llama a la capa de acceso a datos

    try
    {
        // Solicitar entrada al usuario
        Console.WriteLine("Ingrese ID:");
        int id = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Ingrese marca:");
        string marca = Console.ReadLine().Trim();

        Console.WriteLine("Ingrese talla");
        string talla = Console.ReadLine().Trim();

        Console.WriteLine("Ingrese precio:");
        int precio = int.Parse(Console.ReadLine().Trim());

        // Crear el nuevo objeto a insertar
        PrendaDTO nuevaPrenda = new PrendaDTO()
        {
            Id = id,
            Marca = marca,
            Precio = precio,
            Talla = talla
        };

        bool resultadoInsertar = prendaDal.Insertar(nuevaPrenda); // Insertar y obtener resultado

        // Verificamos si el resultado fue correcto o no
        if (resultadoInsertar)
        {
            Console.WriteLine($"Se ha insertado la prenda marca {nuevaPrenda.Marca} exitosamente");
        } 
        else
        {
            Console.WriteLine($"Hubo un error al insertar la prenda {nuevaPrenda.Marca}");
        }

    } catch (Exception ex)
    {
        Console.WriteLine($"Por favor ingrese datos válidos para la nueva prenda");
    }

    Console.ReadKey(); // Pausa para poder observar el resultado de la operación
}

static void OpcionActualizar()
{

}

static void OpcionEliminar()
{
    PrendaDAL prendaDAL = new PrendaDAL();

    Console.WriteLine("Ingrese el ID que desea eliminar:");
    int id = int.Parse(Console.ReadLine().Trim());

    bool resultadoEliminacion = prendaDAL.Eliminar(id); // intento de eliminación
    
    if (resultadoEliminacion)
    {
        Console.WriteLine("Se ha eliminado la prenda");
    } 
    else
    {
        Console.WriteLine("No se ha podido eliminar la prenda, revise el ID ingresado");
    }

    Console.ReadKey();
}

static void OpcionListar()
{
    PrendaDAL prendaDAL = new PrendaDAL();
    List<PrendaDTO> datosLista = prendaDAL.Listar();

    foreach (PrendaDTO dato in datosLista)
    {
        Console.WriteLine(dato.ToString());
        //Console.WriteLine($"Id: {dato.Id}, Marca: {dato.Marca}, Talla: {dato.Talla}, Precio: {dato.Precio}");
    }

    Console.ReadKey();

}