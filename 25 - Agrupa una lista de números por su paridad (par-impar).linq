<Query Kind="Statements" />

// Agrupa una lista de números por su paridad (par/impar)

int[] numeros = new int[]{ 1, 2, 36, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

// Sintaxis consulta
IEnumerable resultado = from n in numeros
				group n by ((n%2==0) ? "Pares" : "Impares" );
				
PrintLista(resultado);

// Sintaxis método
resultado = numeros.GroupBy(n => (n%2==0) ? "Pares" : "Impares");
PrintLista(resultado);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}

