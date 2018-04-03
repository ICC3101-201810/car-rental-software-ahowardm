using System;

namespace Car_Rental_Software{
  class Empresa : Cliente{
    String razon_social;

    public Empresa(Boolean autorizacion, String rut, String razon_social) : base(autorizacion, rut)
    {
      this.razon_social = razon_social;
    }
  }
}