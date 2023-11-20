<Query Kind="Statements" />

// Devuelve los elementos de una lista que son mayores que el promedio

int[] numeros = new int[]{ 52, 2, 36, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };


Console.WriteLine($"Promedio: {numeros.Average()}");


// Sintaxis consulta
IEnumerable<int> resultado = from n in numeros 
								where n > (numeros.Average())
									select n;			
PrintLista(resultado);

// Sintaxis método
resultado = numeros.Where(n => n > numeros.Average());
PrintLista(resultado);


// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
