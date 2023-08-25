//Nadia Zamarrón 
//Programa que calcula el factorial de n numeros 

int i,j,n,f;
char resp;
do {
Console.Clear();
Console.Write("¿Cuantos números? "); n = int.Parse(Console.ReadLine());
for(i=1; i<=n; i++) {
Console.Write($"{i}!=");
f=1;
for(j=1; j<=i; j++) {
f *= j;

}
Console.Write($" {f} \n");
}
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado...");
