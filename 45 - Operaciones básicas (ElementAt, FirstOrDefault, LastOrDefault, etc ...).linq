<Query Kind="Statements" />

// Varias operaciones básicas

int[] numeros = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };
string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis método

// Operaciones sobre elementos

// Primer elemento de la lista ------------------------------------------------------------
Console.WriteLine("\nPrimer elemento de la lista ------------------------------------------------------------\n");

int primero = numeros.First(); 
Console.WriteLine($"Primer elemento de la lista: {primero}");

// La operación First si no encuentra el elemento lanza un error
// primero = new int[]{}.First(); 
// Console.WriteLine(primero);

// 		Como variante a esto podemos usar el FirstOrDerfault(), que en caso de no encontrar
// 		la respuesta devuelve el valor por defecto para en null del objeto esperado
primero = new int[]{}.FirstOrDefault();  // retirnará 0, que es el valor por defecto de int
Console.WriteLine($"Primer elemento de la lista vacía: {primero}");

var primerPersona = new List<(int Id, string Nombre)>{}.FirstOrDefault();
Console.WriteLine($"Datos persona vacía: Id={primerPersona.Id} - Nombre={primerPersona.Nombre}");

// Último elemento de la lista ------------------------------------------------------------
Console.WriteLine("\nÚltimo elemento de la lista ------------------------------------------------------------\n");

int ultimo = numeros.Last();
Console.WriteLine($"Último elemento de la lista: {ultimo}");

// 		Lo mismo, para cuando no exita respuesta
ultimo = new int[]{}.LastOrDefault();
Console.WriteLine($"Último elemento de la lista vacía: {ultimo}");

// Para seleccionar elementos en una posioción determinada --------------------------------
Console.WriteLine("\nPara seleccionar elementos en una posioción determinada --------------------------------\n");

int segundo = numeros.ElementAt(1);
Console.WriteLine($"Segundo elemento de la lista: {segundo}");

// 		Lo mismo, para cuando no exita respuesta
segundo = new int[]{}.ElementAtOrDefault(1);
Console.WriteLine($"Segundo elemento de la lista vacía: {segundo}");

// Como obtener 2do elemento
segundo = numeros.ElementAt(1);
Console.WriteLine($"Segundo elemento de la lista: {segundo}");

segundo = numeros.Skip(1).First();
Console.WriteLine($"Segundo elemento de la lista: {segundo}");

segundo = numeros.Skip(1).ElementAt(0);
Console.WriteLine($"Segundo elemento de la lista: {segundo}");

// Operaciones de agregación ---------------------------------------------------------------
Console.WriteLine("\nOperaciones de agregación ---------------------------------------------------------------\n");

int mayor = numeros.Max();
Console.WriteLine($"Mayor valor: {mayor}");

int menor = numeros.Min();
Console.WriteLine($"Menor valor: {menor}");

int total = numeros.Count();
Console.WriteLine($"Cantidad de elementos: {total}");

int suma = numeros.Sum();
Console.WriteLine($"Suma de los elementos: {suma}");

double promedio = numeros.Average();
Console.WriteLine($"Promedio de los elementos: {promedio}");

bool todos = numeros.All(n => n > 10);
Console.WriteLine($"Todos los elementos cumplen con una condición: {todos}");

bool alguno = numeros.Any(n => n > 10);
Console.WriteLine($"Algún elemento cumplen con una condición: {alguno}");

long multiplicacion = numeros.Aggregate(1, (auxiliar, numero)=> auxiliar * numero);
Console.WriteLine($"Multiplicación de todos los elementos de la lista: {multiplicacion}");

Console.WriteLine("\nOperaciones sobre listas --------------------------------------------------------\n");

var unicos = numeros.Distinct();
Console.WriteLine("Elementos únicos en una lista:");
PrintLista(unicos);

var sunconjunto = numeros.Skip(1).Take(3);
Console.WriteLine("Rango de elementos de la lista (1-4):");
PrintLista(sunconjunto);

var concatenadas = numeros.Concat(new int[]{5,5,5,5,5,5});
Console.WriteLine("Dos listas concatenadas:");
PrintLista(concatenadas);

// Union: Devuelve la unión de dos secuencias, *** eliminando duplicados ****
var unidas = numeros.Union(new int[]{5,5,5,5,5,5});
Console.WriteLine("Dos listas unidas (no pone los elementos repetidos):");
PrintLista(unidas);

var ordenada = numeros.OrderBy(n => n);
Console.WriteLine("La lista ordenada de menor a mayor:");
PrintLista(ordenada);

ordenada = numeros.OrderByDescending(n => n);
Console.WriteLine("La lista ordenada de mayor a menor:");
PrintLista(ordenada);

var invertida = numeros.Reverse();
Console.WriteLine("La lista con sus elementos invertidos (los del final serán los primeros) (no ordena la lista):");
PrintLista(invertida);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
