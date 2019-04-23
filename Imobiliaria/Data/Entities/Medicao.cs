using Imobiliaria.Data.Entities;

public class Medicao
{
    public int Id { get; set; }
    public string Agua { get; set; }
    public string Energia { get; set; }
    public string Extintor { get; set; }
    public string Gas { get; set; }
    public bool Ativo { get; set; }

    public Vistoria Vistoria { get; set; }
}
