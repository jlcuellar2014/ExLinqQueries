<Query Kind="Statements" />

// Encuentra la cantidad de elementos en una lista

string[] lista = { "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
IEnumerable<string> subconsulta = (from e in lista select e).Take(5);

PrintLista(subconsulta);

// Sintaxis método
subconsulta = lista.Take(5);

PrintLista(subconsulta);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}