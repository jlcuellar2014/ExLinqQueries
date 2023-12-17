<Query Kind="Statements" />

// Uso de la palabra reservada Into

// Se pudiera decir que es como para guardar el resultado de una consulta, para poderle aplicar nuevas reglas
string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintasis consulta

var resultado = from n in nombres 
					where n.Contains("u", StringComparison.OrdinalIgnoreCase)
						select n
							into subresultado
								where subresultado.Length > 3
									select subresultado.ToUpper();
PrintLista(resultado);

var resultado2 = from n in nombres
					group n by n[0]
						into grupo
							where grupo.Count() > 2
								select grupo;
PrintLista(resultado2);

var resultado3 = from n in nombres
					where n.Length > 3
						select n into subconsulta // Acá se toma cada elemento que cumpla con la condición
							from s in subconsulta // Acá se consulta sobre cada elemento como si fuera una lista
								select s;		  // Por eso acá se selecciona sobre los caracteres del elemento n
PrintLista(resultado3);

var resultado4 = from n in nombres
					select n.ToUpper()
						into sub
							from s in sub
								group s by s
									into grupo
										select new {
											Caracter = grupo.Key,
											Cantidad = grupo.Count()
										};
PrintLista(resultado4);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}