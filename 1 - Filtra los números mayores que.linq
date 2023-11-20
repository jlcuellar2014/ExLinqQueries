<Query Kind="Statements" />

// Filtra los números mayores que 50 de una lista
int[] lista = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

IEnumerable<int> resultado;

// Expresiones de Consulta (Sintaxis de Consulta)
resultado = from e in lista where e > 50
		   select e;
		   
// No se puede guardar en un objeto List, pq este tipo de 
// consulta devuelve un IEnumerable (daría un error de cast)
PrintLista(resultado);

// Métodos de Extensión (Sintaxis de Métodos)
resultado = lista.Where(e => e > 50);
PrintLista(resultado);


// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}

