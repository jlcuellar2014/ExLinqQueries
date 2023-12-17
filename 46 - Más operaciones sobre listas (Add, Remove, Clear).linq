<Query Kind="Statements" />

// Más operaciones sobre listas

int[] numeros = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };
List<string> nombres = new() { "Juan", "María", "Carlos" };

// Sintaxis método

Console.WriteLine("\nAdicionar un elemento a una lista ------------------------------------------------------------\n");

Console.WriteLine("La lista original:");
PrintLista(nombres);

Console.WriteLine("\nLa lista original (+) Daniela:");
nombres.Add("Daniela");
PrintLista(nombres);

Console.WriteLine("\nEliminando un elemento a una lista ------------------------------------------------------------\n");

Console.WriteLine("La lista original (-) Daniela:");
nombres.Remove("Daniela");
PrintLista(nombres);

Console.WriteLine("\nVaciando toda la lista -------------------------------------------------------------------------\n");

nombres.Clear();
PrintLista(nombres);
Console.WriteLine($"Cantidad de elemento en la lista: {nombres.Count()}");

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}