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
        switch (opcion)
        {
          case -1:
            // Salir
            return;
          case 1:
            // Crear una sucursal
            Console.Write("Ingrese un nombre para la sucursal a crear: ");
            String nombre_sucursal = Console.ReadLine();
            sucursales.Add(new Sucursal(nombre_sucursal));
            break;
          case 2:
            // Editar un vehiculo
            Console.WriteLine("Seleccione el id de la sucursal para editar sus vehiculos: ");
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
            Console.WriteLine("Seleccione el id del vehiculo a editar: ");
            sucursales[sucursal_editar].ImprimirVehiculos();
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
            Console.WriteLine("Vamos a editar el siguiente vehiculo: " + sucursales[sucursal_editar].Vehiculos[vehiculo_editar]);
            Console.WriteLine("Ingrese el nuevo tipo de vehiculo");
            String nuevo_tipo = Console.ReadLine();
            sucursales[sucursal_editar].Vehiculos[vehiculo_editar].Tipo = nuevo_tipo;

            break;
          case 3:
            //Arrendar un vehiculo
            Console.WriteLine("Seleccione el id de la sucursal para arrendar sus vehiculos: ");
            int i2 = 0;
            foreach (var sucursal in sucursales)
            {
              Console.WriteLine(i2 + ": " + sucursal);
              i2++;
            }
            //int sucursal_editar;
            try
            {
              Int32.TryParse(Console.ReadLine(), out sucursal_editar);
            }
            catch
            {
              Console.WriteLine("Opcion no soportada ");
            }

            break;
          case 4:
            //Agregar vehiculo a sucursal
            Console.WriteLine("Seleccione el id de la sucursal para agregar un vehiculo: ");
            int i3 = 0;
            foreach (var sucursal in sucursales)
            {
              Console.WriteLine(i3 + ": " + sucursal);
              i3++;
            }
            // int sucursal_editar = 0;
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
            Console.WriteLine("Ingrese el tipo de vehiculo (puede ser auto, moto, acuatico, camion, bus o maquinaria)");
            String tipo = Console.ReadLine();
            sucursales[sucursal_editar].AgregarVehiculo(new Vehiculo(tipo));
            break;
            default:
              break;
        }
      }
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
      opciones_validas.Add(2, "Editar una sucursal");
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
