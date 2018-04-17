using System;

namespace Car_Rental_Software{
  class Auto : Vehiculo{
    Boolean asientos_extra, maletero_grande, electrico;

    public Auto(String marca, String modelo) : base(marca, modelo, "auto", 25000){
      asientos_extra = false;
      maletero_grande = false;
      electrico = false;
    }

    public void EsElectrico(){
      electrico = true;
    }

    public void MaleteroGrande(){
      maletero_grande = true;
    }

    public void AsientosExtra(){
      asientos_extra = true;
    }

    public override string ToString()
    {
      String ret = marca + ", " + modelo;
      if (electrico)
        ret += " electrico";
      if (asientos_extra)
        ret += " asientos extra";
      if (maletero_grande)
        ret += " maletero grande";
      if (!arrendado)
        ret += " disponible";
      else
        ret += " arrendado";
      return ret;
      //return base.ToString();
    }
  }
}