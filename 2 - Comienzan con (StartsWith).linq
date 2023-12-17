<Query Kind="Statements" />

// Encuentra todos los nombres que comienzan con la letra "A"

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis de consulta
IEnumerable comienzanA = from n in nombres
							where n.StartsWith("A", StringComparison.OrdinalIgnoreCase)
								select n;
PrintLista(comienzanA);							


// Sintaxis de método
comienzanA = nombres.Where(n => n.StartsWith("A", StringComparison.OrdinalIgnoreCase));
PrintLista(comienzanA);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
								
