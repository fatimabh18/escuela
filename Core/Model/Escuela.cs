public class Escuela
{
    public int id { get; set;  }
    public string nombre { get; set; }

    public Escuela (string nombre, int id)
    {
        Id = id;
        Nombre = nombre;
    }
}

