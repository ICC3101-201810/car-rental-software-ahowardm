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
      int opcion = SeleccionaOpcion(GeneraOpciones());

      switch (opcion){
        case 1:
          // Crear una sucursal
          break;
        case 2:
          // Arrendar un vehiculo
          break;
        default:
          break;
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

      return opciones_validas;
    }

    static public void ImprimeMenu(Dictionary<int, String> opciones_validas){
      foreach(KeyValuePair<int, String> kvp in opciones_validas){
        Console.WriteLine(kvp.Key + ": " + kvp.Value);
      }
    }
  }
}
