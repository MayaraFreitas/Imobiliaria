using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Data.Entities
{
    [Table("ViewNota")]
    public class ViewNota
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public int IdComodo { get; set; }
    }
}
