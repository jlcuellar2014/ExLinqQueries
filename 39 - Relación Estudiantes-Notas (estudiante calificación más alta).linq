<Query Kind="Statements" />

// Estudiantes y Notas:
// Dada una lista de estudiantes con nombres y calificaciones, 
// encuentra el estudiante con la calificación más alta.

var estudiantes = new List<(int IdEstudiante, string Nombre)>{
	new (1, "Juan"),
	new (2, "María"),
	new (3, "Carlos"),
	new (4, "Ana"),
	new (5, "Laura"),
};

var notas = new List<(int IdEstudiante, float Nota)>{
	new (1, 3.5f),
	new (1, 4.5f),
	new (1, 4.89f),
	new (1, 2.45f),
	new (1, 2f),
	new (2, 3.34f),
	new (2, 4.85f),
	new (2, 5.0f),
	new (2, 4.5f),
	new (3, 5.0f),
	new (3, 4.95f),
	new (3, 1.95f),
	new (3, 2.95f),
	new (4, 4.55f),
	new (4, 3.35f),
	new (4, 4.9f),
	new (4, 3.0f),
	new (5, 4.05f),
	new (5, 4.10f),
	new (5, 3.15f),
};

// Sintaxis consulta
var estudiantesMejorNota = from e in estudiantes
							join n in notas
								on e.IdEstudiante equals n.IdEstudiante
									where n.Nota == notas.Max(s => s.Nota)
								 	select new {
										Nombre= e.Nombre, 
										Nota= n.Nota
									};
PrintLista(estudiantesMejorNota);

// Sintaxis método
/*
	var resultadoJoin = secuencia1
    .Join(
        secuencia2,
        claveSecuencia1 => claveSecuencia1.PropiedadEnSecuencia1,
        claveSecuencia2 => claveSecuencia2.PropiedadEnSecuencia2,
        (elementoSecuencia1, elementoSecuencia2) => new
        {
            PropiedadResultado1 = elementoSecuencia1.PropiedadEnSecuencia1,
            PropiedadResultado2 = elementoSecuencia2.PropiedadEnSecuencia2
        });
		
*/
estudiantesMejorNota = estudiantes.Join(
								   notas,
								   ke => ke.IdEstudiante, // key estudiantes
								   kn => kn.IdEstudiante, // key notas
								   (e, n) => new { // r - respuesta
								   		Nombre= e.Nombre, 
										Nota= n.Nota
								   })
								   .Where( // el where se lo aplicamos a respuesta
								   		r => r.Nota == notas.Max(n => n.Nota)
									);

PrintLista(estudiantesMejorNota);

// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}