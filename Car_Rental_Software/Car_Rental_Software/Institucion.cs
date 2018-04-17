using System;

namespace Car_Rental_Software{
  class Institucion : Cliente{
    String razon_social;

    public Institucion(Boolean autorizacion, String rut, String razon_social) : base(rut)
    {
      this.razon_social = razon_social;
    }
  }
}