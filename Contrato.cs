namespace LegalExpressPrototype;

public class Contrato : IPrototipo<Contrato>
{
    public string Titulo { get; set; }
    public DateTime Fecha { get; set; }
    public List<Clausula> Clausulas { get; set; }
    public Notario Notario { get; set; }

    public Contrato(string titulo, DateTime fecha,
                    List<Clausula> clausulas, Notario notario)
    {
        Titulo = titulo;
        Fecha = fecha;
        Clausulas = clausulas;
        Notario = notario;
    }

    public Contrato Clonar()
    {
        var clausulasClonadas = new List<Clausula>();

        foreach (Clausula clausula in Clausulas)
        {
            clausulasClonadas.Add(clausula.Clonar());
        }

        return new Contrato(
            Titulo,
            Fecha,
            clausulasClonadas,
            Notario.Clonar()
        );
    }
}