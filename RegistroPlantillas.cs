namespace LegalExpressPrototype;

public class RegistroPlantillas
{
    private readonly Dictionary<string, Contrato> _plantillas = new();

    public RegistroPlantillas()
    {
        var notario = new Notario("Lic. Ramon Zorrilla", "NOT-2045");

        Registrar("alquiler", new Contrato(
            "Contrato de alquiler",
            new DateTime(2026, 11, 5),
            new List<Clausula>
            {
                new Clausula("Duración: 12 meses"),
                new Clausula("Pago mensual: RD$ 20,000"),
                new Clausula("Depósito: un mes")
            },
            notario.Clonar()
        ));

        Registrar("compraventa", new Contrato(
            "Contrato de compraventa",
            new DateTime(2026, 11, 5),
            new List<Clausula>
            {
                new Clausula("Precio acordado entre las partes"),
                new Clausula("Entrega del inmueble contra pago"),
                new Clausula("Gastos según acuerdo")
            },
            notario.Clonar()
        ));

        Registrar("poder", new Contrato(
            "Poder especial",
            new DateTime(2026, 11, 5),
            new List<Clausula>
            {
                new Clausula("Identificación del poderdante"),
                new Clausula("Facultades otorgadas"),
                new Clausula("Vigencia del poder")
            },
            notario.Clonar()
        ));
    }

    public void Registrar(string nombre, Contrato plantilla)
    {
        _plantillas[nombre.ToLower()] = plantilla;
    }

    public Contrato ObtenerClon(string nombre)
    {
        string clave = nombre.ToLower();

        if (!_plantillas.ContainsKey(clave))
        {
            throw new KeyNotFoundException(
                $"No existe una plantilla llamada '{nombre}'."
            );
        }

        return _plantillas[clave].Clonar();
    }
}