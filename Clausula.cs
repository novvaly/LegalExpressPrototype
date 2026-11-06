namespace LegalExpressPrototype;

public class Clausula : IPrototipo<Clausula>
{
    public string Texto { get; set; }

    public Clausula(string texto)
    {
        Texto = texto;
    }

    public Clausula Clonar()
    {
        return new Clausula(Texto);
    }

    public override string ToString()
    {
        return Texto;
    }
}