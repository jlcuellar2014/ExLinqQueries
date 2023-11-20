<Query Kind="Statements" />

// Devuelve los elementos que están en una lista pero no en la otra, ignorando mayúsculas y minúsculas.

string[] nombres = { "juan", "maría", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena"};
string[] nombres2 = { "Juan", "María" };

// Sintaxis consulta (no recomendada, la de sentaxis método es más optima)
var resultado = from n in nombres 
					where !nombres2.Any(v => v.Contains(n, StringComparison.OrdinalIgnoreCase)) 
					select n;
PrintLista(resultado);


// Sintaxis método
resultado = nombres.Except(nombres2, StringComparer.OrdinalIgnoreCase);
PrintLista(resultado);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}