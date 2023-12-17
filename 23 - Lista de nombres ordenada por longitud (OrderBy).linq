<Query Kind="Statements" />

// Devuelve una lista de nombres ordenada por longitud

string[] nombres = { "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
IEnumerable<string> ordenados = from n in nombres orderby n.Length select n;
PrintLista(ordenados);

// Sintaxis método
ordenados = nombres.OrderBy(n => n.Length);
PrintLista(ordenados);


// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}