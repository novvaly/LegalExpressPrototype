using LegalExpressPrototype;

var registro = new RegistroPlantillas();

Contrato original = registro.ObtenerClon("alquiler");
Contrato clon = original.Clonar();

Console.WriteLine("=== DATOS INICIALES ===");
Console.WriteLine($"Original: {original.Titulo}");
Console.WriteLine($"Clon:     {clon.Titulo}");

Console.WriteLine("\\n=== REFERENCE EQUALS ===");
Console.WriteLine($"¿Mismo contrato? {ReferenceEquals(original, clon)}");
Console.WriteLine($"¿Misma lista? {ReferenceEquals(original.Clausulas, clon.Clausulas)}");
for (int i = 0; i < original.Clausulas.Count; i++)
{
    Console.WriteLine($"¿Misma cláusula {i}? {ReferenceEquals(original.Clausulas[i], clon.Clausulas[i])}");
}
Console.WriteLine($"¿Mismo notario? {ReferenceEquals(original.Notario, clon.Notario)}");

Console.WriteLine("\\n=== PRUEBA DE INDEPENDENCIA ===");
clon.Titulo = "Contrato de alquiler personalizado";
clon.Clausulas[0].Texto = "Duración modificada: 24 meses";
clon.Notario.Nombre = "Lic. Carlos Díaz";

Console.WriteLine($"Título original: {original.Titulo}");
Console.WriteLine($"Título clon:     {clon.Titulo}");
Console.WriteLine($"Cláusula original: {original.Clausulas[0].Texto}");
Console.WriteLine($"Cláusula clon:     {clon.Clausulas[0].Texto}");
Console.WriteLine($"Notario original: {original.Notario.Nombre}");
Console.WriteLine($"Notario clon:     {clon.Notario.Nombre}");

Console.WriteLine("\\n=== TRES PLANTILLAS ===");
foreach (string nombre in new[] { "alquiler", "compraventa", "poder" })
{
    Contrato plantillaClonada = registro.ObtenerClon(nombre);
    Console.WriteLine($"{nombre}: {plantillaClonada.Titulo}");
}
Console.ReadKey();