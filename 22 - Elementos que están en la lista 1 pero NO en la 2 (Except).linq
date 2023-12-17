<Query Kind="Statements" />

// Encuentra los elementos que están en la primera lista pero no en la segunda.

int[] lista1 = new int[]{ 1, 2, 1, 2, 3, 4, 5, 6, 6, 7 };
int[] lista2 = new int[]{ 1, 2, 1, 6, 7, 8, 9, 3 };

// Sintaxis método
IEnumerable<int> resultado = lista1.Except(lista2);

PrintLista(resultado);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}