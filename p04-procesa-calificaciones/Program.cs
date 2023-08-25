//Nadia Zamarrón
//Procesa n calificaciones, calcula la suma y el promedio

int n,c;
float calif,suma, prom;

calif=suma=prom=0;

Console.Clear();
Console.WriteLine("Procesa n calificaciones, calcula la suma y el promedio\n");
Console.Write("Cuantas calificaciones? ");
n=int.Parse(Console.ReadLine());

c=1;
while( c <= n ) {

    Console.Write($"Calificacion {c}? ",c++);
    calif = float.Parse(Console.ReadLine());
    suma = suma + calif;
}

prom = suma / n;

Console.WriteLine($"La suma es : {suma:f2}");
Console.WriteLine($"El promedio es : {prom:f2}");
