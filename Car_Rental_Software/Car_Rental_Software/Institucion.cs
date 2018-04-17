using System;

namespace Car_Rental_Software{
  class Institucion : Cliente{
    public String Razon_social { get; set; }

    public Institucion(String rut, String razon_social) : base(rut)
    {
      this.Razon_social = razon_social;
      if (new Random().NextDouble() >= 0.58)
        this.IngresaPermisoInstitucion("bus");
    }

    public override string ToString()
    {
      return Razon_social;
    }

    public Boolean IngresaPermisoInstitucion(String tipo)
    {
      if (tipo != "retroexcavadora")
        return IngresaPermiso(tipo);
      return false;
    }
  }
}