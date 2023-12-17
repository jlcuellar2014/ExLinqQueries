<Query Kind="Statements" />

// Agrupa una lista de números por su resto al dividir por 5

int[] lista = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

// Sintasis consulta
var resultado = from elemento in lista
					group elemento by elemento % 5;
					
PrintLista(resultado);

// Sintaxis método
resultado = lista.GroupBy(elemento => elemento % 5);

PrintLista(resultado);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}