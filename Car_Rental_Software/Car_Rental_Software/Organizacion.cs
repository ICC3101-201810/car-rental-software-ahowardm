using System;

namespace Car_Rental_Software{
  class Organizacion : Cliente{
    public String Razon_social { get; set; }

    public Organizacion(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
    }
  }
}