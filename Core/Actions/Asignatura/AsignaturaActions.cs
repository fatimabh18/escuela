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
        CrearAsingaturaDTO resultado = new CrearAsignaturaDTO();
        //a�adir elementos a la lista
        Asignaturas.Add(new Asignatura() { Nombre = asignatura.Nombre });
        return resultado;
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
