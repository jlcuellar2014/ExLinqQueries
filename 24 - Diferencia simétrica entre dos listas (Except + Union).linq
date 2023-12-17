<Query Kind="Statements" />

// Obtiene la diferencia simétrica entre dos listas

/*
	La diferencia simétrica entre dos listas, también conocida como diferencia exclusiva, 
	se compone de los elementos que están en una de las listas, pero no en ambas. 
	En C# con LINQ, puedes usar la combinación de los métodos Except y Union para obtener la diferencia simétrica. 
	Aquí tienes la sentencia LINQ:
*/

int[] lista1 = new int[]{ 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };
int[] lista2 = new int[]{ 11, 42, 63, 48, 4, 8, 9, 55, 6, 7, 8, 9, 0, 12, 3, 5, 66 };

// Sintaxis consulta
IEnumerable<int> exclusivos = (
								from v in lista1 where !lista2.Contains(v) select v
							  )
							  .Union(
							  	(
									from v in lista2 where !lista1.Contains(v) select v
								)
							  );
PrintLista(exclusivos);

// Sintaxis método
exclusivos = lista1.Except(lista2)
					.Union(
						lista2.Except(lista1)
					);
									
PrintLista(exclusivos);



// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}