using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(53441, "Mariana", 8.56);
        Alumno a2 = new Alumno(1, "Mar", 8);
        Alumno a3 = new Alumno(2, "ariana", 5);
        Alumno a4 = new Alumno(3, "ana", 6);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

    
       casoList.ObtenerLista();
     

        try
        {
            casoList.BuscarAlumnoNombre("Mariana");
            casoList.BuscarAlumnoNombre("Marian");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        casoList.EliminarAlumno(a3);
        casoList.ObtenerLista();


        casoList.EliminarPosicion(0);
        casoList.ObtenerLista();
      


    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

        CasoDictionary casoDictionary = new CasoDictionary();


        Alumno a1 = new Alumno(53441, "Mariana", 8.56);
        Alumno a2 = new Alumno(1, "Mar", 8);
        Alumno a3 = new Alumno(2, "ariana", 5);

        casoDictionary.AgregarAlumno(a1);
        casoDictionary.AgregarAlumno(a2);
        casoDictionary.AgregarAlumno(a3);

        casoDictionary.ObtenerDiccionario();

        try
        {
            Console.WriteLine(Environment.NewLine + $"ENCONTRADO: {casoDictionary.BuscarAlumnoKey(53441)}");
            Console.WriteLine(casoDictionary.BuscarAlumnoKey(11));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        casoDictionary.EliminarAlumno(53441);

        casoDictionary.ObtenerDiccionario();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine($"Primer Libro: {casoLinq.FirstLibro()}");

        Libro ultimo = casoLinq.LastLibro();
        Console.WriteLine($"Último Libro: {ultimo }");


        Console.WriteLine($"Total Precios: {casoLinq.GetTotalPrecios() }");
        Console.WriteLine($"Promedio Precios: {casoLinq.GetPromedioPrecios() }");


        Console.WriteLine($"Libro por ID: {casoLinq.GetListById() }");
        Console.WriteLine($"Libros: {casoLinq.GetLibros() }");
        Console.WriteLine($"Mayor Precio: {casoLinq.GetMayorPrecio() }");
        Console.WriteLine($"Menor Precio: {casoLinq.GetMenorPrecio() }");
        Console.WriteLine($"Mayor Promedio: {casoLinq.GetMayorPromedio() }");
        Console.WriteLine($"Libros Ordenados: {casoLinq.GetLibrosOrdenados() }");
    }
}
