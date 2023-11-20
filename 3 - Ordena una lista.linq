<Query Kind="Statements">
  <RuntimeVersion>7.0</RuntimeVersion>
</Query>

// Ordena una lista de strings alfabéticamente

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis de consulta
IEnumerable<string> listaOrdenada = from n in nombres
										orderby n
											select n;
PrintLista(listaOrdenada);

listaOrdenada = from n in nombres
					orderby n ascending
						select n;
						
PrintLista(listaOrdenada);


listaOrdenada = from n in nombres
					orderby n descending
						select n;
						
PrintLista(listaOrdenada);

// Sintaxis método
listaOrdenada = nombres.OrderBy(n => n);
PrintLista(listaOrdenada);

listaOrdenada = nombres.OrderByDescending(n => n);
PrintLista(listaOrdenada);

// Ahora lo complicamos un poco ordenando por más de un concepto


List<(string Nombre, int Edad)> personas = new List<(string Nombre, int Edad)>
{
    new ( "Juan",30 ),
    new ( "Ana", 25 ),
    new ( "Juan", 25 ),
    new ( "Carlos", 35 ),
};

// Sintaxis de consulta
listaOrdenada = from p in personas
					orderby p.Nombre, p.Edad
						select p.Nombre;
PrintLista(listaOrdenada);

// Sintaxis de método
listaOrdenada = personas
					.OrderBy(p => p.Nombre)
					.ThenBy(p => p.Edad)
					.Select(p => p.Nombre);
PrintLista(listaOrdenada);



// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}