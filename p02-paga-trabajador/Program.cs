//Nadia Zamarrón 
//Calcula la paga de un trabajador, considerando las horas extra

string nombre;
int horas, hextra=0;
float paga, pagaextra=0,pagabruta, paganeta, impuesto, tasa;

Console.Clear();
Console.WriteLine("Calculando la paga de un trabajador \n");
Console.Write("Nombre ? ") ; nombre = Console.ReadLine();
Console.Write("Horas trabajadas ? ") ; horas = int.Parse(Console.ReadLine());
Console.Write("Paga por hora ? ") ; paga = float.Parse(Console.ReadLine());
tasa = 0.03f;

if(horas>40) {
hextra = horas - 40;
pagaextra = 
pagabruta = 40 * paga + (2 * paga * hextra);
} else
pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

Console.WriteLine($"Resumen de pagos del trabajador {nombre}:\n");
Console.WriteLine($"Horas trabajadas {horas} de las cuales {hextra} son extra, se asume una tasa de impuesto de {tasa:p2}");
Console.WriteLine($"Paga bruta: {pagabruta,12:c2}");
Console.WriteLine($"Impuessto: {impuesto,12:c2}");
Console.WriteLine($"Paga neta: {paganeta,12:c2}");