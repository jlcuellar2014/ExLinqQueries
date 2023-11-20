<Query Kind="Statements" />

// Encuentra los elementos que no están en ambas listas

int[] lista1 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };
int[] lista2 = new int[]{ 11, 42, 63, 48, 55, 6, 7, 8, 9, 0, 12, 3, 5, 66 };

// Sintaxis método
IEnumerable<int> noEstanEnAmbas = lista1.Except(lista2)
										.Union(
								 			 lista2.Except(lista1)
								  		);
											
PrintLista(noEstanEnAmbas);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}