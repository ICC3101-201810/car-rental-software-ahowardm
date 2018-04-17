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
      return false;
    }

    public Boolean Devolver()
    {
      if (arrendado == true)
        return false;
      return true;
    }

    public override String ToString()
    {
      return marca + ", " + modelo + ": " + arrendado;
    }
  }
}