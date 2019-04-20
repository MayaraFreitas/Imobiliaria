using System;

public class Medicao
{
    int pkMedicao;
    String agua;
    String energia;
    String extintor;
    String gas;
    bool ativo;

    Vistoria vistoria;

	public Medicao()
	{
	}

    public int PkMedicao { get => pkMedicao; set => pkMedicao = value; }
    public string Agua { get => agua; set => agua = value; }
    public string Energia { get => energia; set => energia = value; }
    public string Extintor { get => extintor; set => extintor = value; }
    public string Gas { get => gas; set => gas = value; }
    public bool Ativo { get => ativo; set => ativo = value; }
    public Vistoria Vistoria { get => vistoria; set => vistoria = value; }
}
