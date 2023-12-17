<Query Kind="Statements" />

// Alinear elementos anidados en una lista


var estudiantes = new List<(int Id, string Nombre)>{
	new (1 , "Juan"),
	new (2 , "María"),
	new (3 , "Carlos"),
};

var escuelas = new List<(string Nombre, List<(int Id, string Nombre)> Estudiantes)>{
	new ("Escuela 1", estudiantes),
	new ("Escuela 2", estudiantes),
	new ("Escuela 3", estudiantes),
	new ("Escuela 4", estudiantes),
};

PrintLista(escuelas);

// Sntaxis método
var combinados = escuelas.SelectMany(e => e.Estudiantes);
PrintLista(combinados);

var combinados2 = escuelas.SelectMany(e => e.Estudiantes.Select(e => e.Nombre));
PrintLista(combinados2);



// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}

