<Query Kind="Statements" />

// Dada una lista de números, encuentra la suma de los elementos
int[] lista = new int[]{1,2,3,4,5,6,7,8,9,0,12,3,5,66,7,98,55,332,22,887,654,33};

int total = lista.Sum();
Console.WriteLine(total);

// Los mayores a 10
total = lista.Where(n => n > 10).Sum();
Console.WriteLine(total);

// Los 10 primeros
total = lista.Take(10).Sum();
Console.WriteLine(total);		

// Los 10 últimos
// La función Math.Max(0, numeros.Count() - 10) 
// asegura que no se intenten omitir más elementos de los que tiene la lista, 
// evitando así un índice negativo.
// Para este caso Math.Max(0, 10-12) retornaría 0 y no -2
total = lista.Skip(Math.Max(0, lista.Count() - 10)).Sum();
Console.WriteLine(total);



