<Query Kind="Statements" />

// Encuentra el elemento más pequeño en una lista de cadenas

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
var resultado = (from nombre in nombres select nombre).Min(nombre => nombre.Length);
Console.WriteLine(resultado);

// Sintaxis método
resultado = nombres.Min(nombre => nombre.Length);
Console.WriteLine(resultado);
