<Query Kind="Statements" />

// Agrupa una lista de cadenas por la primera letra de cada cadena.

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena"};

// Sintaxis consulta
var resultado = from n in nombres group n by n[0];
PrintLista(resultado);

resultado = nombres.GroupBy(n => n[0]);
PrintLista(resultado);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}