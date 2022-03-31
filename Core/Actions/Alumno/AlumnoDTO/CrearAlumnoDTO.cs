public class CrearAlumnoDTO
{
    public int Id { get; set; }


    public string Nombre { get; set; }

    public CrearAlumnoDTO (int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}

   
