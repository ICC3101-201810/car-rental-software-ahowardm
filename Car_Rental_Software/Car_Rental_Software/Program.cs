using System;
using System.Linq;
using System.Collections.Generic;

namespace Car_Rental_Software
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenido a Car Rental");
      int opcion;
      List<Sucursal> sucursales = new List<Sucursal>();
      List<Cliente> clientes = new List<Cliente>();

      while (true)
      {
        opcion = SeleccionaOpcion(GeneraOpciones());
        int sucursal_editar = 0;
        switch (opcion)
        {
          case -1:
            // Salir
            return;
          case 1:
            // Crear una sucursal
            CrearSucursal(sucursales);
            break;
          case 2:
            // Editar una sucursal
            //sucursal_editar = SeleccionarSucursal(sucursales, "editar su nombre");
            break;
          case 3:
            //Arrendar un vehiculo
            sucursal_editar = SeleccionarSucursal(sucursales, "arrendar sus vehiculos");


            break;
          case 4:
            //Agregar vehiculo a sucursal
            int sucursal = SeleccionarSucursal(sucursales, "agregar un vehiculo");
            AgregarVehiculoASucursal(sucursales[sucursal]);
            //sucursales[sucursal_editar].AgregarVehiculo(new Vehiculo(tipo));

            break;
        }
      }
    }

    static private void CrearSucursal(List<Sucursal> sucursales){
      Console.Write("Ingrese un nombre para la sucursal a crear: ");
      String nombre_sucursal = Console.ReadLine();
      sucursales.Add(new Sucursal(nombre_sucursal));
    }

    static private void AgregarVehiculoASucursal(Sucursal sucursal){
      Console.WriteLine("Ingrese el tipo de vehiculo (puede ser auto, moto, acuatico, camion, bus o retroexcavadora)");
      String tipo = "";
      while(true){
        if ((tipo = Console.ReadLine()) != "auto" && tipo != "moto" && tipo != "acuatico" && tipo != "camion" && tipo != "bus" && tipo != "retroexcavadora")
          Console.WriteLine("Opción no soportada, ingrese nuevamente");
        else
          break;
      }
      Console.Write("Ingrese la marca del nuevo vehiculo: ");
      String marca = Console.ReadLine();
      Console.Write("Ingrese el modelo del nuevo vehiculo: ");
      String modelo = Console.ReadLine();

      if (tipo == "auto")
        sucursal.AgregarVehiculo(new Auto(marca, modelo));
      else if (tipo == "moto")
        sucursal.AgregarVehiculo(new Moto(marca, modelo));
      else if (tipo == "acuatico")
        sucursal.AgregarVehiculo(new Acuatico(marca, modelo));
      else if (tipo == "camion")
        sucursal.AgregarVehiculo(new Camion(marca, modelo));
      else if (tipo == "bus")
        sucursal.AgregarVehiculo(new Bus(marca, modelo));
      else if (tipo == "retroexcavadora")
        sucursal.AgregarVehiculo(new Retroexcavadora(marca, modelo));
    }

    static private int SeleccionarSucursal(List<Sucursal> sucursales, String objetivo){
      Console.WriteLine("Seleccione el id de la sucursal para " + objetivo + ": ");
      int i = 0;
      foreach (var sucursal in sucursales)
      {
        Console.WriteLine(i + ": " + sucursal);
        i++;
      }
      int sucursal_editar = 0;
      while (true)
      {
        try
        {
          Int32.TryParse(Console.ReadLine(), out sucursal_editar);
          break;
        }
        catch
        {
          Console.WriteLine("Opcion no soportada ingrese nuevamente ");
        }
      }
      return sucursal_editar;
    }

    static private int SeleccionarVehiculo(Sucursal sucursal){
      Console.WriteLine("Seleccione el id del vehiculo a editar: ");
      sucursal.ImprimirVehiculos();
      int vehiculo_editar = 0;
      while (true)
      {
        try
        {
          Int32.TryParse(Console.ReadLine(), out vehiculo_editar);
          break;
        }
        catch
        {
          Console.WriteLine("Opcion no soportada ingrese nuevamente ");
        }
      }
      return vehiculo_editar;
    }


    // Muestra el menu y el usuario selecciona lo que quiere hacer
    static public int SeleccionaOpcion(Dictionary<int, String> opciones_validas){
      int opcion = 0, cnt = 0;
      while(true){
        if (cnt > 0)
        {
          Console.WriteLine("Opcion ingresada no es valida, por favor intente nuevamente.");
        }
        Console.WriteLine("Seleccione una de las siguientes opciones:");
        ImprimeMenu(opciones_validas);
        Console.Write("Opcion: ");
        // Lee la opcion del teclado
        try{
          Int32.TryParse(Console.ReadLine(), out opcion);
        }
        catch{
          // opcion sigue siendo 0, por lo que se va a repetir el ciclo diciendo que la opcion no es valida.
        }

        // Valida si es una opcion valida
        if (opciones_validas.ContainsKey(opcion))
          break;
        else
          cnt++;
      }
      return opcion;
    }
    static public Dictionary<int, String> GeneraOpciones(){
      Dictionary<int, String> opciones_validas = new Dictionary<int, string>();
      opciones_validas.Add(-1, "Salir");
      opciones_validas.Add(1, "Crear una sucursal");
      //opciones_validas.Add(2, "Editar una sucursal");
      opciones_validas.Add(3, "Arrendar un vehiculo");
      opciones_validas.Add(4, "Agregar vehiculo a sucursal");

      return opciones_validas;
    }

    static public void ImprimeMenu(Dictionary<int, String> opciones_validas){
      foreach(KeyValuePair<int, String> kvp in opciones_validas){
        Console.WriteLine(kvp.Key + ": " + kvp.Value);
      }
    }
  }
}
