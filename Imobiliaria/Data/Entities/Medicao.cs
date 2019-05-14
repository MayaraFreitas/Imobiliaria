using Imobiliaria.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class Medicao
{
    public int Id { get; set; }
    public string Agua { get; set; }
    public string Energia { get; set; }
    public byte Extintor { get; set; }
    public byte GasEncanado { get; set; }
    public bool Ativo { get; set; }
    public int IdVistoria { get; set; }

    [ForeignKey("IdVistoria")]
    public Vistoria Vistoria { get; set; }
}
