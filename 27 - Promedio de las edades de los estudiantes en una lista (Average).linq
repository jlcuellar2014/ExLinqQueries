<Query Kind="Statements" />

// Encuentra el promedio de las edades de los estudiantes en una lista

List<(string Nombre, int Edad, string Nacionalidad)> estudiantes = new List<(string, int, string)>
{
    ("Juan", 20, "Mexicana"),
    ("Ana", 22, "Española"),
    ("Carlos", 20, "Mexicana"),
    ("María", 18, "Colombiana"),
    ("Pedro", 22, "Argentina"),
    ("Laura", 20, "Mexicana"),
    ("Andrés", 18, "Colombiana"),
    ("Isabel", 22, "Española"),
    ("Martín", 18, "Colombiana"),
    ("Elena", 20, "Mexicana"),
    ("Ricardo", 22, "Argentina"),
    ("Sofía", 18, "Colombiana"),
    ("Luis", 20, "Mexicana"),
    ("Julia", 22, "Española"),
    ("Miguel", 20, "Mexicana"),
};


// Sintaxis consulta
double promedio = (from e in estudiantes select e.Edad).Average();

Console.WriteLine(promedio);

// Sintaxis método
promedio = estudiantes.Average(e => e.Edad);
Console.WriteLine(promedio);
