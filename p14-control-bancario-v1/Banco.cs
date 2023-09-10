public class Banco {
public string Nombre {get; private set;}
public string Direccion {get; private set;}
public List<Cliente> Clientes {get; private set;}
public Banco() => Clientes = new List<Cliente>();
public Banco(string nombre, string domicilio) : this() => (Nombre,Direccion) = (nombre,domicilio);
public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);
public override string ToString() => $"{Nombre}, {Direccion}";
}