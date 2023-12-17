<Query Kind="Statements" />

// Convierte una lista de strings a minúsculas

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis de consulta
// Mayúsculas
IEnumerable<string> nombresTrasformados = from n in nombres
									select n.ToUpper();
PrintLista(nombresTrasformados);

// Minúsculas
nombresTrasformados = from n in nombres
						select n.ToLower();
PrintLista(nombresTrasformados);

// Sintaxis método
// Mayúsculas
nombresTrasformados = nombres.Select(n => n.ToUpper());
PrintLista(nombresTrasformados);

// Minúsculas
nombresTrasformados = nombres.Select(n => n.ToLower());
PrintLista(nombresTrasformados);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}