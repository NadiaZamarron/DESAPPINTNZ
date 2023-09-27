// Jugador

public class Jugador{

    public string Nombre {get; set;}
    public int  AñoNac {get; set;}
    public char Sexo {get; set;}
    public bool Becado {get; set;}

public Jugador(){}
    public Jugador(string Nombre)=> Nombre = nombre;
    public Jugador(string Nombre, int AñoNac, char Sexo, bool Becado) => (Nombre, AñoNac, Sexo, Becado) = (Nombre, Edad, Sexo, Becado);

public void ImprimirDatos() {
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"AñoNac: {AñoNac}");
    Console.WriteLine($"Sexo: {Sexo}");
    Console.WriteLine($"Becado: {Becado}"); 
    
    }
}
