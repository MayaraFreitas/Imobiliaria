using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Medicao
{
    public int pkMedicao { get; set; }
    public String agua { get; set; }
    public String energia { get; set; }
    public String extintor { get; set; }
    public String gas { get; set; }
    public bool ativo { get; set; }

    Vistoria vistoria;

	public Medicao()
	{
	}
    public Vistoria Vistoria { get => vistoria; set => vistoria = value; }
}
