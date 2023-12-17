<Query Kind="Statements" />

// Devuelve los elementos que están en la posición par de una lista

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis método
var resultado = nombres.Where((nombre, indice) => indice % 2 == 0);

PrintLista(resultado);
									
// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}