<Query Kind="Statements" />

// Encuentra los elementos que contienen al menos una vocal.

string[] nombres = { "Juan", "María", "Carlos", "vddfft", "345", "0654Trw", "565rrt", "878", "Martín", "Elena", "JOrGE"};
string vocales = "aeiou";

// Sintaxis consulta
var resultado = from n in nombres
					where n.Any(c => vocales.Contains(c, StringComparison.OrdinalIgnoreCase)) 
						select n;
						
PrintLista(resultado);

// Sintaxis método
resultado = nombres.Where(n => n.Any(c => vocales.Contains(c, StringComparison.OrdinalIgnoreCase)));
PrintLista(resultado);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}


