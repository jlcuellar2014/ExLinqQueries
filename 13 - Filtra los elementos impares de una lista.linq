<Query Kind="Statements" />

// Filtra los elementos impares de una lista
int[] lista = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

// Sintaxis consulta
IEnumerable<int> impares = from e in lista
									where e % 2 != 0
										select e;							
PrintLista(impares);

// Sintaxis método
impares = lista.Where(n => n % 2 != 0);
PrintLista(impares);

// Para obtener los pares solo necesitamos modificar la condición a n % 2 == 0

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}							