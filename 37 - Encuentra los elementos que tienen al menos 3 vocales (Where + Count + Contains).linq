<Query Kind="Statements" />

// Encuentra los elementos que tienen al menos 3 vocales

string[] nombres = { "Juan", "María", "Carlos", "vddfft", "345", "0654Trw", "565rrt", "878", "Martín", "Elena", "JOrGE"};
string vocales = "aeiou";

// Sintaxis consulta
var resultado = from n in nombres
					where n.Count(v => vocales.Contains(v, StringComparison.OrdinalIgnoreCase)) >= 3
					select n;
					
PrintLista(resultado);

// Sintaxis método
resultado = nombres.Where(n => n.Count(v => vocales.Contains(v, StringComparison.OrdinalIgnoreCase)) >= 3);
PrintLista(resultado);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}