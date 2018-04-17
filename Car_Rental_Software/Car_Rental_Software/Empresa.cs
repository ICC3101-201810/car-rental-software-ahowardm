using System;

namespace Car_Rental_Software{
  class Empresa : Cliente{
    public String Razon_social { get; set; }

    public Empresa(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
      if (new Random().NextDouble() >= 0.63)
        IngresaPermiso("retroexcavadora");
      if (new Random().NextDouble() >= 0.8)
        IngresaPermiso("bus");
    }

    public override string ToString()
    {
      return Razon_social;
    }
  }
}