<Query Kind="Statements" />

// Uso de la palabra reservada Let

// Se puede decir que es la declaración de una variable para usar ese valor auxiliar dentro de la consulta

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintasis consulta
var resultado = from n in nombres
					let longitudPrimerNombre = nombres.FirstOrDefault().Length
						where n.Length > longitudPrimerNombre
							select new {
								Nombre = n,
								Longitud = n.Length
							};
							
PrintLista(resultado);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}