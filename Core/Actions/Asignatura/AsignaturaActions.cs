public class AsignaturaActions
{
    public List<Asignatura> Asignaturas { get; set; }
    //constructor
    public AsignaturaActions()
    {
        Asignaturas = new List<Asignatura>();
    }

    public CrearAsignaturaDTO Crear(CrearAsignaturaViewModel asignatura)
    {
        int id = Asignaturas.Count + 1;
        var asignatura = new Asignatura(id, asignatura.Nombre)

        CrearAsingaturaDTO AsignaturaDTO = new CrearAsignaturaDTO(asignatura.id, asignatura.Nombre);
        Asignaturas.Add(asignatura);
        return AsignaturaDTO;
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
