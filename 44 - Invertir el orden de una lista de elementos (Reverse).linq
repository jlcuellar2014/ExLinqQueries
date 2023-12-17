<Query Kind="Statements" />

// Invertir el orden de una lista de elementos

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis método
var listaInvertida = nombres.Reverse();

// Sintaxis consulta
//		No tiene una palabra reservada para esto

/*
	Ambos Reverse y OrderByDescending son métodos en LINQ que se pueden utilizar para invertir el orden de una secuencia, 
	pero se aplican en contextos ligeramente diferentes.

	Reverse: Este método simplemente invierte el orden de los elementos en una secuencia sin tener en cuenta su valor. 
			 Es decir, si tienes una lista [1, 2, 3, 4], después de aplicar Reverse, 
			 obtendrías [4, 3, 2, 1]. No hay ninguna consideración sobre el valor real de los elementos, 
			 solo se invierte su posición en la secuencia.
			 
	OrderByDescending: Este método se utiliza para ordenar una secuencia en orden descendente basándose en algún criterio. 
					   Si aplicas OrderByDescending a una secuencia de números, por ejemplo, 
					   obtendrás una nueva secuencia ordenada de mayor a menor. 
					   A diferencia de Reverse, OrderByDescending considera el valor de los elementos y 
					   los organiza en un orden específico.
*/

PrintLista(listaInvertida);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}