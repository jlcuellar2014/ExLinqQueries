<Query Kind="Statements" />

// Cursos y Estudiantes:
// Dadas listas de cursos y estudiantes inscritos, encuentra el curso con la mayor cantidad de estudiantes

var estudiantes = new List<(int IdEstudiante, string Nombre)>{
	new (1, "Juan"),
	new (2, "María"),
	new (3, "Carlos"),
	new (4, "Ana"),
	new (5, "Laura"),
};

var cursos = new List<(int IdAsignatura, string Nombre)>{
	new (1, "Matemáticas"),
	new (2, "Lenguas extranjeras"),
	new (3, "Ciencias Naturales"),
	new (4, "Pedagogía"),
	new (4, "Educación Física"),
};

var cursos_estudiantes = new List<(int IdAsignatura, int IdEstudiante)>{
	new (1, 1),
	new (1, 2),
	new (1, 3),
	new (1, 4),
	new (1, 5),
	new (2, 1),
	new (2, 2),
	new (3, 3),
	new (3, 4),
	new (3, 5),
	new (4, 5),
};

// Sintaxis consulta
var cursoMasEstudiantes = from curso in cursos
							join relacion in cursos_estudiantes
								on curso.IdAsignatura equals relacion.IdAsignatura
									select new {
										Asignatura = curso.Nombre,
										Estudiante = relacion.IdEstudiante,
									};
PrintLista(cursoMasEstudiantes);
									
// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}