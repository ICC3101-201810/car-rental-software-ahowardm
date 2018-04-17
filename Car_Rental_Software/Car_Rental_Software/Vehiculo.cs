using System;

namespace Car_Rental_Software{
  abstract class Vehiculo
  {
    String marca;
    String modelo;
    Boolean arrendado;

    public Vehiculo(String marca, String modelo)
    {
      this.marca = marca;
      this.modelo = modelo;
      arrendado = false;
    }

    /****************************************
     * Funcionalidad de arrendar y devolver *
     ****************************************/
    public Boolean Arrendar()
    {
      if (arrendado == false)
      {
        arrendado = true;
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
      return ": " + arrendado;
    }
  }
}