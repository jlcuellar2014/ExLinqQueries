<Query Kind="Statements" />

// Devuelve los elementos que aparecen más de una vez en una lista

int[] numeros = { 10, 5, 5, 8, 8, 15, 7, 12, 18, 6 };

// Sintaxis método
IEnumerable<int> repetidos = numeros.Where(n => numeros.Count(s => s.Equals(n)) > 1).Distinct();
PrintLista(repetidos);

// 	***** En terminos de rendimiento el GroupBy es más optimo ya que el Count solo cuenta
//		  el grupo, en el otro caso hay que contar la lista completa n veces

// 	El SelectMany es usado para aplanar los grupos
repetidos = numeros.GroupBy(n => n)
					.Where(g => g.Count() > 1)
					.SelectMany(g => g)
					.Distinct();

PrintLista(repetidos);

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
