using System;

namespace Car_Rental_Software{
  class Empresa : Cliente{
    public String Razon_social { get; set; }

    public Empresa(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
    }

    public override string ToString()
    {
      return Razon_social;
    }
  }
}