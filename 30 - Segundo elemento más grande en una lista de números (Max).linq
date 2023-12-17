<Query Kind="Statements" />

// Encuentra el segundo elemento más grande en una lista de números

int[] numeros = { 10, 5, 8, 15, 7, 12, 18, 6 };

// Sintaxis método
int segundoMayor = numeros.Where(n => n < numeros.Max()).Max();
Console.WriteLine(segundoMayor);


// Sintaxis consulta
segundoMayor = (from numero in numeros
                     where numero < numeros.Max()
                     select numero)
                    .Max();
					
Console.WriteLine(segundoMayor);