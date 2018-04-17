using System;

namespace Car_Rental_Software{
  class Organizacion : Cliente{
    public String Razon_social { get; set; }

    public Organizacion(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
      if (new Random().NextDouble() >= 0.35)
        this.IngresaPermisoOrganizacion("bus");
    }

    public override string ToString()
    {
      return Razon_social;
    }

    public Boolean IngresaPermisoOrganizacion(String tipo)
    {
      if (tipo != "retroexcavadora")
        return IngresaPermiso(tipo);
      return false;
    }
  }
}