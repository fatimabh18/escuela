using System;

public class AlumnosActions
{
	public List<Alumno> Alumnos {get; set;}
	public AlumnosActions() // esto es un constructor (metodo especial)
	{
		Alumnos = new List<Alumno>(); 
	}
	public CrearAlumnoDTO Crear(CrearAlumnoViewModel alumno) // en los paréntesis, está el parámetro de entrada
	{
		int id = (Alumnos.Count) +1; 
		var alumno = new Alumno(id, alumno.Nombre);

		CrearAlumnoDTO resultado = new CrearAlumnoDTO(alumno.Id, alumno.Nombre);
		Alumnos.Add(alumno);
		return resultado;  // el DTO es el parámetro de salida	
		
	}
	public void Editar()
	{
	}
	public void Borrar()
	{
	}
	public void Listar()
	{
	}

}
