<Query Kind="Statements" />

// Encuentra la cantidad de elementos en una lista
string[] lista = { "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis consulta
int total = (from e in lista select e).Count();
Console.WriteLine(total);

// Sintaxis método
total = lista.Count();
Console.WriteLine(total);