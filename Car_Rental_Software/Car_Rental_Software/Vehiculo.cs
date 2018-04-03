using System;

namespace Car_Rental_Software{
  class Vehiculo{
    String tipo;
    Boolean arrendado;

    public Vehiculo(String tipo){
      this.tipo = tipo;
      arrendado = false;
    }

    /****************************************
     * Funcionalidad de arrendar y devolver *
     ****************************************/
    public Boolean Arrendar(){
      if (arrendado == false) {
        arrendado = true;
      }
      return false;
    }

    public Boolean Devolver(){
      if (arrendado == true)
        return false;
      return true;
    }
  }
}