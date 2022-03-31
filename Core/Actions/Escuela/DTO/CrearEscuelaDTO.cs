public class CrearEscuelaDTO
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public CrearEscuelaDTO (string nombre, int id)
    {
        Id = id;
        Nombre = nombre;
    }

}
