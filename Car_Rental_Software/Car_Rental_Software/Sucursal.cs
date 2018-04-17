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
      Empresa ret = new Empresa(rut, razon_social);
      Console.Write("Esta empresa puede manejar autos? (s/n)");
      String autos = Console.ReadLine();
      if (autos == "s")
        ret.IngresaPermiso("auto");
      Console.Write("Esta empresa puede manejar motos? (s/n)");
      String moto = Console.ReadLine();
      if (moto == "s")
        ret.IngresaPermiso("moto");
      Console.Write("Esta empresa puede manejar camiones? (s/n)");
      String camion = Console.ReadLine();
      if (camion == "s")
        ret.IngresaPermiso("camion");
      Console.Write("Esta empresa puede manejar camionetas? (s/n)");
      String camioneta = Console.ReadLine();
      if (camioneta == "s")
        ret.IngresaPermiso("camioneta");
      Console.Write("Esta empresa puede manejar retroexcavadoras? (s/n)");
      String retro = Console.ReadLine();
      if (retro == "s")
        ret.IngresaPermiso("retroexcavadora");
      return ret;
    }

    static public Institucion CrearInstitucion()
    {
      Console.Write("Ingrese razón social de la institucion a ingresar: ");
      String razon_social = Console.ReadLine();
      Console.Write("Ingrese el rut de la institucion a ingresar: ");
      String rut = Console.ReadLine();
      Institucion ret = new Institucion(rut, razon_social);
      Console.Write("Esta institucion puede manejar autos? (s/n)");
      String autos = Console.ReadLine();
      if (autos == "s")
        ret.IngresaPermisoInstitucion("auto");
      Console.Write("Esta institucion puede manejar motos? (s/n)");
      String moto = Console.ReadLine();
      if (moto == "s")
        ret.IngresaPermisoInstitucion("moto");
      Console.Write("Esta institucion puede manejar camiones? (s/n)");
      String camion = Console.ReadLine();
      if (camion == "s")
        ret.IngresaPermisoInstitucion("camion");
      Console.Write("Esta institucion puede manejar camionetas? (s/n)");
      String camioneta = Console.ReadLine();
      if (camioneta == "s")
        ret.IngresaPermisoInstitucion("camioneta");
      Console.Write("Esta institucion puede manejar retroexcavadoras? (s/n)");
      String retro = Console.ReadLine();
      if (retro == "s")
        ret.IngresaPermisoInstitucion("retroexcavadora");
      return ret;
    }

    static public Organizacion CrearOrganizacion()
    {
      Console.Write("Ingrese razón social de la organizacion a ingresar: ");
      String razon_social = Console.ReadLine();
      Console.Write("Ingrese el rut de la organizacion a ingresar: ");
      String rut = Console.ReadLine();
      Organizacion ret = new Organizacion(rut, razon_social);
      Console.Write("Esta organizacion puede manejar autos? (s/n)");
      String autos = Console.ReadLine();
      if (autos == "s")
        ret.IngresaPermisoOrganizacion("auto");
      Console.Write("Esta organizacion puede manejar motos? (s/n)");
      String moto = Console.ReadLine();
      if (moto == "s")
        ret.IngresaPermisoOrganizacion("moto");
      Console.Write("Esta organizacion puede manejar camiones? (s/n)");
      String camion = Console.ReadLine();
      if (camion == "s")
        ret.IngresaPermisoOrganizacion("camion");
      Console.Write("Esta organizacion puede manejar camionetas? (s/n)");
      String camioneta = Console.ReadLine();
      if (camioneta == "s")
        ret.IngresaPermisoOrganizacion("camioneta");
      Console.Write("Esta organizacion puede manejar retroexcavadoras? (s/n)");
      String retro = Console.ReadLine();
      if (retro == "s")
        ret.IngresaPermisoOrganizacion("retroexcavadora");
      return ret;
    }

    static public Persona CrearPersona()
    {
      Console.Write("Ingrese el nombre de la persona a ingresar: ");
      String nombre = Console.ReadLine();
      Console.Write("Ingrese el apellido de la persona a ingresar: ");
      String apellido = Console.ReadLine();
      Console.Write("Ingrese el rut de la persona a ingresar: ");
      String rut = Console.ReadLine();
      Persona ret = new Persona(rut, nombre, apellido);
      Console.Write("Esta persona puede manejar autos? (s/n)");
      String autos = Console.ReadLine();
      if (autos == "s")
        ret.IngresaPermisoPersona("auto");
      Console.Write("Esta persona puede manejar motos? (s/n)");
      String moto = Console.ReadLine();
      if (moto == "s")
        ret.IngresaPermisoPersona("moto");
      Console.Write("Esta persona puede manejar camiones? (s/n)");
      String camion = Console.ReadLine();
      if (camion == "s")
        ret.IngresaPermisoPersona("camion");
      Console.Write("Esta persona puede manejar camionetas? (s/n)");
      String camioneta = Console.ReadLine();
      if (camioneta == "s")
        ret.IngresaPermisoPersona("camioneta");
      Console.Write("Esta persona puede manejar retroexcavadoras? (s/n)");
      String retro = Console.ReadLine();
      if (retro == "s")
        ret.IngresaPermisoPersona("retroexcavadora");

      return ret;
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
      if (vehiculo == -1)
        return false;
      //Console.WriteLine("El vehiculo tiene id: " + vehiculo);
      Arrendar(vehiculos[vehiculo], clientes[cliente], arriendos);
      return false;
    }

    public Boolean AdministraDevolucion(){
      int cliente = SeleccionarCliente(clientes);
      for (int i = 0; i < arriendos.Count; i++)
        if (arriendos[i].cliente.rut == clientes[cliente].rut)
        {
          arriendos[i].vehiculo.Devolver();
          Console.WriteLine("Devolucion ingresada con exito.");
          return true;
        }
        return false;
    }


    static public Boolean Arrendar(Vehiculo vehiculo, Cliente cliente, List<Arriendo> arriendos){
      if (cliente.PuedeManejarVehiculo(vehiculo.tipo)){
        Console.Write("Ingrese la cantidad de dias que quiere arrendar el vehiculo: ");
        int cantidad_dias = Int32.Parse(Console.ReadLine());
        if (vehiculo.Arrendar())
        {
          arriendos.Add(new Arriendo(vehiculo, cliente, null, DateTime.Today, cantidad_dias));
          Console.WriteLine("Arriendo ingresado con exito.");
          return true;
        }
        else
          Console.WriteLine("El cliente " + cliente + " no tiene permiso para manejar este tipo de vehiculos.");
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
          if (cliente == -1)
            return cliente;
          else if (cliente >= 0 && cliente < clientes.Count)
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
      Console.WriteLine("Seleccione el id del vehiculo (-1 para volver al menu principal): ");
      ImprimirVehiculos(vehiculos);
      int vehiculo = 0;
      Console.Write("id vehiculo: ");
      while(true){
        try{
          Int32.TryParse(Console.ReadLine(), out vehiculo);
          if (vehiculo == -1)
            return -1;
          else if (vehiculo >= 0 && vehiculo < vehiculos.Count && !vehiculos[vehiculo].arrendado)
            return vehiculo;
          else
            Console.Write("Opcion no soportada ingrese nuevamente. \nid Vehiculo: ");
        }
        catch{
          Console.Write("Opcion no soportada ingrese nuevamente. \nid Vehiculo: ");
        }
      }
      //return vehiculo;
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
        Console.WriteLine(i + ": " + vehiculos[i]);
      }
    }

    static public void ImprimirClientes(List<Cliente> clientes){
      for (int i = 0; i < clientes.Count; i++){
        Console.WriteLine(i + ": " + clientes[i]);
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