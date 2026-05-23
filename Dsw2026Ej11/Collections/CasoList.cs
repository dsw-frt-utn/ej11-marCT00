using Dsw2026Ej11.Domain;
using System.Data;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno>listaAlumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno nuevoAlumno)
    {
        listaAlumnos.Add(nuevoAlumno);
        Console.WriteLine($"Alumno {nuevoAlumno} agregado a la lista.");
    }

    public void ObtenerLista()
    {
        if (listaAlumnos.Count == 0)
        {
            Console.WriteLine("La lista de alumnos está vacía.");
            throw new Exception("No hay alumnos en la lista.");
        } else
        {
            Console.WriteLine("--- Lista de alumnos actual ---");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(alumno);
            }
        }
       
    }

    public Alumno BuscarAlumnoNombre(string nombre)
    {
        Alumno? encontrado = listaAlumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (encontrado is null)
        {
            throw new Exception($"No existe Alumno {nombre}");
        } else
        {
            Console.WriteLine($"Alumno encontrado: {encontrado}");
            return encontrado;
        }
    }

    public void EliminarAlumno(Alumno alumno)
    {
        if (listaAlumnos.Remove(alumno))
        {
            Console.WriteLine($"Alumno {alumno} eliminado de la lista.");
        }
        else
        {
            Console.WriteLine($"No se encontró el alumno {alumno} en la lista. No se eliminó");
        }
    }

    public void EliminarPosicion(int posicion)
    {
        //  posicion++; en el caso de tener un usuario que considere posicion 0 = posicion 1
        if (posicion >= 0 && posicion < listaAlumnos.Count)
        {
            Alumno alumnoEliminado = listaAlumnos[posicion];
            listaAlumnos.RemoveAt(posicion);
            Console.WriteLine($"Alumno {alumnoEliminado} eliminado de la posición {posicion}.");

        }
        else
        {
            Console.WriteLine("Posición no válida.");
        }
    }
}
