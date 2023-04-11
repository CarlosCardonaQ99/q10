namespace q10.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Completada { get; set; }
    }
}
