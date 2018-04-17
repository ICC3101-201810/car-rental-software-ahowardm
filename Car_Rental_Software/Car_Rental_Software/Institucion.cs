using System;

namespace Car_Rental_Software{
  class Institucion : Cliente{
    public String Razon_social { get; set; }

    public Institucion(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
    }
  }
}