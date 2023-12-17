<Query Kind="Statements" />

// Encuentra los elementos únicos en una lista

string[] nombres = { "Juan", "Juan", "Juan", "María", "Carlos", "Ana", "Ana", "Pedro", "Pedro", "Laura"};

// Sintaxis funcion
IEnumerable<string> unicos = (from n in nombres select n).Distinct();
PrintLista(unicos);

// Sintaxis método
unicos = nombres.Distinct();
PrintLista(unicos);


// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}