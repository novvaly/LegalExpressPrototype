namespace LegalExpressPrototype;

public class Notario : IPrototipo<Notario>
{
    public string Nombre { get; set; }
    public string NumeroColegiatura { get; set; }

    public Notario(string nombre, string numeroColegiatura)
    {
        Nombre = nombre;
        NumeroColegiatura = numeroColegiatura;
    }

    public Notario Clonar()
    {
        return new Notario(Nombre, NumeroColegiatura);
    }

    public override string ToString()
    {
        return $"{Nombre} (Colegiatura: {NumeroColegiatura})";
    }
}