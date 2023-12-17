<Query Kind="Statements" />

// Encuentra todos los nombres que terminen con la letra "A"

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis de consulta
IEnumerable<string> terminanA = from n in nombres
									where n.EndsWith("A", StringComparison.OrdinalIgnoreCase)
										select n;
PrintLista(terminanA);

// Sintaxis de método
terminanA = nombres.Where(n => n.EndsWith("A", StringComparison.OrdinalIgnoreCase));
PrintLista(terminanA);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}