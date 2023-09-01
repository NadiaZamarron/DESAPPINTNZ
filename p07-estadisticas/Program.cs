﻿// Calcula las estadisticas basicas de un arreglo de calificaciones 

const int MAX=100;
int n=0;
double[] califs = null;

double may=0, men=0, prom=0, var=0, desv=0;

Console.Clear();
Console.Write("Cuantos elementos vas a introducir?");
n=int.Parse(Console.ReadLine());

if(n>MAX){
    Console.WriteLine("El maximo de elementos a introducir es {0}", MAX);
    return 1;
}

califs=new double[n];
for(int i=0; i<califs.Length; i++){
    Console.Write($"califs[{i}]=");
    califs[i]=double.Parse(Console.ReadLine());
}

est.Imprime(califs);
may = est.Mayor(califs);
men = est.Menor(califs);
prom = est.Promedio(califs);
var = est.Varianza(califs, prom);
desv = Math.Sqrt(var);

Console.WriteLine("\n Resumen de estadisticas: ");

Console.WriteLine($"\n Numero de elementos: {califs.Length}");
Console.WriteLine($"\n El mayor es: {may:f2}");
Console.WriteLine($"\n El menor es: {men:f2} ");
Console.WriteLine($"\n El promedio es: {prom:f2} ");
Console.WriteLine($"\n La varianza es: {var:f2} ");
Console.WriteLine($"\n La desviación es: {desv:f2} ");

return 0;


