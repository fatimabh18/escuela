public class Asignatura
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public Asignatura(string nombre, int id)
    {
        Nombre = nombre;
        Id = id;
    }
}

                  