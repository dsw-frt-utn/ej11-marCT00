using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    public Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno nuevoAlumno)
    {
        if(diccionarioAlumnos.TryAdd(nuevoAlumno.Id, nuevoAlumno))
        {
            Console.WriteLine(Environment.NewLine + $"se agrego el alumno {nuevoAlumno.Id}");
        } else {
            Console.WriteLine(Environment.NewLine + $"el alumno {nuevoAlumno.Id} ya existe");
        }
    }

    public Alumno BuscarAlumnoKey(int clave){
        if(diccionarioAlumnos.ContainsKey(clave)){
            return diccionarioAlumnos[clave];
        }
        throw new KeyNotFoundException(Environment.NewLine + "El alumno no existe");
    }

    public void ObtenerDiccionario()
    {
        Console.WriteLine(Environment.NewLine +"--- Diccionario Actual ---");
        foreach (KeyValuePair<int, Alumno> Alumno in diccionarioAlumnos)
        {
            Console.WriteLine( $"{Alumno.Value}");
        }
    }

    public void EliminarAlumno(int legajo)
    {
        if (diccionarioAlumnos.Remove(legajo)) {
            Console.WriteLine(Environment.NewLine + $"se elimino: {legajo}");
        } Console.WriteLine(Environment.NewLine + $"No se encontró Alumno: {legajo}");
    }

}
