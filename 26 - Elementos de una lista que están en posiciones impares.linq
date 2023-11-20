<Query Kind="Statements" />

// Devuelve los elementos de una lista que están en posiciones impares

int[] numeros = new int[]{ 52, 2, 36, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

// Sintaxis método
// 		Tener en cuenta  que los arreglos comienzan por la posición 0 que es par
//		Si se quiere tomar el primer valor (52) como posición impar, 
//		hay que jugar con las las condiciones del where

IEnumerable<int> resultado = numeros.Where((valor, indice) => indice%2 != 0);
PrintLista(resultado);
									
// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
