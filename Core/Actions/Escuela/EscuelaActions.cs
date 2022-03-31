using System;
public class EscuelaActions
{
    public List<Escuela> Escuelas {get; set;}
	public EscuelaActions() // esto es un constructor (metodo especial)
	{
		Escuelas = new List<Escuela>(); 
	}
	public CrearEscuelaDTO Crear(CrearEscuelaViewModel escuela) // en los paréntesis, está el parámetro de entrada
	{
        int id = (Escuela.Count) +1;
        var escuela = new Escuela (id, escuela.Nombre);	
	
        CrearEscuelaDTO resultado = new CrearEscuelaDTO(escuela.Id, escuela.Nombre);
		Escuelas.Add(escuela);
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