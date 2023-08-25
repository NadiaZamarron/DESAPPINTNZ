//Nadia Zamarrón
//Imprime tabla de conversión de peso a dolar

int ini, fin, c;
float tc = 19.99f;
char resp;

do {
Console.Clear();
Console.WriteLine("Imprime una tabla de conversion de peso a dolar\n");
do {
Console.Write("Inicio : "); ini = int.Parse(Console.ReadLine());
Console.Write("Fin : "); fin = int.Parse(Console.ReadLine());
    } while(fin<ini);

c=ini;
Console.WriteLine(new string('-',20));
Console.WriteLine("Peso\tDolar");
Console.WriteLine(new string('-',20));

while( c<=fin ) {

Console.WriteLine($"{c}\t{c/tc:f4}");
c++;
}

Console.WriteLine(new string('-',20));
Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\n¡Gracias por utilizar este programa!");
