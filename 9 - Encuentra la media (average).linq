<Query Kind="Statements" />

// Encuentra la media de una lista de números decimales
decimal[] numeros = new decimal[]{ 1.48345m, 2.48m, 3.48m, 4.48m, 5.988m, 6.48m, 7.58m, 8.38m, 9.248m, 0.448m, 12.648m, 3.148m, 5.5648m, 66, 7.348m, 98.48433m, 55, 332.4898m, 22.98m, 887, 654, 33.4m};

/*
	Sí, en este contexto, "average" y "media" son términos equivalentes y 
	se utilizan de manera intercambiable. En el código que proporcioné, 
	el método Average() de LINQ calcula la media de los valores en la lista de números decimales. 
	Ambos términos se refieren al valor que se obtiene al sumar todos los elementos y 
	dividir el resultado entre el número total de elementos. 
	
	Por lo tanto, en este caso, puedes interpretar Average como "media".
	
	Mientras que "media" y "average" a menudo se utilizan de manera intercambiable para referirse 
	a la media aritmética, "promedio" es un término más general que puede abarcar varios tipos de promedios.
	En muchos casos prácticos, especialmente en programación, la diferencia entre ellos es mínima y 
	se entienden como el mismo concepto.
*/

// Sintaxis función
decimal media = (from n in numeros select n).Average();

Console.WriteLine(media);

// Sintaxis método
media = numeros.Average();

Console.WriteLine(media);
