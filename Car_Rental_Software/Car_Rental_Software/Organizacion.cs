using System;

namespace Car_Rental_Software{
  class Organizacion : Cliente{
    String razon_social;

    public Organizacion(Boolean autorizacion, String rut, String razon_social) : base(rut)
    {
      this.razon_social = razon_social;
    }
  }
}