<Query Kind="Statements" />

// Elimina los duplicados de una lista

int[] numeros = new int[]{ 1, 2, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 3 };

// Sintaxis consulta
IEnumerable<int> unicos = (from n in numeros select n).Distinct();
PrintLista(unicos);

// Sintaxis método
unicos = numeros.Distinct();
PrintLista(unicos);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
