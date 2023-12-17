<Query Kind="Statements" />

// Concatena dos listas de strings
string[] lista1 = { "Juan", "María", "Carlos", "Ana", "Pedro"};
string[] lista2 = { "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
IEnumerable<string> lista3 = (from s in lista1 select s)
								.Concat(from s2 in lista2 select s2);
PrintLista(lista3);

// Sintaxis método
lista3 = lista1.Concat(lista2);
PrintLista(lista3);


// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}