using System;

namespace Car_Rental_Software{
  abstract class Vehiculo
  {
    public String marca { get; set;  }
    public String modelo { get; set;  }
    public Boolean arrendado { get; set; }
    public String tipo { get; }
    public int precio { get;  }

    public Vehiculo(String marca, String modelo, String tipo, int precio)
    {
      this.marca = marca;
      this.modelo = modelo;
      arrendado = false;
      this.tipo = tipo;
      this.precio = precio;
    }

    /****************************************
     * Funcionalidad de arrendar y devolver *
     ****************************************/
    public Boolean Arrendar()
    {
      if (arrendado == false)
      {
        arrendado = true;
        return true;
      }
      Console.WriteLine("Vehiculo no disponible para arriendo");
      return false;
    }

    public Boolean Devolver()
    {
      if (arrendado == true){
        arrendado = false;
        return false;
      }
      Console.WriteLine("Vehiculo no estaba arrendado");
      return true;
    }

    public override String ToString()
    {
      String ret = marca + ", " + modelo + ": ";
      if (!arrendado)
        ret += "disponible";
      else
        ret += "arrendado";
      return ret;
    }
  }
}