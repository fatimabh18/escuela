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
		CrearAlumnoDTO resultado = new CrearAlumnoDTO();
		Alumnos.Add(new Alumno() {nombre = "", id= 0});
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
