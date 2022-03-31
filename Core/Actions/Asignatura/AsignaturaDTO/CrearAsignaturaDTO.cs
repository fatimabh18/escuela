public class CrearAsignaturaDTO
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public CrearAsignaturaDTO(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
