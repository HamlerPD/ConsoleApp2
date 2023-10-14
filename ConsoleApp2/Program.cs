
//Escribir un programa en el cual se ingresen cuatro números,
//calcular e informar la suma de los dos primeros yel producto del tercero y
//el cuarto

using ConsoleApp2.ejercicio2;

Aritmetica c;
Console.WriteLine(" Ingrese el primer numero ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine(" Ingrese el segundo numero ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine(" Ingrese el tercer numero ");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine(" Ingrese el cuarto numero ");
double num4 = double.Parse(Console.ReadLine());

c = new Aritmetica(num1, num2, num3, num4);

Console.WriteLine(" La suma de los primeros numeros es:" + c.Getsuma() + " EL producto de los dos ultimos numeros es: " + c.Producto());
