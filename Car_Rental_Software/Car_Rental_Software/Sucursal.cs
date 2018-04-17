using System;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  class Sucursal
  {
    String nombre;
    List<Vehiculo> vehiculos;
    List<Accesorio> accesorios;
    List<Cliente> clientes;
    List<Arriendo> arriendos;

    public Sucursal(String nombre, List<Vehiculo> vehiculos, List<Cliente> clientes, List<Accesorio> accesorios){
      this.nombre = nombre;
      this.vehiculos = vehiculos;
      this.clientes = clientes;
      this.accesorios = accesorios;
      arriendos = new List<Arriendo>();
    }

    public Sucursal(String nombre){
      this.nombre = nombre;
      vehiculos = new List<Vehiculo>();
      accesorios = new List<Accesorio>();
      clientes = new List<Cliente>();
      arriendos = new List<Arriendo>();
    }


    /***************************************
    * Agrega cliente, vehiculo y accesorio *
    ****************************************/
    public Boolean AgregarCliente(Cliente cliente){
      clientes.Add(cliente);
      return true;
    }

    static int AgregarCliente(List<Cliente> clientes){
      Console.WriteLine("Ingrese el tipo de cliente que va a ingresar (empresa, institucion, organizacion o persona): ");
      Console.Write("Tipo de cliente: ");
      String tipo = "";
      while(true){
        if ((tipo = Console.ReadLine()) != "empresa" && tipo != "institucion" && tipo != "organizacion" && tipo != "persona")
          Console.Write("Opción no soportada, ingrese nuevamente.\nTipo: ");
        else
          break;
      }
      // La inicializacion siguiente se va a sobreescribir
      Cliente nuevo = new Empresa("", "");
      if (tipo == "empresa")
        nuevo = CrearEmpresa();
      else if (tipo == "institucion")
        nuevo = CrearInstitucion();
      else if (tipo == "organizacion")
        nuevo = CrearOrganizacion();
      else if (tipo == "persona")
        nuevo = CrearPersona();

      clientes.Add(nuevo);
      return clientes.Count - 1;
    }

    static public Empresa CrearEmpresa(){
      Console.Write("Ingrese razón social de la empresa a ingresar: ");
      String razon_social = Console.ReadLine();
      Console.Write("Ingrese el rut de la empresa a ingresar: ");
      String rut = Console.ReadLine();
      return new Empresa(rut, razon_social);
    }

    static public Institucion CrearInstitucion()
    {
      Console.Write("Ingrese razón social de la institucion a ingresar: ");
      String razon_social = Console.ReadLine();
      Console.Write("Ingrese el rut de la institucion a ingresar: ");
      String rut = Console.ReadLine();
      return new Institucion(rut, razon_social);
    }

    static public Organizacion CrearOrganizacion()
    {
      Console.Write("Ingrese razón social de la organizacion a ingresar: ");
      String razon_social = Console.ReadLine();
      Console.Write("Ingrese el rut de la organizacion a ingresar: ");
      String rut = Console.ReadLine();
      return new Organizacion(rut, razon_social);
    }

    static public Persona CrearPersona()
    {
      Console.Write("Ingrese el nombre de la persona a ingresar: ");
      String nombre = Console.ReadLine();
      Console.Write("Ingrese el apellido de la persona a ingresar: ");
      String apellido = Console.ReadLine();
      Console.Write("Ingrese el rut de la empresa a ingresar: ");
      String rut = Console.ReadLine();
      return new Persona(rut, nombre, apellido);
    }

    public Boolean AgregarVehiculo(Vehiculo vehiculo){
      vehiculos.Add(vehiculo);
      return true;
    }

    public Boolean AgregarAccesorio(Accesorio accesorio){
      accesorios.Add(accesorio);
      return true;
    }

    public Boolean AdministraArriendo(){
      int cliente = SeleccionarCliente(clientes);
      if (cliente == -1){
        // AgregarCliente retorna la posicion donde fue agregado en la lista el cliente nuevo
        cliente = AgregarCliente(clientes);
      }
      // Aqui ya tenemos el cliente seleccionado en la variable cliente (posicion en la lista)
      int vehiculo = SeleccionarVehiculo(vehiculos);

      return false;
    }

    public Boolean Arrendar(Vehiculo vehiculo, Cliente cliente){
      if (cliente.PuedeManejarVehiculo(vehiculo.tipo)){
        arriendos.Add(new Arriendo(vehiculo, cliente, null));
        return true;
      }
      return false;
    }

    //public Boolean Devolver(Vehiculo vehiculo, Cliente cliente){
    //  
    //}
    static private int SeleccionarCliente(List<Cliente> clientes)
    {
      Console.WriteLine("Seleccione el id del cliente que va a arrendar (-1 para ingresar cliente nuevo): ");
      ImprimirClientes(clientes);
      int cliente = 0;
      Console.Write("id Cliente: ");
      while (true)
      {
        try
        {
          Int32.TryParse(Console.ReadLine(), out cliente);
          if (cliente >= 0 && cliente < clientes.Count)
            break;
          else
            Console.Write("Opcion no soportada ingrese nuevamente. \nid Cliente: ");
        }
        catch
        {
          Console.Write("Opcion no soportada ingrese nuevamente. \nid Cliente: ");
        }
      }
      return cliente;
    }

    static private int SeleccionarVehiculo(List<Vehiculo> vehiculos){
      Console.WriteLine("Seleccione el id del vehiculo que va a arrendar: ");
      ImprimirVehiculos(vehiculos);
      int vehiculo = 0;
      Console.Write("id vehiculo: ");
      while(true){
        try{
          Int32.TryParse(Console.ReadLine(), out vehiculo);
          if (vehiculo >= 0 && vehiculo < vehiculos.Count && !vehiculos[vehiculo].arrendado)
            break;
          else
            Console.Write("Opcion no soportada ingrese nuevamente. \nid Cliente: ");
        }
        catch{
          Console.Write("Opcion no soportada ingrese nuevamente. \nid Vehiculo: ");
        }
      }
      return vehiculo;
    }


    public override String ToString(){
      return nombre;
    }

    public void ImprimirVehiculos(){
      for (int i = 0; i < vehiculos.Count; i++){
        Console.WriteLine(i + ": " + vehiculos[i]);
      }
    }

    static public void ImprimirVehiculos(List<Vehiculo> vehiculos){
      for (int i = 0; i < vehiculos.Count; i++){
        Console.WriteLine(vehiculos[i]);
      }
    }

    static public void ImprimirClientes(List<Cliente> clientes){
      for (int i = 0; i < clientes.Count; i++){
        Console.WriteLine(clientes[i]);
      }
    }

    public List<Vehiculo> Vehiculos{
      get{
        return vehiculos;
      }
      set{
        vehiculos = value;
      }
    }
  }
}