<Query Kind="Statements" />

// Encuentra los elementos que tienen el mismo número de vocales y consonantes

string[] nombres = { "Juan", "María", "Carlos", "Martín", "Elena", "JOrGE", "An e", "AnNe"};
string vocales = "aeiou";

// Sintaxis consulta
var resultado = from n in nombres 
					where n.Count(v => vocales.Contains(v, StringComparison.OrdinalIgnoreCase))
					.Equals(
						  n.Replace(" ", string.Empty).Count(v => !vocales.Contains(v, StringComparison.OrdinalIgnoreCase)))
				select n;
				
PrintLista(resultado);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}