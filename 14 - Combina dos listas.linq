<Query Kind="Statements" />

// Combina dos listas en una lista de pares

int[] lista1 = new int[]{ 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };
int[] lista2 = new int[]{ 11, 42, 63, 48, 4, 8, 9, 55, 6, 7, 8, 9, 0, 12, 3, 5, 66 };

// ---------- Combinar solo los pares ----------------------------------------------

// Sintaxis consulta
IEnumerable<int> pares = (from e in lista1 where e % 2 == 0 select e)
							.Concat(from e2 in lista2 where e2 % 2 == 0 select e2);
							
PrintLista(pares);

// Sintaxis método
pares = lista1.Where(e => e % 2 == 0)
			  .Concat(lista2.Where(e2 => e2 % 2 == 0));
			  
PrintLista(pares);

// ---------- Combina dos listas eliminando duplicados --------------------------------
IEnumerable<int> unicos = lista1.Concat(lista2).Distinct();
PrintLista(unicos);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
