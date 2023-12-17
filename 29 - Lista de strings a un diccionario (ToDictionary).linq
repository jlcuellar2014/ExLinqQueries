<Query Kind="Statements" />

// Convierte una lista de strings a un diccionario donde las claves son las longitudes de las cadenas

string[] nombres = { "Juan", "María", "Ana", "Laurita"};

// Sintaxis consulta
Dictionary<int, string> resultado = (from v in nombres select v)
									.ToDictionary(v => v.Length, v => v);
															
PrintLista(resultado);

// Sintaxis método
resultado = nombres.ToDictionary(v => v.Length, v => v);
PrintLista(resultado);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
