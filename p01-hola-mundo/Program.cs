//Nadia Zamarrón
//Programa que envia un saludo en pantalla 

string amigo="Juan";
string hermano="Pablo";
Console.WriteLine(amigo);
amigo="Miguel";
Console.WriteLine("Hola "+amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo es {amigo} y mi hermano es {hermano}\n");
Console.WriteLine("Nombres con mayusculas:");
Console.WriteLine($"{amigo.ToUpper()} y {hermano.ToUpper()}");