// Academia 

public class Academia{

    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}

    public Academia() => Categorias = new List<Categoria>();
    public Academia(string nombre,string propietario,string domicilio) : this() =>
            (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public double Total() {
        double total=0;
        foreach(Categoria in Categorias)
          total = total + categorias.SubTotal();
        return total;
    }

    public double TotaHombres() {
        int total=0;

        return total;
    }
    public double TotaMujeres() {
        int total=0;
        
        return total;
    }
}