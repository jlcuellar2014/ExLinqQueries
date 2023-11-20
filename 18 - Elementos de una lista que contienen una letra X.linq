<Query Kind="Statements" />

// Devuelve los elementos de una lista que contienen la letra "e"

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
IEnumerable<string> subconsulta = from e in nombres 
										where e.Contains("e")
											select e;
											
PrintLista(subconsulta);

// Sintaxis método
subconsulta = nombres.Where(n => n.Contains("u"));
PrintLista(subconsulta);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}