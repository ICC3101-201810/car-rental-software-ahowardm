using System;
using System.Collections.Generic;

namespace Car_Rental_Software{
  class Accesorio{
    String tipo;
    Boolean arrendado;

    public Accesorio(String tipo){
      this.tipo = tipo;
      arrendado = false;
    }

    public override string ToString()
    {
      return tipo + ": " + arrendado;
    }

  }
}